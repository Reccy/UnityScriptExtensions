using UnityEngine;
using System.Collections.Generic;

namespace Reccy.ScriptExtensions
{
    public static class Vector3Int2
    {
        public static int ManhattanDistance(Vector3Int from, Vector3Int to)
        {
            return Mathf.Abs(from.x - to.x) + Mathf.Abs(from.y - to.y);
        }
    }
}
