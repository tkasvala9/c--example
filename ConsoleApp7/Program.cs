using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp7
{
    internal class Program
    {
        static int tableWidth = 73;
        static void Main(string[] args)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=EFCYIT-LTR907;Initial Catalog=container;Integrated Security=True");
           //SqlDataAdapter sqlda = new SqlDataAdapter("Select * from Port", sqlCon);
            //DataTable dtbl = new DataTable();
            //sqlda.Fill(dtbl);
            //Console.ReadLine();

            //SqlDataAdapter showdata = new SqlDataAdapter("Select * from login", sqlCon);
            //DataTable dtbl1 = new DataTable();

            

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"what is your role ? | User | Admin | Close App (user/admin/close)");
                    Console.WriteLine();
                    string ansUA = Console.ReadLine();
                    //foreach (DataRow row in dtbl.Rows)
                    //{
                    //    Console.WriteLine(row["id"] + " " + row["Portname"] + " " + row["portid"]);
                    //}
                    //Console.ReadLine();
                    if (ansUA == "user")
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Sign Up | Sign In | Exit (u/i/e) ");
                            Console.WriteLine();
                            string ansUIE = Console.ReadLine();



                            if (ansUIE == "u")
                            {
                                Console.Clear();
                                Console.WriteLine("***** Create User *****");
                                Console.WriteLine();
                                Console.WriteLine("Enter First Name: ");
                                string fName = Console.ReadLine();
                                Console.WriteLine("Enter Last Name: ");
                                string lName = Console.ReadLine();
                                Console.WriteLine("Enter Username:");
                                string id = Console.ReadLine();
                                Console.WriteLine("Enter Password:");
                                string pass = Console.ReadLine();
                                string query = $"insert into login(firstname,lastname,username,password) values('{fName}', '{lName}', '{id}', '{pass}')";
                                SqlDataAdapter insertqey = new SqlDataAdapter(query, sqlCon);
                                DataTable dtbl1 = new DataTable();
                                insertqey.Fill(dtbl1);
                            }
                            else if (ansUIE == "i")
                            {
                                while (true)
                                {
                                    Console.Clear();
                                Console.WriteLine("***** Enter Credentials *****");
                                Console.WriteLine();
                                Console.Clear();
                                Console.Write("Enter UserId: ");
                                string uid = Console.ReadLine();
                                Console.Write("Enter Password: ");
                                string upass = Console.ReadLine();
                                
                                    SqlDataAdapter sqlda4 = new SqlDataAdapter($"Select * from login ", sqlCon);
                                    DataTable dtbl4 = new DataTable();
                                    sqlda4.Fill(dtbl4);
                                    int flag = 0;
                                   
                                    foreach (DataRow row in dtbl4.Rows)
                                    {
                                        if (uid == Convert.ToString(row["username"]) && upass == Convert.ToString(row["password"]))
                                        {
                                            flag = 1;
                                        }
                                    }
                                    
                                    if (flag == 1)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Welcome !");
                                        Console.WriteLine($"Import | Export | Transactions | Log out ? (i/e/o/l)");
                                        Console.WriteLine();
                                        string ansIEO = Console.ReadLine();
                                        if (ansIEO == "i")
                                        {
                                            string transportation = "import";
                                            string req = "pending";
                                            Console.Clear();
                                            Console.WriteLine("What is your location?");
                                            Console.WriteLine("1.USA");
                                            Console.WriteLine("2.UK");
                                            Console.WriteLine("3.CA");
                                            Console.WriteLine();
                                            string ansIF = Console.ReadLine();



                                            Console.Clear();
                                            Console.WriteLine("From where you want to import?");
                                            Console.WriteLine("1.IND");
                                            Console.WriteLine("2.AUS");
                                            Console.WriteLine("3.UAE");
                                            Console.WriteLine();
                                            string ansIT = Console.ReadLine();



                                            Console.Clear();
                                            Console.WriteLine("Select port:");
                                            Console.WriteLine("1.PortA");
                                            Console.WriteLine("2.PortB");
                                            Console.WriteLine("3.PortC");
                                            Console.WriteLine("4.PortD");
                                            Console.WriteLine();
                                            string ansIP = Console.ReadLine();
                                            string query1 = $"insert into listdata(portfrom,portto,username,request, type, transportation) values('{ansIF}', '{ansIT}', '{uid}', '{req}', '{ansIP}', '{transportation}')";
                                            SqlDataAdapter insertqey = new SqlDataAdapter(query1, sqlCon);
                                            DataTable dtbl1 = new DataTable();
                                            insertqey.Fill(dtbl1);

                                            Console.WriteLine("Your request has been sent to the admin for approval.");
                                            Console.WriteLine("Thank you!");
                                            Console.ReadLine();

                                        }
                                        else if (ansIEO == "e")
                                        {
                                            string transportation = "export";
                                            string req = "pending";
                                            Console.Clear();
                                            Console.WriteLine("What is your location?");
                                            Console.WriteLine("1.USA");
                                            Console.WriteLine("2.UK");
                                            Console.WriteLine("3.CA");
                                            Console.WriteLine();
                                            string ansIF = Console.ReadLine();



                                            Console.Clear();
                                            Console.WriteLine("From where do you want to export?");
                                            Console.WriteLine("1.IND");
                                            Console.WriteLine("2.AUS");
                                            Console.WriteLine("3.UAE");
                                            Console.WriteLine();
                                            string ansIT = Console.ReadLine();



                                            Console.Clear();
                                            Console.WriteLine("Select port:");
                                            Console.WriteLine("1.PortA");
                                            Console.WriteLine("2.PortB");
                                            Console.WriteLine("3.PortC");
                                            Console.WriteLine("4.PortD");
                                            Console.WriteLine();
                                            string ansIP = Console.ReadLine();


                                            string query1 = $"insert into listdata(portfrom,portto,username,request, type, transportation) values('{ansIF}', '{ansIT}', '{uid}', '{req}', '{ansIP}', '{transportation}')";
                                            SqlDataAdapter insertqey = new SqlDataAdapter(query1, sqlCon);
                                            DataTable dtbl1 = new DataTable();
                                            insertqey.Fill(dtbl1);


                                            Console.WriteLine("Your request has been sent to the admin for approval.");
                                            Console.WriteLine("Thank you!");
                                            Console.ReadLine();



                                        }
                                        else if (ansIEO == "o")
                                        {
                                            Console.Clear();
                                            SqlDataAdapter sqlda2 = new SqlDataAdapter($"Select * from listdata where username='{uid}'", sqlCon);
                                            DataTable dtbl2 = new DataTable();
                                            sqlda2.Fill(dtbl2);
                                            PrintLine();

                                            PrintRow("ID", "From Port", "To Port", "Username", "Type", "Transport", "Request");
                                            PrintLine();
                                            foreach (DataRow row in dtbl2.Rows)
                                            {
                                                PrintRow(Convert.ToString(row["id"]), Convert.ToString(row["portfrom"]), Convert.ToString(row["portto"]), Convert.ToString(row["username"]), Convert.ToString(row["type"]), Convert.ToString(row["transportation"]), Convert.ToString(row["request"]));
                                            }
                                            PrintLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Press enter to proceed");
                                            Console.ReadLine();

                                        }
                                        else if (ansIEO == "l")
                                        {
                                            break;
                                        }



                                    }
                                    else if(flag==0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong id or password!");
                                        Console.WriteLine();
                                        Console.WriteLine("Press enter to proceed");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                }
                            }
                            else if (ansUIE == "e")
                            {
                                break;
                            }
                        }
                    }

                    else if (ansUA == "admin")
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Sign In | Exit (i/e) ");
                            Console.WriteLine();
                            string ansIE = Console.ReadLine();



                            if (ansIE == "i")
                            {
                                Console.Clear();
                                Console.WriteLine("Enter UserName: ");
                                string userid = Console.ReadLine();
                                Console.WriteLine("Enter Password: ");
                                string upass = Console.ReadLine();
                                if (userid == "admin" && upass == "admin")
                                {
                                    while (true)
                                    {
                                        string reqUpdate = "approved";
                                        Console.Clear();
                                        Console.WriteLine("User Approval | Log out | View All (a/l/v)");
                                        string ansALV = Console.ReadLine();
                                        if (ansALV == "a")
                                        {
                                            Console.Clear();
                                            SqlDataAdapter sqlda2 = new SqlDataAdapter("Select * from listdata where request='pending'", sqlCon);
                                            DataTable dtbl2 = new DataTable();
                                            sqlda2.Fill(dtbl2);
                                            PrintLine();

                                            PrintRow("ID", "From Port", "To Port","Username","Type", "Transport", "Request");
                                            PrintLine();
                                            foreach (DataRow row in dtbl2.Rows)
                                            {
                                                PrintRow(Convert.ToString(row["id"]), Convert.ToString(row["portfrom"]), Convert.ToString(row["portto"]), Convert.ToString(row["username"]), Convert.ToString(row["type"]), Convert.ToString(row["transportation"]), Convert.ToString(row["request"]));
                                            }
                                            PrintLine();
                                            Console.WriteLine();
                                            Console.WriteLine("Enter id you want to approve: ");
                                            int ans = Convert.ToInt32(Console.ReadLine());
                                            string query1 = $"update listdata set request='approved' where id={ans}";

                                            SqlDataAdapter insertqey = new SqlDataAdapter(query1, sqlCon);
                                            DataTable dtbl1 = new DataTable();
                                            insertqey.Fill(dtbl1);
                                            
                                            Console.WriteLine("Press enter to proceed");
                                            Console.ReadLine();
                                        }
                                        else if (ansALV == "e")
                                        {
                                            Console.Clear();
                                            break;
                                        } else if(ansALV == "v")
                                        {
                                            Console.Clear();
                                            SqlDataAdapter sqlda2 = new SqlDataAdapter("Select * from listdata", sqlCon);
                                            DataTable dtbl2 = new DataTable();
                                            sqlda2.Fill(dtbl2);
                                            PrintLine();

                                            PrintRow("ID", "From Port", "To Port", "Username", "Type", "Transport", "Request");
                                            PrintLine();
                                            foreach (DataRow row in dtbl2.Rows)
                                            {
                                                PrintRow(Convert.ToString(row["id"]), Convert.ToString(row["portfrom"]), Convert.ToString(row["portto"]), Convert.ToString(row["username"]), Convert.ToString(row["type"]), Convert.ToString(row["transportation"]), Convert.ToString(row["request"]));
                                            }
                                            PrintLine();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please Enter Valid Username and Password ::");
                                    continue;
                                }
                            }
                            else if (ansIE == "e")
                            {
                                break;
                            }
                        }
                    }
                    else if (ansUA == "close")
                    {
                        return;
                    }
                }
            }
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|"; foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }
            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text; if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}