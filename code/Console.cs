using System.Collections.Generic;
using MoreLinq;

namespace TryMoreLinq
{
    static class Console
    {
        public static void WriteLine() =>
            System.Console.WriteLine();

        public static void WriteLine(string str) =>
            System.Console.WriteLine(str);

        public static void WriteLine(object obj) =>
            System.Console.WriteLine(obj);

        public static void WriteLine<T>(IEnumerable<T> source)
        {
            const int limit = 250;
            var i = 0;
            foreach (var item in source)
            {
                if (i + 1 > limit)
                {
                    WriteLine($"(output truncated; showing only first {limit} items)");
                    break;
                }

                WriteLine($"[{i}] = {item}");
                i++;
            }
        }
    }
}
