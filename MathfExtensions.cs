using UnityEngine;

namespace Reccy.ScriptExtensions
{
    public static class Mathf2
    {
        public static bool Approximately(float a, float b, float t)
        {
            return (Mathf.Abs(a - b) < t);
        }

        public static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }
    }
}
