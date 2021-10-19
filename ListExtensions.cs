using UnityEngine;
using System.Collections.Generic;

namespace Reccy.ScriptExtensions
{
    public static class ListExtensions
    {
        public static T SelectRandom<T>(this List<T> list)
        {
            var i = Random.Range(0, list.Count);
            return list[i];
        }
    }
}