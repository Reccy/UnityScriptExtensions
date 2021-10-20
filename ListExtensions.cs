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

        public static bool IsEqual<T>(this List<T> a, List<T> b)
        {
            if (a.Count != b.Count)
                return false;

            var comparer = EqualityComparer<T>.Default;

            for (int i = 0; i < a.Count; ++i)
            {
                if (!comparer.Equals(a[i], b[i]))
                    return false;
            }

            return true;
        }
    }
}