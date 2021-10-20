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
    }
}
