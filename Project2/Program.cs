using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ArrayList plist = new ArrayList();

            Console.WriteLine("Number of Pools: " + Pool.count);
            Pool p = new Pool();
            p.loc = new Location(1, 3);
            p.temp = new Temperature();
            p.tag = 'B';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(4, 2);
            p.temp = new Temperature();
            p.tag = 'C';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(6, 6);
            p.temp = new Temperature();
            p.tag = 'G';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(4, 8);
            p.temp = new Temperature();
            p.tag = 'A';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(10, 5);
            p.tag = 'F';
            p.temp = new Temperature();
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(12, 9);
            p.temp = new Temperature();
            p.tag = 'E';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Console.WriteLine("Number of Pools: " + Pool.count);
            p = new Pool();
            p.loc = new Location(13, 1);
            p.temp = new Temperature();
            p.tag = 'D';
            p.temp.deg = random.Next(98, 105);
            plist.Add(p);
            Console.WriteLine("Number of Pools: " + Pool.count);

            Location start = new Location(0, 0);

            Console.Write("Fastest Path is : ");
            Console.Write("(0, 0) >> ");
            while (plist.Count > 0)
            {
                Pool currPool = null;
                double dist = double.MaxValue;
                foreach (Pool pool in plist)
                {
                    if (pool.loc.FindDistance(start) < dist)
                    {
                        currPool = pool;
                        break;
                    }

                }
                Console.Write(currPool.tag + " with temperature at " + currPool.temp.ToString() + " >> ");
                start = currPool.loc;
                plist.Remove(currPool);
            }
            
        }
    }
}

