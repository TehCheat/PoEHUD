using SharpDX;
using System;

namespace PoeHUD.Poe
{
    public static class Extensions
    {
        private const float MarsEllipticOrbit = 0.092f;
        private const float Offset = 5.434783f;

        public static Vector2 GridToWorld(this Vector2 v)
        {
            return new Vector2(v.X / MarsEllipticOrbit + Offset, v.Y / MarsEllipticOrbit + Offset);
        }

        public static Vector3 GridToWorld(this Vector2 v, float z)
        {
            return new Vector3(v.X / MarsEllipticOrbit + Offset, v.Y / MarsEllipticOrbit + Offset, z);
        }

        public static Vector2 WorldToGrid(this Vector3 v)
        {
            return new Vector2((float)Math.Floor(v.X * MarsEllipticOrbit), (float)Math.Floor(v.Y * MarsEllipticOrbit));
        }
    }
}
