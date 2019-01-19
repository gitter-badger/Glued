﻿using System.Collections.Generic;
using System.Linq;

namespace Glued
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> AsEnumerable<T>(this T value)
        {
            return new[] {value};
        }

        public static IEnumerable<T> Union<T>(this T value, IEnumerable<T> values)
        {
            return value.AsEnumerable().Union(values);
        }
    }
}