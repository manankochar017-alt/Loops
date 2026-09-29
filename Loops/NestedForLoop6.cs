using System;
using System.Collections.Generic;
using System.Text;

namespace Loops
{
    internal class NestedForLoop6
    {
        static void Main()
        {
            int i, j;
            for (i = 5; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    Console.Write($"{j}");
                }
                Console.WriteLine("");
            }
        }
    }
}
