using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hello world 
            Console.WriteLine("hello world\n");

            //char array 
            char[] chars = { 'q', 'w' };
            String s = new string(chars);
            Console.WriteLine(s+"\n");

            //single char printing 
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
           
            //concat two string 
            String s2 = "john";
            String s3 = "doe";
            
            String s5 = $"{s2}{" "}{s3}";
            Console.WriteLine(s5);

            //check odd or even
            int i = 103;
            Console.WriteLine("\ncheck enter number is odd or even");
            if (i % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");

            //if length is more than 5 then concat otherwise print old string
            String s6 = "johndoee";
            Console.WriteLine("\nString : ");
            if (s6.Length > 5)
            {
                int index = s6.Length / 2;
                Console.WriteLine(s6.Substring(0, index));
                Console.WriteLine(s6.Substring(index + 1));
            }
            else
            {
                Console.WriteLine(s6);
            }

            // user input string if length is more than 5 then concat otherwise print old string
            Console.WriteLine("\nenter string");
            String s7 = Console.ReadLine();
            if (s7.Length > 5)
            {
                int index = s7.Length / 2;
                Console.WriteLine(s7.Substring(0, index));
                Console.WriteLine(s7.Substring(index + 1));
            }
            else
            {
                Console.WriteLine(s7);
            }

            //fibonachi series
            Console.WriteLine("\nfibonachi series : ");
            int i1 = 0;
            int i2 = 1;
            int i3;
            Console.WriteLine(i1);
            Console.WriteLine(i2);
            for (int i4 = 2; i4 < 10; i4++)
            {
                i3 = i1 + i2;
                Console.WriteLine(i3);
                i1 = i2;
                i2 = i3;
            }

            //user input number is odd or even
            Console.WriteLine("\nenter number");
            String s8 = Console.ReadLine();
            int number = Convert.ToInt32(s8);
            if (number % 2 == 0)
                Console.WriteLine("number is even");
            else
                Console.WriteLine("number is odd");

            //datetime class
            //general date
            DateTime dt = new DateTime();
            Console.WriteLine("\ngeneral date = "+dt);

            //particular foramte date
            String sidate = dt.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine("particular foramte date = "+sidate);

            //cuurent date
            DateTime currentdate = DateTime.Now;
            Console.WriteLine("today date = "+currentdate);

            //using today 
            DateTime todaydate = DateTime.Today;
            Console.WriteLine("today date = " + todaydate);

            //count age
            
            Console.WriteLine("\nenter bdate");
            string fdate = Console.ReadLine();
            DateTime bdate = Convert.ToDateTime(fdate);
            int age = todaydate.Year - bdate.Year;
            Console.WriteLine("age of  person = "+age);

            //StringBuilder class
            Console.WriteLine("\nstring in StringBuilder");
            StringBuilder sb = new StringBuilder("good morning",20);
            for (int i5 = 0; i5 < sb.Length; i5++)
            {
                Console.WriteLine(sb[i5]);
            }

            //using structure 
            Console.WriteLine("\nusing structure printing string : ");
            Person p = new Person("twinkle", "kasvala");
            Console.WriteLine("name : "+p.Name);
            Console.WriteLine("surname :" +p.Firstname);
        }

    }
        //structure
        struct Person
        {
            public string Name;
            public String Firstname;
            public Person(String Name,String Firstname)
            {
                this.Name = Name;
                this.Firstname = Firstname;
            }
        }
}
