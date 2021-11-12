using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Reccy.ScriptExtensions
{
    public static class Vector3Extensions
    {
        public static Vector3 ClampBetween(this Vector3 v, Vector3 min, Vector3 max)
        {
            return new Vector3(
                Mathf.Clamp(v.x, min.x, max.x),
                Mathf.Clamp(v.y, min.y, max.y),
                Mathf.Clamp(v.z, min.z, max.z)
            );
        }
    }
}
