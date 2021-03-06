﻿using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class Extensions
    {
        internal static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (T element in source)
                action(element);
        }
    }
}