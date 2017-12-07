using PoeHUD.Controllers;
using PoeHUD.Framework;
using PoeHUD.Hud;
using PoeHUD.Poe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoEHUD.Tools;

namespace PoeHUD
{
    public class Program
    {
        private static int FindPoeProcess(out Offsets offs)
        {
            var clients = Process.GetProcessesByName(Offsets.Regular.ExeName).Select(p => Tuple.Create(p, Offsets.Regular)).ToList();
            clients.AddRange(Process.GetProcessesByName(Offsets.Steam.ExeName).Select(p => Tuple.Create(p, Offsets.Steam)));
            int ixChosen = clients.Count > 1 ? chooseSingleProcess(clients) : 0;
            if (clients.Count > 0 && ixChosen >= 0)
            {
                offs = clients[ixChosen].Item2;
                return clients[ixChosen].Item1.Id;
            }
            offs = null;
            return 0;
        }

        private static int chooseSingleProcess(List<Tuple<Process, Offsets>> clients)
        {
            String o1 = $"Yes - process #{clients[0].Item1.Id}, started at {clients[0].Item1.StartTime.ToLongTimeString()}";
            String o2 = $"No - process #{clients[1].Item1.Id}, started at {clients[1].Item1.StartTime.ToLongTimeString()}";
            const string o3 = "Cancel - quit this application";
            var answer = MessageBox.Show(null, String.Join(Environment.NewLine, o1, o2, o3),
                "Choose a PoE instance to attach to", MessageBoxButtons.YesNoCancel);
            return answer == DialogResult.Cancel ? -1 : answer == DialogResult.Yes ? 0 : 1;
        }


        [STAThread]
        public static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, exceptionArgs) =>
            {
                var errorText = "Program exited with message:\n " + exceptionArgs.ExceptionObject;
                File.AppendAllText("Error.log", $"{DateTime.Now.ToString("g")} {errorText}\r\n{new string('-', 30)}\r\n");
                MessageBox.Show(errorText);
                Environment.Exit(1);
            };

#if !DEBUG
            MemoryControl.Start();
            if (Scrambler.Scramble(args.Length > 0 ? args[0] : null))
            {
                return;
            }
#endif

            Offsets offs;
            int pid = FindPoeProcess(out offs);

            if (pid == 0)
            {
                MessageBox.Show("Path of Exile is not running or you started x32 POE (DirectX9) with x64 PoeHUD or vice verse.");
                return;
            }

            Sounds.LoadSounds();

            using (var memory = new Memory(offs, pid))
            {
                offs.DoPatternScans(memory);
                var gameController = new GameController(memory);

#if DEBUG
                StringBuilder sb = new StringBuilder();

                sb.Append("AddressOfProcess: " + memory.AddressOfProcess.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("GameController full: " + (offs.Base + memory.AddressOfProcess).ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("GameController: " + (offs.Base + memory.AddressOfProcess).ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("TheGame: " + gameController.Game.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("IngameState: " + gameController.Game.IngameState.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);


                sb.Append("IngameData: " + gameController.Game.IngameState.Data.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("IngameUi: " + gameController.Game.IngameState.IngameUi.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("UIRoot: " + gameController.Game.IngameState.UIRoot.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("ServerData: " + gameController.Game.IngameState.ServerData.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);


                sb.Append("GetInventoryZone: " + memory.ReadLong(gameController.Game.IngameState.IngameUi.InventoryPanel.Address + Poe.Element.OffsetBuffers + 0x42c).ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("Area Addr: " + gameController.Game.IngameState.Data.CurrentArea.Address.ToString("X"));
                sb.Append(System.Environment.NewLine);

                sb.Append("Area Name: " + gameController.Game.IngameState.Data.CurrentArea.Name);
                sb.Append(System.Environment.NewLine);


                sb.Append("Area change: " + memory.ReadInt(offs.AreaChangeCount + memory.AddressOfProcess));
                sb.Append(System.Environment.NewLine);
                sb.Append(System.Environment.NewLine);

                sb.Append(memory.DebugStr);

                File.WriteAllText("__BaseOffsets.txt", sb.ToString());
#endif



                var overlay = new ExternalOverlay(gameController, memory.IsInvalid);
                Application.Run(overlay);
            }
        }
    }
}
