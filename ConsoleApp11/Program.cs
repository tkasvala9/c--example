using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                String product = "Product57";

                Console.WriteLine("enter productname");
                String pname = Console.ReadLine();

                Console.WriteLine("enter quntity");
                String qnty = Console.ReadLine();
                int quntity = Convert.ToInt32(qnty);

                SqlConnection sqlconn = new SqlConnection(@"Data Source=EFCYIT-LTR907;Initial Catalog=Product57;Integrated Security=True");
                SqlDataAdapter adapter3 = new SqlDataAdapter($"INSERT INTO product_detail012(productname,pquntity) VALUES('" + pname + "','" + quntity + "')", sqlconn);
                DataTable dtbl14 = new DataTable();
                adapter3.Fill(dtbl14);
                

                SqlDataAdapter adapter4 = new SqlDataAdapter($"select * from product_detail012", sqlconn);
                DataTable dtbl15 = new DataTable();
                adapter4.Fill(dtbl15);

                    Console.WriteLine("Enter ID :");
                    int id = Convert.ToInt32(Console.ReadLine());

                    int final_quantity = 0;
                    try
                    {
                          Console.WriteLine("Enter Sell:");
                          int sell = Convert.ToInt32(Console.ReadLine());

                          SqlDataAdapter adapter6 = new SqlDataAdapter($"UPDATE product_detail012 set sell ={sell} where id={id}", sqlconn);
                          DataTable dtbl16 = new DataTable();
                          adapter6.Fill(dtbl16);

                          SqlDataAdapter adapter7 = new SqlDataAdapter($"SELECT pquntity FROM product_detail012 WHERE id={id};", sqlconn);
                          DataTable dtbl17 = new DataTable();
                          adapter7.Fill(dtbl17);

                         foreach(DataRow dr in dtbl17.Rows)
                         {
                            final_quantity = Convert.ToInt32(dr["pquntity"]) - sell;
                         }

                         SqlDataAdapter adapter8 = new SqlDataAdapter($"UPDATE product_detail012 set pquntity ={final_quantity} where id={id}", sqlconn);
                         DataTable dtbl18 = new DataTable();
                         adapter8.Fill(dtbl18);

                    }
                catch (Exception ex)
                    {
                        Console.WriteLine("adf");
                    }

                SqlConnection conn = new SqlConnection(@"Data Source=EFCYIT-LTR907;Integrated Security=True");
                SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM sys.databases", conn);
                DataTable dtable = new DataTable();

                db.Fill(dtable);
                int i = 0;
                try
                {
                    foreach(DataRow r in dtable.Rows)
                    {  
                        if(r["name"] == product)
                        {
                            Console.WriteLine(r["name"]);
                            i++;
                            break;
                        }     
                    }
                    if (i > 0)
                    {
                        SqlDataAdapter dbcreated = new SqlDataAdapter("CREATE DATABASE Product57", conn);
                        dbcreated.Fill(dtable);

                        SqlConnection temp = new SqlConnection(@"Data Source=EFCYIT-LTR907;Initial Catalog=Product57;Integrated Security=True");
                        SqlDataAdapter adapt = new SqlDataAdapter("CREATE TABLE  product_detail012( id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, productname VARCHAR(20), pquntity int NOT NULL)", temp);
                        DataTable table= new DataTable();
                        adapt.Fill(table);
                    }
              
                }
           
                catch (Exception ex)
                {   
                    conn.Close();  
                }
        }
    }
}
