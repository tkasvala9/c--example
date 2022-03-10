using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   internal class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder class
            StringBuilder sb = new StringBuilder("twinkle");
            Console.WriteLine("string = ");
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }

            //append string
            Console.WriteLine("\nappend string : ");
            sb.Append(" kasvala");
            Console.WriteLine(sb);

            //remove some letter
            Console.WriteLine("\nremove some letter :");
            sb.Remove(7, 7);
            Console.WriteLine(sb);

            //after permission append
            Console.WriteLine("\nenter your name");
            String fullname = Console.ReadLine();
            StringBuilder sb2 = new StringBuilder(fullname);
            Console.WriteLine("do u want to append?");
            String s = Console.ReadLine();
            Console.WriteLine("after permission append string : ");
            if (s == "y")
            {
                sb2.Append("kasvala");
                Console.WriteLine(sb2);
            }
            else
            {
                Console.WriteLine(sb2);
            }

            //just practice 
            //int a = 0;
            //Console.WriteLine(a.GetType() == typeof(int));
            // Nullable<int> i1 = null;
            // Console.WriteLine(i1.Value);

            //person struct
            person p = new person("James", 62, 10000, 0);
            switch (p.age)
            {
                case int i when i > 0 && i < 25: p.loanamount += p.totalamount * 0.2; break;
                case int i when i > 25 && i < 45: p.loanamount += p.totalamount * 0.35; break;
                case int i when i > 45: p.loanamount += p.totalamount * 0.5; break;
                default: Console.WriteLine("Incorrect Value Entered"); break;
            }
            Console.WriteLine("\nyour loan amount is = "+p.loanamount);
        }
    }

    //structure 
    struct person
    {
        public string name;
        public int age;
        public int totalamount;
        public double loanamount;
        public person(string name, int age, int totalamount, double loanamount)
        {
            this.name = name; this.age = age; this.totalamount = totalamount; this.loanamount = loanamount;
        }
    }

}
