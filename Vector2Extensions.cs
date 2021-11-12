using UnityEngine;

namespace Reccy.ScriptExtensions
{
    public static class Vector2Extensions
    {
        // Adapted from: Boz0r from Unity Forums: https://forum.unity.com/threads/whats-the-best-way-to-rotate-a-vector2-in-unity.729605/#post-4874852
        public static Vector2 RotatedRad(this Vector2 v, float rad)
        {
            return new Vector2(
                v.x * Mathf.Cos(rad) - v.y * Mathf.Sin(rad),
                v.x * Mathf.Sin(rad) + v.y * Mathf.Cos(rad)
            );
        }

        public static Vector2 RotatedDeg(this Vector2 v, float deg)
        {
            return v.RotatedRad(Mathf.Deg2Rad * deg);
        }

        public static Vector2 ClampBetween(this Vector2 v, Vector2 min, Vector2 max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y)
            );
        }
    }
}
