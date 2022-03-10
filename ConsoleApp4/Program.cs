using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //generic practice 
            Dtstation <int> d=new Dtstation<int>();
            d.i = 1000;
            keypoint<string,string> kp=new keypoint<string,string>();
            kp.key1 = "id";
            kp.value1 = "1";
            Console.WriteLine(kp.key1+kp.value1);

            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "James");
            list.Add(2, "doe");
            foreach (var kvp in list)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
    class Dtstation<d1>{
        public d1 i { get; set; }

        }
    class keypoint<ky,val>
    {
        public ky key1 { get; set; }
        public val value1 { get; set; }
    }

}
