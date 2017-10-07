using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            cust c1 = new cust();

            p1.Name = "profound";
            string nm = p1.Name;
            p1.Address = "Pune";
            c1.Bill = 200;
            c1.cid = 001;
            cust c2 = new cust(){Bill=201};
            cust c3 = new cust(202,"abc","xyz");
            Console.WriteLine("c3: \t"+c3.Bill+"\t"+c3.Name+"\t"+c3.Address);
            Console.WriteLine("Bill no: {0}",c2.Bill);
            Console.WriteLine(nm+"\t"+p1.Address+"\t"+c1.Bill+"\t"+c1.cid);
            Console.ReadLine();
        }

        public class person
        {
            private string _name;
            private string _address;

            public string Address               //Encapsulate field
            {
                get { return _address; }
                set { _address = value; }
            }

            public string Name              //Encapsulate field
            {
                get { return _name; }
                set { _name = value; }
            }

            public person()                 //constructor
            {
                Name = "Sumedh";
                Address = "A.bad";
            }
            public person(string name,string address)
            {
                Name = name;
                Address = address;
            }

        }

        public class cust:person
        {
            private int Billno;

            public int Bill                     //Auto-properties
            {
                get { return Billno; }
                set { Billno = value; }
            }

            public int cid { get; set; }

            public cust()               //Default constructor
            {
                Billno = 100;
            }

            public cust(int bn,string name,string address):base (name,address)
            {
                Billno = bn;
            }
        }

    }
}
