using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI.Renderers;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Windows;
using System;
using System.Threading;
using System.Windows.Forms;

namespace PoeHUD.Hud.UI
{
    public sealed class Graphics : IDisposable
    {
        private const CreateFlags CREATE_FLAGS = CreateFlags.Multithreaded | CreateFlags.HardwareVertexProcessing;
        private readonly DeviceEx device;
        private readonly Direct3DEx direct3D;
        private readonly FontRenderer fontRenderer;
        private readonly TextureRenderer textureRenderer;
        private readonly Action reset;
        private PresentParameters presentParameters;
        private bool resized;
        private bool running = true;
        private readonly ManualResetEventSlim renderLocker = new ManualResetEventSlim(false);

        public Graphics(RenderForm form, int width, int height)
        {
            reset = () => form.Invoke(new Action(() =>
            {
                device.Reset(presentParameters);
                fontRenderer.Flush();
                textureRenderer.Flush();
                resized = false;
            }));
            form.UserResized += (sender, args) => Resize(form.ClientSize.Width, form.ClientSize.Height);
            presentParameters = new PresentParameters
            {
                Windowed = true,
                SwapEffect = SwapEffect.Discard,
                BackBufferFormat = Format.A8R8G8B8,
                BackBufferCount = 1,
                BackBufferWidth = width,
                BackBufferHeight = height,
                PresentationInterval = PresentInterval.One,
                MultiSampleType = MultisampleType.None,
                MultiSampleQuality = 0,
                PresentFlags = PresentFlags.LockableBackBuffer
            };
            direct3D = new Direct3DEx();
            device = new DeviceEx(direct3D, 0, DeviceType.Hardware, form.Handle, CREATE_FLAGS, presentParameters);
            fontRenderer = new FontRenderer(device);
            textureRenderer = new TextureRenderer(device);
            renderLocker.Reset();
        }

        public event Action Render;
        public void Clear()
        {
            device.Clear(ClearFlags.Target, Color.Transparent, 0, 0);
            device.Present();
        }

        public void TryRender()
        {
            try
            {
                if (resized)
                { 
                    reset();
                }
                device.Clear(ClearFlags.Target, Color.Transparent, 0, 0);
                device.SetRenderState(RenderState.AlphaBlendEnable, true);
                device.SetRenderState(RenderState.CullMode, Cull.Clockwise);
                device.BeginScene();
                fontRenderer.Begin();
                textureRenderer.Begin();
                try
                {
                    Render.SafeInvoke();
                }
                finally
                {
                    textureRenderer.End();
                    fontRenderer.End();
                    device.EndScene();
                    device.Present();
                }
                renderLocker.Set();
            }
            catch (SharpDXException)
            {
            }
        }

        public void Dispose()
        {
            if (!device.IsDisposed)
            {
                running = false;
                renderLocker.Wait();
                renderLocker.Dispose();
                device.Dispose();
                direct3D.Dispose();
                fontRenderer.Dispose();
                textureRenderer.Dispose();
            }
        }

        private void Resize(int width, int height)
        {
            if (width > 0 && height > 0)
            {
                presentParameters.BackBufferWidth = width;
                presentParameters.BackBufferHeight = height;
                resized = true;
            }
        }

        public Size2 DrawText(string text, int height, Vector2 position, Color color, FontDrawFlags align = FontDrawFlags.Left)
        {
            return fontRenderer.DrawText(text, "Verdana", height, position, color, align);
        }

        public Size2 DrawText(string text, int height, Vector2 position, FontDrawFlags align = FontDrawFlags.Left)
        {
            return fontRenderer.DrawText(text, "Verdana", height, position, Color.White, align);
        }

        public Size2 MeasureText(string text, int height, FontDrawFlags align = FontDrawFlags.Left)
        {
            return fontRenderer.MeasureText(text, "Verdana", height, align);
        }

        public void DrawLine(Vector2 p1, Vector2 p2, float borderWidth, Color color)
        {
            textureRenderer.DrawLine(p1, p2, borderWidth, color);
        }

        public void DrawBox(RectangleF rectangle, Color color)
        {
            textureRenderer.DrawBox(rectangle, color);
        }

        public void DrawFrame(RectangleF rectangle, float borderWidth, Color color)
        {
            textureRenderer.DrawFrame(rectangle, borderWidth, color);
        }

        public void DrawImage(string fileName, RectangleF rectangle, float repeatX = 1f)
        {
            DrawImage(fileName, rectangle, Color.White, repeatX);
        }

        public void DrawPluginImage(string fileName, RectangleF rectangle, float repeatX = 1f)
        {
            try
            {
                textureRenderer.DrawImage(fileName, rectangle, Color.White, repeatX);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load texture {fileName}: {e.Message}");
                Environment.Exit(0);
            }
        }

        public void DrawPluginImage(string fileName, RectangleF rectangle, Color color, float repeatX = 1f)
        {
            try
            {
                textureRenderer.DrawImage(fileName, rectangle, color, repeatX);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load texture {fileName}: {e.Message}");
                Environment.Exit(0);
            }
        }

        public void DrawImage(string fileName, RectangleF rectangle, RectangleF uvCoords)
        {
            DrawImage(fileName, rectangle, uvCoords, Color.White);
        }

        public void DrawImage(string fileName, RectangleF rectangle, RectangleF uvCoords, Color color)
        {
            try
            {
                textureRenderer.DrawImage("textures/" + fileName, rectangle, uvCoords, color);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load texture {fileName}: {e.Message}");
                Environment.Exit(0);
            }
        }

        public void DrawImage(string fileName, Vertexes.TexturedVertex[] data, Color color, float repeatX = 1f)
        {
            try
            {
                textureRenderer.DrawImage("textures/" + fileName, data, color, repeatX);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load texture {fileName}: {e.Message}");
                Environment.Exit(0);
            }
        }

        public void DrawImage(string fileName, RectangleF rectangle, Color color, float repeatX = 1f)
        {
            try
            {
                textureRenderer.DrawImage("textures/" + fileName, rectangle, color, repeatX);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Failed to load texture {fileName}: {e.Message}");
                Environment.Exit(0);
            }
        }
    }
}