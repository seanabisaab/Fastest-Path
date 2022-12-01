using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Pool
    {
        public static int count = 0;
        public Location loc;
        public Temperature temp;
        public char tag;

        public Pool()
        {
            count++;
        }
        public override string ToString()
        {
            return ("location:" + loc + ", temperature:" + temp);
        }


    }
}
