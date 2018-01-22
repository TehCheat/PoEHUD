﻿using ImGuiNET;
using PoeHUD.Hud.UI.Vertexes;
using SharpDX;
using SharpDX.Direct3D9;
using SharpDX.Mathematics.Interop;
using SharpDX.Windows;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PoeHUD.Controllers;
using Blend = SharpDX.Direct3D9.Blend;
using ImVector2 = System.Numerics.Vector2;

namespace PoeHUD.Hud.UI.Renderers
{
    class ImGuiRender
    {
        private readonly Device device;

        public ImGuiRender(Device dev, RenderForm form)
        {
            device = dev;
            IO io = ImGui.GetIO();
            io.FontAtlas.AddDefaultFont();
            UpdateCanvasSize(form.ClientSize.Width, form.ClientSize.Height);
            PrepareTextureImGui();
        }
        private static unsafe void memcpy(void* dst, void* src, int count)
        {
            const int blockSize = 4096;
            byte[] block = new byte[blockSize];
            byte* d = (byte*)dst, s = (byte*)src;
            for (int i = 0, step; i < count; i += step, d += step, s += step)
            {
                step = count - i;
                if (step > blockSize)
                {
                    step = blockSize;
                }
                Marshal.Copy(new IntPtr(s), block, 0, step);
                Marshal.Copy(block, 0, new IntPtr(d), step);
            }
        }
        private unsafe void PrepareTextureImGui()
        {
            var io = ImGui.GetIO();
            var texDataAsRgba32 = io.FontAtlas.GetTexDataAsRGBA32();
            var t = new Texture(device, texDataAsRgba32.Width, texDataAsRgba32.Height, 1, Usage.Dynamic,
                    Format.A8R8G8B8, Pool.Default);
            var rect = t.LockRectangle(0, LockFlags.None);
            for (int y = 0; y < texDataAsRgba32.Height; y++)
            {
                memcpy((byte*)(rect.DataPointer + rect.Pitch * y), texDataAsRgba32.Pixels + (texDataAsRgba32.Width * texDataAsRgba32.BytesPerPixel) * y, (texDataAsRgba32.Width * texDataAsRgba32.BytesPerPixel));
            }
            t.UnlockRectangle(0);
            io.FontAtlas.SetTexID(t.NativePointer);
            io.FontAtlas.ClearTexData();
        }

        public static void UpdateImGuiInput()
        {
            var io = ImGui.GetIO();
            var point = Control.MousePosition;
            var windowPoint = GameController.Instance.Window.ScreenToClient(point.X, point.Y);
            io.MousePosition = new ImVector2(windowPoint.X, windowPoint.Y);
            UpdateModifiers();

            //Mouse button for work with HUD.
            io.MouseDown[0] = Control.MouseButtons == MouseButtons.Middle;
            io.MouseDown[1] = Control.MouseButtons == MouseButtons.Right;
            // io.MouseDown[2] = Form.MouseButtons == MouseButtons.Middle;
        }

        private static void UpdateModifiers()
        {
            var io = ImGui.GetIO();
            io.AltPressed = Control.ModifierKeys == Keys.Alt;
            io.CtrlPressed = Control.ModifierKeys == Keys.Control;
            io.ShiftPressed = Control.ModifierKeys == Keys.Shift;
        }

        public void UpdateCanvasSize(float width, float height)
        {
            IO io = ImGui.GetIO();
            io.DisplaySize = new System.Numerics.Vector2(width, height);
            io.DisplayFramebufferScale = new System.Numerics.Vector2(width / height);
        }
        public void SampleUI()
        {
            ImGui.SetNextWindowSize(new System.Numerics.Vector2(500, 500), Condition.Appearing);
            ImGui.SetNextWindowPos(new System.Numerics.Vector2(960 + 250, 540 + 250), Condition.Appearing, new System.Numerics.Vector2(1, 1));
            ImGui.BeginWindow("Sample UI", WindowFlags.Default);
            ImGui.EndWindow();
        }
        public void GetNewFrame()
        {
            ImGui.NewFrame();
        }

