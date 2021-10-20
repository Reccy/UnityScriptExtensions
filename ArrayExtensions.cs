using UnityEngine;

namespace Reccy.ScriptExtensions
{
    public static class ArrayExtensions
    {
        public static T SelectRandom<T>(this T[] array)
        {
            var i = Random.Range(0, array.Length);
            return array[i];
        }
    }
}
