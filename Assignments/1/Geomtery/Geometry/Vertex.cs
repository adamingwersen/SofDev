using System;

namespace Geometry
{
    public struct Vertex
    {
        public int x, y;
        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return(String.Format("({0},{1})", x, y));
        }
        public static bool operator ==(Vertex l, Vertex r)
        {
            return Equals(l, r);
        }
        public static bool operator !=(Vertex l, Vertex r)
        {
            return !Equals(l, r);
        }
        public override bool Equals(Object struc) 
        {
            if (struc == null || GetType() != struc.GetType()) 
                return false;
            Vertex p = (Vertex)struc;
            return (x == p.x) && (y == p.y);
        }
    }
}