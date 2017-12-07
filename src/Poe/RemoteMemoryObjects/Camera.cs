using PoeHUD.Models;
using PoeHUD.Poe.Components;
using System;
using System.Numerics;
using PoeHUD.Controllers;
using Vector2 = SharpDX.Vector2;
using Vector3 = SharpDX.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Camera : RemoteMemoryObject
    {
        public int Width => M.ReadInt(Address + 0x4);
        public int Height => M.ReadInt(Address + 0x8);
        public float ZFar => M.ReadFloat(Address + 0x204);
        public Vector3 Position => new Vector3(M.ReadFloat(Address + 0x15C), M.ReadFloat(Address + 0x160), M.ReadFloat(Address + 0x164));

        //cameraarray 0x17c

        private static Vector2 oldplayerCord;


        public unsafe Vector2 WorldToScreen(Vector3 vec3, EntityWrapper entityWrapper)
        {
            Entity localPlayer = Game.IngameState.Data.LocalPlayer;
            var isplayer = localPlayer.Address == entityWrapper.Address && localPlayer.IsValid;
            bool isMoving = false;
            isMoving = GameController.Instance.Cache.Enable ? GameController.Instance.Cache.Player.Actor.isMoving : localPlayer.GetComponent<Actor>().isMoving;
            var playerMoving = isplayer && isMoving;
            float x, y;
            long addr = Address + 0xE4;
            fixed (byte* numRef = M.ReadBytes(addr, 0x40))
            {
                Matrix4x4 matrix = *(Matrix4x4*)numRef;
                Vector4 cord = *(Vector4*)&vec3;
                cord.W = 1;
                cord = Vector4.Transform(cord, matrix);
                cord = Vector4.Divide(cord, cord.W);
                x = (cord.X + 1.0f) * 0.5f * Width;
                y = (1.0f - cord.Y) * 0.5f * Height;
            }
            var resultCord = new Vector2(x, y);
            if (playerMoving)
            {
                if (Math.Abs(oldplayerCord.X - resultCord.X) < 40 || (Math.Abs(oldplayerCord.X - resultCord.Y) < 40))
                    resultCord = oldplayerCord;
                else
                    oldplayerCord = resultCord;
            }
            else if (isplayer)
            {
                oldplayerCord = resultCord;
            }
            return resultCord;
        }
    }
}