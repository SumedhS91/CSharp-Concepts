using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticCls
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestStat t = new TestStat();        //not allowed obj of static class.
            TestStat.show();

            NewC obj = new NewC();
            NewC obj1 = new NewC();
            NewC obj2 = new NewC();

            Console.WriteLine("cnt: {0}",NewC.cnt);
            Console.ReadLine();
        }
    }

        public static class TestStat
        {
            public static int i = 50;
            public static void show()
            {
                Console.WriteLine("\n Static Method!");
            }
        }

        public class NewC
        {
            public static int cnt = 0;          //non-static class can contain static members.
            public NewC()
            {
                cnt++;
                Console.WriteLine("Default ctor called");
            }
            static NewC()
            {
                Console.WriteLine("Static ctor Called");
            }
        }
}
