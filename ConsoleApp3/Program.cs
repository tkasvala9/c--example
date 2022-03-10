using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List in collection 
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            int[] arr = { 10, 20, 30 };
            numbers.AddRange(arr);
            Console.WriteLine("total number in list = "+numbers.Count);
            Console.WriteLine("\nlist element :");
             foreach (int num in numbers)
             {
                 Console.WriteLine(num);
             }

            //customer Generic class collection
            var customer = new List<customer>()
             {
                 new customer() { CustomerID = 1, CustomerName = "john"},
                 new customer() { CustomerID = 2, CustomerName ="doe"},
                 new customer() { CustomerID = 3, CustomerName ="hems"}

             };
            Console.WriteLine("\ndetail of cutomer : ");
            foreach (customer c in customer)
            {
                Console.WriteLine(c.CustomerID+" "+ c.CustomerName);
            }

            //container generic class collection
            var container = new List<container>()
            {
                new container(){from="usa",to="uk",cost=20000},
                new container(){from="india",to="usa",cost=25000},
                new container(){from="uk",to="india",cost=30000}
            };
            Console.WriteLine("\nenter from source ");
            String froms=Console.ReadLine();
            Console.WriteLine("enter to destination");
            String tos=Console.ReadLine();
            if (froms == tos)
            {
                Console.WriteLine("enter right from destination and to destination");
            }
            foreach (var item in container)
            {
                if (froms == item.from && tos == item.to)
                {
                    Console.WriteLine("cost of " + item.from +" to "+item.to+" = "+item.cost);
                    Console.WriteLine("from = "+item.from+"\n "+"to = " + item.to+ "\n " + "cost = " + item.cost);
                    break;    
                }     
            }
            
             Console.WriteLine("\nenter id in which u can update name in customer");
             String s=Console.ReadLine();
             int i=Convert.ToInt32(s);
             foreach (var c in customer)
             {
                 if(i==c.CustomerID)
                 {
                     Console.WriteLine("enter updated name");
                     String uname = Console.ReadLine();
                     c.CustomerName = uname;
                 }
                 Console.WriteLine(c.CustomerName);
             }
             
            ////Dictionary collection
            IDictionary<int, string> datas = new Dictionary<int, string>();
            datas.Add(1, "james");
            datas.Add(2, "peter");
            Console.WriteLine("\ndictionary collection data");
            foreach (KeyValuePair<int, string> kvp in datas)
            {
                Console.WriteLine(kvp.Key+" "+ kvp.Value);
            }

            //Dictionary collection
             IDictionary<int, string> data = new Dictionary<int, string>();
             data.Add(345671, "usa");
             data.Add(321782, "uk");
             data.Add(312783, "india");
             data.Add(123765, "russia");
             data.Add(231654, "pakistan");
             data.Add(234123, "china");
             Console.WriteLine("\nenter from destination");
             string source=Console.ReadLine();
             Console.WriteLine("enter to destination");
             string destination = Console.ReadLine();
            var cost1 = 800;
            Console.WriteLine("cost of any intial source & destination =  "+cost1);
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
               
                if(newsource == "usa")
                {
                    cost1 = cost1 * 10;
                    Console.WriteLine("cost between new source&destination "+cost1);
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

            //
             DateTime dt = DateTime.Now;
             Console.WriteLine("\nenter date");

           int idate=Convert.ToInt32(dt.Day);
             string str7 = Console.ReadLine();
             DateTime dt2 = Convert.ToDateTime(str7);
             int jdate = Convert.ToInt32(dt2.Day);
             var k = jdate - idate;

             if (k <= 3)
             {
                 if (str2 == "y" && str3 == "y")
                 {
                     Console.WriteLine("enter new  from source");
                     string str4 = Console.ReadLine();
                     Console.WriteLine("enter new  to destination");
                     string str5 = Console.ReadLine();
                     Console.WriteLine("from = " + str4 + " " + "\nto = " + str5);


                 }
             }
             else
             {
                 foreach (KeyValuePair<int, string> kvp in data)
                 {
                     if (source == destination)
                     {
                         Console.WriteLine("from and to detination not same so enter right from and end destination");
                         break;
                     }
                     if (source == kvp.Value)
                     {
                         Console.WriteLine("from destination port = " + kvp.Key);
                     }
                     if (destination == kvp.Value)
                     {
                         Console.WriteLine("to destination port = " + kvp.Key);

                     }

                 }
             }

            //loginform generic class collection in which you can change password and forgot password
            Console.WriteLine("enter firstname");
            string fn=Console.ReadLine();
            
            Console.WriteLine("enter lastname");
            string ln=Console.ReadLine();
           
            Console.WriteLine("enter phone");
            String pn=Console.ReadLine();
            

            var loginform = new List<loginform>()
            {
                new loginform(){ firstname =fn,lastname=ln,phonenumber=pn}
                
            };
            foreach(loginform form in loginform)
            {
                Console.WriteLine("firstname = "+form.firstname);
                Console.WriteLine("lastname = "+form.lastname);   
                Console.WriteLine("phone number = "+form.phonenumber);
            }

            Console.WriteLine("enter password");
            String pwd=Console.ReadLine();
            var generatepwd = new List<generatepwd>()
            {
                new generatepwd(){ username =pn,password=pwd}
            };
            foreach (generatepwd form in generatepwd)
            {
                Console.WriteLine("username = "+form.username);
                Console.WriteLine("password = "+form.password);
            }

            Console.WriteLine("if you want forgot pwd y/n");
            String str = Console.ReadLine();
            if (str == "y")
            {
                Console.WriteLine("King of the fruit");
                String question1=Console.ReadLine();
                Console.WriteLine("which is the big city in gujrat?");
                String question2 = Console.ReadLine();
                Console.WriteLine("who is the best football player in the world?");
                String question3 = Console.ReadLine();
                if (question1 == "mango"&& question2 == "baroda"&& question3 == "ronaldo")
                {
                    Console.WriteLine("enter  your new password");
                    String changepassword = Console.ReadLine();
                    var forgottpwd = new List<forgottpwd>()
                     {
                new forgottpwd(){ frgtpwd=changepassword}
                 };
                    foreach( forgottpwd f in forgottpwd)
                    {
                        Console.WriteLine("your new password is = "+f.frgtpwd);
                    }

                }
            }
            else
            {
                foreach (generatepwd form in generatepwd)
                {
                    Console.WriteLine("username = " + form.username);
                    Console.WriteLine("password = " + form.password);
                }
            }

            Console.WriteLine("\nif you want change pwd y/n");
            String s6=Console.ReadLine();
            if (s6 == "y")
            {
                Console.WriteLine("enter  your new password");
                String upwd = Console.ReadLine();
                var changepwd = new List<changepwd>()
            {
                new changepwd(){ username =pn,updatedpwd=upwd }
            };
                foreach (changepwd form in changepwd)
                {
                    Console.WriteLine("username = " + form.username);
                    Console.WriteLine("updated password = " + form.updatedpwd);
                }
            }
            else
            {
                foreach (generatepwd form in generatepwd)
                {
                    Console.WriteLine("username = " + form.username);
                    Console.WriteLine("password = " + form.password);
                }
            }
        }
    }
    
    //customer generic class collection
    public class customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }

    //container generic class collection
    public class container
    {
        public string from { get; set; }
        public string to { get; set; }
        public int cost { get; set; }

    }

    //loginform generic class collection in which you can change password and forgot password
    public class loginform
    {
        public string firstname { get; set; }
        public string  lastname{ get;set; }
        public string phonenumber{ get; set; }
    }
    public class generatepwd
    {   
        public string username { get; set; }
        public string password { get; set; }
    }
    public class changepwd
    {
        public string username { get; set; }
        public string updatedpwd { get; set; }
    }
    
    public class forgottpwd
    {
        public string frgtpwd { get; set; }
    }        
}
