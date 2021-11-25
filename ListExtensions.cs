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

        public static void RemoveDuplicates<T>(this List<T> a, List<T> b)
        {
            List<int> removeIndices = new List<int>();
            int accumulator = 0;

            for (int i = 0; i < a.Count; ++i)
            {
                if (b.Contains(a[i]))
                {
                    removeIndices.Add(i - accumulator);
                    accumulator++;
                }
            }

            foreach (int i in removeIndices)
            {
                a.RemoveAt(i);
            }
        }

        public static T First<T>(this List<T> a)
        {
            return a[0];
        }

        public static T Last<T>(this List<T> a)
        {
            return a[a.Count - 1];
        }

        public static T Smallest<T>(this List<T> a)
        {
            var comparer = Comparer<T>.Default;

            T smallest = a[0];

            for (int i = 0; i < a.Count; ++i)
            {
                if (comparer.Compare(a[i], smallest) == 1)
                {
                    smallest = a[i];
                }
            }

            return smallest;
        }

        public static T Largest<T>(this List<T> a)
        {
            var comparer = Comparer<T>.Default;

            T largest = a[0];

            for (int i = 0; i < a.Count; ++i)
            {
                if (comparer.Compare(a[i], largest) == -1)
                {
                    largest = a[i];
                }
            }

            return largest;
        }

        public static T Take<T>(this List<T> a)
        {
            int idx = a.Count - 1;

            T result = a[idx];
            a.RemoveAt(idx);

            return result;
        }

        public static bool IsEmpty<T>(this List<T> a)
        {
            return a.Count == 0;
        }

        public static T ClosestToZero<T>(this List<T> a, System.Func<T, float> f1)
        {
            float bestMatch = float.MaxValue;
            T result = default(T);

            foreach (var v in a)
            {
                float diff = f1.Invoke(v);

                if (diff < bestMatch)
                {
                    result = v;
                    bestMatch = diff;
                }
            }

            if (a.IsEmpty())
                Debug.LogWarning($"Returning default value of {result}, input list empty");

            return result;
        }
    }
}
