using System;
using System.Collections;
using PoeHUD.Framework;
using PoeHUD.Models;
using PoeHUD.Poe.RemoteMemoryObjects;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using PoeHUD.DebugPlug;
using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.Performance;

namespace PoeHUD.Controllers
{
    public class GameController
    {
        public static GameController Instance;
        public GameController(Memory memory)
        {
            Instance = this;
            Memory = memory;
            Area = new AreaController(this);
            EntityListWrapper = new EntityListWrapper(this);
            Window = new GameWindow(memory.Process);
            Game = new TheGame(memory);
            Files = new FsController(memory);
            CoroutineRunner = new Runner();
            InGame = InGameReal;
            IsForeGroundCache = WinApi.IsForegroundWindow(Window.Process.MainWindowHandle);
            Cache = new Cache();
            if (Cache.Enable)
            {
                Cache.Enable = false;
                (new Coroutine(EnableCacheTimeout(), nameof(GameController), "Cache Enabler")).Run();
            }
        }

        public EntityListWrapper EntityListWrapper { get; }
        public GameWindow Window { get; private set; }
        public TheGame Game { get; }
        public AreaController Area { get; }

        public Cache Cache { get; private set; }
        public Memory Memory { get; private set; }

        public Stopwatch mainSw = Stopwatch.StartNew();
        public IEnumerable<EntityWrapper> Entities => EntityListWrapper.Entities;

        public EntityWrapper Player => EntityListWrapper.Player;
        public bool InGame { get; private set; }
        public bool InGameReal => Game.IngameStateReal.InGame;
        public bool AutoResume { get; set; }
        public FsController Files { get; private set; }
        public bool IsForeGroundCache { get; private set; }




        public Action Render;
        public Action Clear;
        public Dictionary<string, float> DebugInformation = new Dictionary<string, float>();
        public readonly Runner CoroutineRunner;
        public PerformanceSettings Performance;

        IEnumerator EnableCacheTimeout()
        {
            yield return new WaitRender();
            Cache.Enable = true;
        }

        public long RenderCount { get; private set; }
        public void WhileLoop()
        {
            DebugInformation["FpsLoop"] = 0;
            DebugInformation["FpsRender"] = 0;
            DebugInformation["FpsCoroutine"] = 0;
            DebugInformation["ElapsedMilliseconds"] = 0;
            var sw = Stopwatch.StartNew();
            float nextRenderTick = sw.ElapsedMilliseconds;
            var tickEverySecond = sw.ElapsedMilliseconds;
            var skipTicksRender = 0f;
            int fpsLoop = 0;
            int fpsRender = 0;
            int fpsCoroutine = 0;
            float updateRate = 1f / 60f;
            float loopLimit = 1;
            int deltaError = 300;//THIS IS SPARTA!

            if (Performance != null)
            {
                loopLimit = Performance.LoopLimit;
                skipTicksRender = 1000f / Performance.RenderLimit.Value;
                Cache.Enable = Performance.Cache.Value;
            }


            var updateArea = (new Coroutine(() => { Area.RefreshState(); }, 100, nameof(GameController), "Update area") { Priority = CoroutinePriority.High });

            var updateEntity = (new Coroutine(() => { EntityListWrapper.RefreshState(); }, 50, nameof(GameController), "Update Entity") { Priority = CoroutinePriority.High });

            var updateGameState = (new Coroutine(() => {
                InGame = InGameReal;
                IsForeGroundCache = WinApi.IsForegroundWindow(Window.Process.MainWindowHandle);
            }, 100, nameof(GameController), "Update Game State")
            { Priority = CoroutinePriority.Critical }).Run();



            updateArea.AutoRestart().Run();
            updateEntity.AutoRestart().Run();

            int i = 0;
            void Action()
            {
                var allCoroutines = CoroutineRunner.Coroutines;
                if (!InGame || !IsForeGroundCache)
                {
                    Clear.SafeInvoke();
                    CoroutineRunner.StopCoroutines(allCoroutines);
                    AutoResume = true;
                }
                else
                {
                    if (AutoResume)
                    {
                        CoroutineRunner.ResumeCoroutines(allCoroutines);
                        AutoResume = false;
                    }
                }
                if (Performance != null)
                {
                    skipTicksRender = 1000f / Performance.RenderLimit.Value;
                    loopLimit = (int)(200 + Math.Pow(Performance.LoopLimit, 2));
                    updateEntity.TimeoutForAction = 1000 / Performance.UpdateEntityDataLimit.Value;
                    Cache.Enable = Performance.Cache.Value;
                }
                if (nextRenderTick - sw.ElapsedMilliseconds > deltaError || nextRenderTick - sw.ElapsedMilliseconds < deltaError)
                {
                    nextRenderTick = sw.ElapsedMilliseconds;
                }
                i++;
                if (i % 4 == 0)
                {
                    foreach (var autorestartCoroutine in CoroutineRunner.AutorestartCoroutines)
                    {
                        if (!CoroutineRunner.HasName(autorestartCoroutine.Name))
                            autorestartCoroutine.GetCopy().Run();
                    }
                }
            }

            var updateCoroutine = new Coroutine(Action, 250, nameof(GameController), "$#Main#$") { Priority = CoroutinePriority.Critical };
            updateCoroutine = CoroutineRunner.Run(updateCoroutine);
            sw.Restart();
            while (true)
            {
                if (!InGame)
                {
                    Thread.Sleep(50);
                }

                var startFrameTime = sw.Elapsed.TotalMilliseconds;

                for (int j = 0; j < CoroutineRunner.RunPerLoopIter; j++)
                {
                    if (CoroutineRunner.IsRunning)
                    {
                        fpsCoroutine++;
                        try
                        {
                            CoroutineRunner.Update();
                        }
                        catch (Exception e) { DebugPlugin.LogMsg($"{e.Message}", 1); }
                    }
                }


                if (sw.Elapsed.TotalMilliseconds > nextRenderTick && InGame && IsForeGroundCache)
                {
                    Render.SafeInvoke();
                    nextRenderTick += skipTicksRender;
                    fpsRender++;
                    RenderCount++;
                }


                if (sw.ElapsedMilliseconds > tickEverySecond)
                {
                    DebugInformation["FpsLoop"] = fpsLoop;
                    DebugInformation["FpsRender"] = fpsRender;
                    DebugInformation["FpsCoroutine"] = fpsCoroutine;
                    DebugInformation["Looplimit"] = loopLimit;
                    DebugInformation["ElapsedSeconds"] = sw.Elapsed.Seconds;
                    fpsLoop = 0;
                    fpsRender = 0;
                    fpsCoroutine = 0;
                    tickEverySecond += 1000;
                }
                fpsLoop++;
                DebugInformation["ElapsedMilliseconds"] = sw.ElapsedMilliseconds;
                DebugInformation["DeltaTimeMs"] = (float)(sw.Elapsed.TotalMilliseconds - startFrameTime);


                if (fpsLoop > loopLimit)
                {
                    Thread.Sleep(1);
                }
            }
        }
    }
}