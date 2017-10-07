using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractCls
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            int r1 = obj.add(10, 20);
            Console.WriteLine(r1.ToString());
            obj.show();
            //MyClass m1 = new MyClass();
            //int r4=m1.wrap();
            //Console.WriteLine("wrap: "+r4.ToString());
            //Console.ReadLine();
            
        }

        public abstract class Cmath
        {
            public abstract int add(int x, int y);      //can only define, not write abstract method inside the abstract class.
            //public abstract int id { get; set; }            //can;t inherit abstract properties.
            public int id { get; set; }

            public void show()
            {
                Console.WriteLine("can Write non-abstract method");
            }

            public Cmath()
            {
                id = 101;
            }
        }

        public class MyClass:Cmath
        {
            public override int add(int x, int y)       //abstract mrthod from abstract class must be written(forced)
            {                                           //using override keyword.
                return x + y;                           //we can extend implementation of abstract add method fornxt derived class by adding 
            }                                           //abstract keyword to MuClass

            //public int wrap()
            //{
            //    int r=base.id;
            //    return r;
            //}
        }

    }
}
