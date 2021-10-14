using UnityEngine;

namespace Reccy.ScriptExtensions
{
    public static class Mathf2
    {
        public static bool Approximately(float a, float b, float t)
        {
            return (Mathf.Abs(a - b) < t);
        }
    }
}
