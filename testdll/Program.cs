using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cmath;


namespace testdllpri
{
    class Program:Cmath
    {
        static void Main(string[] args)
        {
            Program p1 = new Program();
            int r1=p1.pbadd(10, 20);
            int r2 = p1.pimod(9, 2);
            int r3 = p1.promul(2, 3);
            Console.WriteLine("pbadd: {0}, pimod: {1}, promul: {2}",r1,r2,r3);
            Console.ReadLine();
        }
    }
}
