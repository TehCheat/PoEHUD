using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI.Vertexes;
using SharpDX;
using SharpDX.Direct3D9;
using System;
using System.Collections.Generic;


namespace PoeHUD.Hud.UI.Renderers
{
    public sealed class TextureRenderer : IDisposable
    {
        private readonly Device device;
        private readonly Sprite sprite;
        private readonly Dictionary<string, Texture> textures;

        public TextureRenderer(Device device)
        {
            this.device = device;
            sprite = new Sprite(device);
            textures = new Dictionary<string, Texture>();

        }

        public void Begin()
        {
            sprite.Begin();
        }

        public void DrawLine(Vector2 p1, Vector2 p2, float width, Color color)
        {

            Vector2 dir = RotateVect(NormalizeVector(p2 - p1) * width, 90);

            Vector2
                pTopLt = p1 + (width <= 1f
                             ? Vector2.Zero
                             : dir); //if width <= 1 we don't need to shift offset on both sides
            Vector2 pTopRt = p1 - dir;
            Vector2 pBotLt = p2 + (width <= 1f ? Vector2.Zero : dir);
            Vector2 pBotRt = p2 - dir;

            ColoredVertex[] data =
            {
                new ColoredVertex(pTopLt.X, pTopLt.Y, color),
                new ColoredVertex(pTopRt.X, pTopRt.Y, color),
                new ColoredVertex(pBotRt.X, pBotRt.Y, color),
                new ColoredVertex(pBotLt.X, pBotLt.Y, color)
            };
            device.SetTexture(0, null);
            DrawColoredVertices(PrimitiveType.TriangleFan, 2, data);

        }

        private Vector2 RotateVect(Vector2 v, float angle)
        {
            var theta = ConvertToRadians(angle);

            var cs = Math.Cos(theta);
            var sn = Math.Sin(theta);
            var px = v.X * cs - v.Y * sn;
            var py = v.X * sn + v.Y * cs;
            return new Vector2((float)px, (float)py);
        }

        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public Vector2 NormalizeVector(Vector2 vec)
        {
            var length = VectorLength(vec);
            vec.X /= length;
            vec.Y /= length;
            return vec;
        }

        public float VectorLength(Vector2 vec)
        {
            return (float)Math.Sqrt((vec.X * vec.X) + (vec.Y * vec.Y));
        }

        public void DrawBox(RectangleF rect, Color color)
        {
            ColoredVertex[] data =
            {
                new ColoredVertex(rect.Left, rect.Top, color),
                new ColoredVertex(rect.Right, rect.Top, color),
                new ColoredVertex(rect.Right, rect.Bottom, color),
                new ColoredVertex(rect.Left, rect.Bottom, color)
            };
            device.SetTexture(0, null);
            DrawColoredVertices(PrimitiveType.TriangleFan, 2, data);
        }

        public void DrawFrame(RectangleF rect, float borderWidth, Color color)
        {
            float half = borderWidth / 2f;

            // Outer rectangle
            var p1 = new ColoredVertex(rect.Left - half, rect.Top - half, color);
            var p2 = new ColoredVertex(rect.Right + half, rect.Top - half, color);
            var p3 = new ColoredVertex(rect.Right + half, rect.Bottom + half, color);
            var p4 = new ColoredVertex(rect.Left - half, rect.Bottom + half, color);

            // Inner rectangle
            var p5 = new ColoredVertex(rect.Left + half, rect.Top + half, color);
            var p6 = new ColoredVertex(rect.Right - half, rect.Top + half, color);
            var p7 = new ColoredVertex(rect.Right - half, rect.Bottom - half, color);
            var p8 = new ColoredVertex(rect.Left + half, rect.Bottom - half, color);

            ColoredVertex[] data = { p1, p5, p2, p6, p3, p7, p4, p8, p1, p5 };
            device.SetTexture(0, null);
            DrawColoredVertices(PrimitiveType.TriangleStrip, 8, data);
        }

        public void DrawImage(string fileName, TexturedVertex[] data)
        {
            device.SetTexture(0, GetTexture(fileName));
            device.SetSamplerState(0, SamplerState.AddressU, TextureAddress.Wrap);
            DrawTexturedVertices(PrimitiveType.TriangleFan, 2, data);
        }

        public void DrawImage(string fileName, RectangleF rect, Color color, float repeatX)
        {

            TexturedVertex[] data =
            {
                new TexturedVertex(rect.Left, rect.Top, 0, 0, color),
                new TexturedVertex(rect.Right, rect.Top, repeatX, 0, color),
                new TexturedVertex(rect.Right, rect.Bottom, repeatX, 1, color),
                new TexturedVertex(rect.Left, rect.Bottom, 0, 1, color)
            };
            device.SetTexture(0, GetTexture(fileName));
            device.SetSamplerState(0, SamplerState.AddressU, TextureAddress.Wrap);
            DrawTexturedVertices(PrimitiveType.TriangleFan, 2, data);
        }

        public void DrawImage(byte[] by, RectangleF rect, Color color, string name)
        {

            TexturedVertex[] data =
            {
                new TexturedVertex(rect.Left, rect.Top, 0, 0, color),
                new TexturedVertex(rect.Right, rect.Top, 1, 0, color),
                new TexturedVertex(rect.Right, rect.Bottom, 1, 1, color),
                new TexturedVertex(rect.Left, rect.Bottom, 0, 1, color)
            };
            if (!textures.TryGetValue(name, out var baseTexture))
            {
                baseTexture = Texture.FromMemory(device, @by);
                textures.Add(name, baseTexture);

            }
            device.SetSamplerState(2, SamplerState.AddressU, TextureAddress.Wrap);
            device.SetTexture(0, baseTexture);

            DrawTexturedVertices(PrimitiveType.TriangleFan, 2, data);

        }

        public void DrawImage(string fileName, RectangleF rect, RectangleF uvCoords, Color color)
        {

            TexturedVertex[] data =
            {
                new TexturedVertex(rect.Left, rect.Top, uvCoords.Left, uvCoords.Top, color),
                new TexturedVertex(rect.Right, rect.Top, uvCoords.Right, uvCoords.Top, color),
                new TexturedVertex(rect.Right, rect.Bottom, uvCoords.Right, uvCoords.Bottom, color),
                new TexturedVertex(rect.Left, rect.Bottom, uvCoords.Left, uvCoords.Bottom, color)
            };

            device.SetTexture(0, GetTexture(fileName));
            DrawTexturedVertices(PrimitiveType.TriangleFan, 2, data);
        }

        public void End()
        {
            sprite.End();
        }

        public void Flush()
        {
            textures.ForEach((key, texture) => texture.Dispose());
            textures.Clear();
        }

        public void Dispose()
        {
            sprite.Dispose();
            Flush();
        }

        private void DrawColoredVertices(PrimitiveType type, int count, ColoredVertex[] data)
        {
            using (var declaration = new VertexDeclaration(device, ColoredVertex.VertexElements))
            {
                device.VertexDeclaration = declaration;
                device.DrawUserPrimitives(type, count, data);
            }
        }

        private void DrawTexturedVertices(PrimitiveType type, int count, TexturedVertex[] data)
        {
            using (var declaration = new VertexDeclaration(device, TexturedVertex.VertexElements))
            {
                device.VertexDeclaration = declaration;
                device.DrawUserPrimitives(type, count, data);

            }
        }

        private Texture GetTexture(string fileName)
        {
            Texture texture;
            if (!textures.TryGetValue(fileName, out texture))
            {
                texture = Texture.FromFile(device, fileName);

                textures.Add(fileName, texture);
            }
            return texture;
        }
    }
}