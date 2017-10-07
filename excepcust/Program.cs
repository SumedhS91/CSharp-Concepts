using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excepcust
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st no.: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());

                int sum = n1 + n2;
                if (sum > 30)
                { 
                    throw new MyCustEx("Add Can't be greater than 30");
                }
            }
            catch (MyCustEx ex)
            {
                Console.WriteLine(ex.msg);
                Console.WriteLine("\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n"+ex.Message);
            }
            Console.ReadLine();
        }

        public class MyCustEx:Exception
        {
            public string msg { get; set; }
            public MyCustEx(string m)
            {
                msg = m;
            }
            public override string Message
            {
                get
                {
                    return msg;
                }
            }
        }
    }
}
