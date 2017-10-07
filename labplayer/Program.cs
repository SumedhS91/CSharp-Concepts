using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using player;

namespace labplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player();
            int r=pl.ren();
            Console.WriteLine("Renumeration: "+r);
            Console.ReadLine();
        }
    }
}
