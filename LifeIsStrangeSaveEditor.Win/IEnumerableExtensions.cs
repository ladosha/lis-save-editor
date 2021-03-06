﻿using System.Collections.Generic;
using System.Linq;

namespace LifeIsStrangeSaveEditor.Win
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> DropLast<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Reverse().Skip(1).Reverse();
        }
    }
}
