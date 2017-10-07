using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace excephandl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter 1st no.: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd no.: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                int div = n1 / n2;
                Console.WriteLine("Division: " + div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cant Div by 0");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Cant div by frmat");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thankyou");
            }
            Console.ReadLine();
        }
    }
}
