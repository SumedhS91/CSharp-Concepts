using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interfac
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            int r1 = t1.add(10,20);
            int r2 = t1.sub(30, 20);
        
            IY t2 = new test();
            int r3 = t2.add(10, 20);
            Console.WriteLine("Add: {0}, Sub: {1}, YAdd: {2} ", r1, r2, r3);
            Console.ReadLine();
        }

        interface IX
        {
            int add(int x,int y);           //methods defined in interface are public by default
            int sub(int x,int y);

          //  public int id { get; set; }       //id in interface is allowed
        }

        interface IY
        {
            int add(int x, int y);           
            int mul(int x, int y);
        }

        public class Test : IX, IY          //multiple inheritance allowed for interface
        {

            public int add(int x, int y)            //Must be implemented(Forced) all
            {
                return x + y;
            }

            public int sub(int x, int y)
            {
                return x - y;
            }


            public int mul(int x, int y)
            {
                return x * y;
            }
        }

        public class test:IX,IY
        {

            int IX.add(int x, int y)                //Must be implemented(Forced) all 
            {
                return x + y;
            }

            int IX.sub(int x, int y)
            {
                return x - y;
            }

            int IY.add(int x, int y)
            {
                return x + y+10;
            }

            int IY.mul(int x, int y)
            {
                return x * y;
            }
        }
    }

}
