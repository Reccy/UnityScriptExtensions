using UnityEngine;
using System.Collections.Generic;

namespace Reccy.ScriptExtensions
{
    public static class StackExtensions
    {
        public static List<T> ToList<T>(this Stack<T> stack)
        {
            return new List<T>(stack.ToArray());
        }
    }
}
