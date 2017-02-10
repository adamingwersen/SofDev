using System;

namespace Geometry
{
    public struct Vertex
    {
        public int x;
        public int y;

        public override string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + ")";
        }
    }
}


