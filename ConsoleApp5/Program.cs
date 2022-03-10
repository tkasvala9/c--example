using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> data = new Dictionary<int, string>();
            data.Add(345671, "usa");
            data.Add(321782, "uk");
            data.Add(312783, "india");
            data.Add(123765, "russia");
            data.Add(231654, "pakistan");
            data.Add(234123, "china");
            Console.WriteLine("\nenter from destination");
            string source = Console.ReadLine();
            Console.WriteLine("enter to destination");
            string destination = Console.ReadLine();
            var cost1 = 800;
            Console.WriteLine("cost of any intial source & destination =  " + cost1);
            Console.WriteLine("\nif u want to change from destination y/n");
            string str2 = Console.ReadLine();

            Console.WriteLine("if u want to change to destination y/n");
            string str3 = Console.ReadLine();
            if (str2 == "y" && str3 == "y")
            {
                Console.WriteLine("enter new  from source");
                string newsource = Console.ReadLine();
                Console.WriteLine("enter new  to destination");
                string newdestination = Console.ReadLine();

                if (newsource == "usa")
                {
                    cost1 = cost1 * 10;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "uk")
                {
                    cost1 = cost1 * 5;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "pakistan")
                {
                    cost1 = cost1 * 15;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "russia")
                {
                    cost1 = cost1 * 25;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "china")
                {
                    cost1 = cost1 * 20;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "india")
                {
                    cost1 = cost1 * 3;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
                if (newsource == "pakistan")
                {
                    cost1 = cost1 * 25;
                    Console.WriteLine("cost between new source&destination " + cost1);
                }
            }

        }
    }
}
