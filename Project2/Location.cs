using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Location
    {
        int x;
        int y;

        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double FindDistance(Location L)
        {
            int s1 = Math.Abs(x-L.x);
            int s2 = Math.Abs(y-L.y);
            double hyp = Math.Sqrt(s1 * s1 + s2 * s2);
            return hyp;
        }
        public override string ToString()
        {
            return ("(" + x + ", " + y + ")");
        }
    }
}
