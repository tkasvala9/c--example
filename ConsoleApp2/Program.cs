using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface vehicle
    {
        void car();
    }
    
    public interface insurancecount 
    {
        void age();
        void insurance();
    }
    class drive : vehicle, insurancecount
    {
        public void car()
        {
            Console.WriteLine("THIS IS CAR");
        }
        int ageofperson;
        public void age()
        {   
           DateTime todaydate = DateTime.Now;
           
            Console.WriteLine("enter bdate");
            string fdate = Console.ReadLine();
            DateTime bdate = Convert.ToDateTime(fdate);
            

             this.ageofperson = todaydate.Year - bdate.Year;
            Console.WriteLine("age of person : "+this.ageofperson);
        }
        
        public void insurance()
        {

           
            int ins = 5000;
            if (this.ageofperson < 25 && this.ageofperson > 0)
                Console.WriteLine("premium below 25 : "+ins * 10);
            else
                Console.WriteLine("premium above 25 : "+ins*20);


        }

    }
    internal class Program 
    {
        
        enum months
        {
            january,
            february,
            march
        }
        static void Main(string[] args)
        {
            int o=(int)months.january;
           Console.WriteLine(o);
            int p=(int)months.february;
            Console.WriteLine(p);
            int q=(int)months.march;
            Console.WriteLine(q);

            dynamic psq = 1;
            dynamic qsqv = "twinkle";
            Console.WriteLine(qsqv.GetType());

            vehicle v = new drive();
            v.car();

          
            
            insurancecount i=new drive();
          
            i.age();
            i.insurance();

            string[] usernames = { "James", "Peter", "abc", "vbb", "ccc" }; 
            int[] usersage = { 20, 30, 47, 35, 35 };
             for(int z=0;z<usernames.Length;z++)
             {

                 for (int j=0;j<usersage.Length;++j)

                 {
                    if(z==j)
                     Console.WriteLine(usernames[z]+" "+usersage[j]);

                 }   
             }
            Array.ForEach(usersage, x => Console.WriteLine(x));
            Console.WriteLine(usersage.Max());
            Console.WriteLine(Array.BinarySearch(usersage, 20));
            /* string[] female = { "twinkle", "hinal", "rinkal", "pinal", "jinal" };
             string[] male = { "suresh", "mitesh", "ritesh", "paresh", "naresh" };
             Console.WriteLine("enter female or male?");

             String s=Console.ReadLine();
             if (s=="female")
             {
                 foreach (string f in female)
                 {
                     Console.WriteLine(f);
                 }
             }
             else
             {
                 foreach (string m in male)
                 {
                     Console.WriteLine(m);

                 }
             }
            int[] intarray = new int[4] { 10, 20, 30, 40 };
            foreach (int x in intarray)
            {   

                Console.WriteLine(x);
            }
            intarray.Append(10);
            int[] intarray1 = new int[20];*/

            ArrayList arr =new ArrayList();
           arr.Add(10);
            arr.Add(20.9);
            arr.Add("twinkle");
            arr.Add(true);
            arr.Add(null);
           
            int[] a6 = { 10, 20, 30 };
            arr.AddRange(a6);
            
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(arr.Contains(10));
            
            




        }
       

    }
}