        public unsafe void Draw()
        {
            SampleUI();
            ImGui.Render();
            DrawData* data = ImGui.GetDrawData();
            ImGuiRenderDraw(data);
        }
        private unsafe void ImGuiRenderDraw(DrawData* drawData)
        {
            if (drawData == null)
                return;
            var io = ImGui.GetIO();
            if (io.DisplaySize.X <= 0.0f || io.DisplaySize.Y <= 0.0f)
                return;
            var st = new StateBlock(device, StateBlockType.All);
            var vp = new Viewport();
            vp.X = vp.Y = 0;
            vp.Width = (int)io.DisplaySize.X;
            vp.Height = (int)io.DisplaySize.Y;
            vp.MinDepth = 0.0f;
            vp.MaxDepth = 1.0f;
            device.Viewport = vp;
            device.PixelShader = null;
            device.VertexShader = null;
            device.SetRenderState(RenderState.CullMode, Cull.None);
            device.SetRenderState(RenderState.Lighting, false);
            device.SetRenderState(RenderState.ZEnable, false);
            device.SetRenderState(RenderState.AlphaBlendEnable, true);
            device.SetRenderState(RenderState.AlphaTestEnable, false);
            device.SetRenderState(RenderState.BlendOperation, BlendOperation.Add);
            device.SetRenderState(RenderState.SourceBlend, Blend.SourceAlpha);
            device.SetRenderState(RenderState.DestinationBlend, Blend.BothInverseSourceAlpha);
            device.SetRenderState(RenderState.ScissorTestEnable, true);
            device.SetTextureStageState(0, TextureStage.ColorOperation, TextureOperation.Modulate);
            device.SetTextureStageState(0, TextureStage.ColorArg1, TextureArgument.Texture);
            device.SetTextureStageState(0, TextureStage.ColorArg2, TextureArgument.Diffuse);
            device.SetTextureStageState(0, TextureStage.AlphaOperation, TextureOperation.Modulate);
            device.SetTextureStageState(0, TextureStage.AlphaArg1, TextureArgument.Texture);
            device.SetTextureStageState(0, TextureStage.AlphaArg2, TextureArgument.Diffuse);
            device.SetSamplerState(0, SamplerState.MinFilter, TextureFilter.Linear);
            device.SetSamplerState(0, SamplerState.MagFilter, TextureFilter.Linear);
            // Setup orthographic projection matrix
            {
                const float L = 0.5f;
                float R = io.DisplaySize.X + 0.5f;
                const float T = 0.5f;
                float B = io.DisplaySize.Y + 0.5f;
                RawMatrix mat_identity = new Matrix(1.0f, 0.0f, 0.0f, 0.0f,
                    0.0f, 1.0f, 0.0f, 0.0f,
                    0.0f, 0.0f, 1.0f, 0.0f,
                    0.0f, 0.0f, 0.0f, 1.0f);
                RawMatrix mat_projection = new Matrix(
                    2.0f / (R - L), 0.0f, 0.0f, 0.0f,
                    0.0f, 2.0f / (T - B), 0.0f, 0.0f,
                    0.0f, 0.0f, 0.5f, 0.0f,
                    (L + R) / (L - R), (T + B) / (B - T), 0.5f, 1.0f);
                device.SetTransform(TransformState.World, ref mat_identity);
                device.SetTransform(TransformState.View, ref mat_identity);
                device.SetTransform(TransformState.Projection, ref mat_projection);
            }
            using (device.VertexDeclaration = new VertexDeclaration(device, GuiVertex.VertexElements))
            {
                for (var n = 0; n < drawData->CmdListsCount; n++)
                {
                    NativeDrawList* cmdList = drawData->CmdLists[n];
                    DrawVert* vtx_buffer = (DrawVert*)cmdList->VtxBuffer.Data;
                    ushort* idx_buffer = (ushort*)cmdList->IdxBuffer.Data;

                    var myCustomVertices = new GuiVertex[cmdList->VtxBuffer.Size];
                    for (var i = 0; i < myCustomVertices.Length; i++)
                    {
                        var cl = (vtx_buffer[i].col & 0xFF00FF00) | ((vtx_buffer[i].col & 0xFF0000) >> 16) | ((vtx_buffer[i].col & 0xFF) << 16);
                        myCustomVertices[i] =
                            new GuiVertex(vtx_buffer[i].pos.X, vtx_buffer[i].pos.Y, vtx_buffer[i].uv.X, vtx_buffer[i].uv.Y, cl);
                    }

                    for (var i = 0; i < cmdList->CmdBuffer.Size; i++)
                    {
                        DrawCmd* pcmd = &((DrawCmd*)cmdList->CmdBuffer.Data)[i];
                        if (pcmd->UserCallback != IntPtr.Zero)
                        {
                            throw new NotImplementedException();
                        }
                        else
                        {
                            device.SetTexture(0, new Texture(pcmd->TextureId));
                            device.ScissorRect = new RectangleF((int)pcmd->ClipRect.X,
                                (int)pcmd->ClipRect.Y,
                                (int)(pcmd->ClipRect.Z - pcmd->ClipRect.X),
                                (int)(pcmd->ClipRect.W - pcmd->ClipRect.Y));
                            ushort[] indices = new ushort[pcmd->ElemCount];
                            for (int j = 0; j < indices.Length; j++)
                            {
                                indices[j] = idx_buffer[j];
                            }

                            device.DrawIndexedUserPrimitives(PrimitiveType.TriangleList, 0, myCustomVertices.Length, (int)(pcmd->ElemCount / 3), indices, Format.Index16, myCustomVertices);
                        }
                        idx_buffer += pcmd->ElemCount;
                    }
                }
            }
            st.Apply();
            st.Dispose();
        }
    }
}
