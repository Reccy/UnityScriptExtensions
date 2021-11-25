using System.Collections.Generic;

namespace Reccy.ScriptExtensions
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Returns the key with the smallest value in the dictionary.
        /// </summary>
        public static T GetSmallest<T>(this Dictionary<T, float> dict)
        {
            T smallestKey = default(T);
            float smallestValue = float.MaxValue;

            foreach (KeyValuePair<T, float> kvp in dict)
            {
                T k = kvp.Key;
                float v = kvp.Value;

                if (v < smallestValue)
                {
                    smallestKey = k;
                    smallestValue = v;
                }
            }

            return smallestKey;
        }

        public static float MinValue<T>(this Dictionary<T, float> dict)
        {
            float smallestValue = float.MaxValue;

            foreach(var kvp in dict)
            {
                T k = kvp.Key;
                var v = kvp.Value;

                if (v < smallestValue)
                {
                    smallestValue = v;
                }
            }

            return smallestValue;
        }

        public static float MaxValue<T>(this Dictionary<T, float> dict)
        {
            float largestValue = float.MinValue;

            foreach(var kvp in dict)
            {
                T k = kvp.Key;
                var v = kvp.Value;

                if (v > largestValue)
                {
                    largestValue = v;
                }
            }

            return largestValue;
        }

        public static int MinValue<T>(this Dictionary<T, int> dict)
        {
            var smallestValue = int.MaxValue;

            foreach (var kvp in dict)
            {
                T k = kvp.Key;
                var v = kvp.Value;

                if (v < smallestValue)
                {
                    smallestValue = v;
                }
            }

            return smallestValue;
        }

        public static int MaxValue<T>(this Dictionary<T, int> dict)
        {
            var largestValue = int.MinValue;

            foreach (var kvp in dict)
            {
                T k = kvp.Key;
                var v = kvp.Value;

                if (v > largestValue)
                {
                    largestValue = v;
                }
            }

            return largestValue;
        }
    }
}
