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

        public static float ListLength(List<Vector3Int> list)
        {
            float distance = 0;

            for (int i = 1; i < list.Count; ++i)
            {
                distance += Vector3Int.Distance(list[i - 1], list[i]);
            }

            return distance;
        }
    }
}
