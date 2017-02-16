using System;
using Library;

namespace TUI
{
    class MainClass
    {
        private static void PrintArray(object[] array)
        {
            Console.WriteLine ("Test Array: {0}", Show.Array (array));
        }

        private static void TestArray(IComparable[] array)
        {
            PrintArray (array);

            for (int i = 0; i <= 11; i++)
            {
                int result = Search.Binary (array, i);
                if (result == -1)
                {
                    Console.WriteLine ("{0} was not found.", i);
                }
                else
                {
                    Console.WriteLine ("{0} was found in index {1}.", i, result);
                }
            }
            // Console.WriteLine (Search.Linear (array, 11));
            // Console.WriteLine (Search.Binary (new IComparable [] { 3, 4, 5, 6, 7, 8, 9 }, 5));
            Generator testGen = new Generator ();
            int searchVal = testGen.NextInt (25);
            Console.WriteLine ();
            Console.WriteLine (searchVal);
            Console.WriteLine(Search.Linear (testGen.NextArray (50, 25), searchVal));
            Console.WriteLine(Search.Binary (testGen.NextArray (50, 25), searchVal));
            Console.WriteLine ();
        }

        public static void Main (string[] args)
        {
            Generator gen = new Generator ();

            TestArray (gen.NextArray(1000, 1000));
            TestArray (gen.NextArray(10, 10));
            TestArray (gen.NextArray(10, 10));
        }
    }
}