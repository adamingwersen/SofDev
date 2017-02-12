using System;
using Geometry;

namespace TUI
{
    class MainClass
    {
        public static void Main ()
        {
            Vertex a = new Vertex(1, 1);
            Vertex b = new Vertex(2, 1);

            Console.WriteLine ("Instantiating a: {0}", a);
            Console.WriteLine ("Instantiating b: {0}", b);

            Console.WriteLine ("\nComparing using the overridden != and == operators:\n");

            Console.WriteLine ("a == b : {0}", a == b);
            Console.WriteLine ("a == a : {0}", a == a);
            Console.WriteLine ("a != a : {0}",a != a);
            Console.WriteLine ("a != b : {0}",a != b);

            Console.WriteLine ("\nComparing using the overridden Equals() operator:\n");

            Console.WriteLine ("a.Equals(b): {0}", a.Equals (b));
            Console.WriteLine ("a.Equals(a): {0}", a.Equals (a));

        }
    }
}