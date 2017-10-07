using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sealedVirtualOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            Console.WriteLine("Name: "+p1.Name+"\tAddress: "+p1.Address);
          

            SciCalc s1 = new SciCalc();
            int r1 = s1.Add(2, 3);

          //  SciCalc s2 = new Calc();        //Can't create object of base class using derived class
           // Calc c1 = new SciCalc();         //possible 

            SciCalc s3 = new SciCalc();
            int r4 = s3.WrapperAdd(2,3);
            int r5 = s3.Mul(2, 4);

            //Test t1 = new Test();
            //int r7 = t1.Add(2,3);
            Console.WriteLine("Ans:" +r1+"\tWrapAns: "+r4+"\tMulAns:"+r5);
            Console.ReadLine();
        }

        public class person
        {
            public virtual string Name { get; set; }
          //  public sealed string Name1 { get; set; }        //'sealedVirtualOverload.Program.person.Name1' cannot be
            public string Address { get; set; }      // sealed because it is not an override.

            //public sealed person()          //Can't make methods sealed!
            //{
            //    Name = "abc";
            //    Address = "xyz";
            //}

            public person()
            {
                Name = "abc";
                Address = "xyz";
            }
        }

        public sealed class cust : person
        {
            public override string Name         //Properties can be overridden.
            {
                get
                {
                    return base.Name;
                }
                set
                {
                    base.Name = value;
                }
            }
        }

        //  public class Test:person        //Can't inherit sealed class

        public class Calc
        {
            public virtual int Add(int a, int b)
            {
                return a + b;
            }

            public int Mul(int a, int b)
            {
                return a * b;
            }
        }

        public class SciCalc : Calc
        {

            public int WrapperAdd(int x, int y )         //One way to access base class method
            {
                int r3 = base.Add(x,y);
                return r3;
            }

            public override int Add(int a, int b)        
            {                                                 
                return a + b + 100;
            }

            public new int Mul(int a, int b)
            {
                return a * b * 10;
            }
        }

        //public class Test : SciCalc
        //{
        //    public int Add(int x, int y)
        //    {
        //        int r6 = base.Add(x, y);
        //        return r6;
        //    }
        //}
    }
}
