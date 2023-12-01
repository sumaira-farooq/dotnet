using System;
using System.Data.SqlClient;
namespace ADO
{
    public class Program
    {
        //  private object con;

        //private object con;

        // public object con { get; private set; }

        //public object database { get; private set; }
        //public object StudentDB { get; private set; }

        static void Main(string[] args)
        {
            //call method
            new Program().connectingWithTryCatch();
            Console.ReadKey();
        }
        public void connecting()
        {
            //create connection string
            string cs = "data source =SUMAIRAA;database = studentDB;integrated security=SSPI";
            //create object
            using (SqlConnection con = new SqlConnection(cs))
            {

                con.Open();
                Console.WriteLine("connection succedd");
            }
        }

        //WITH TRY CATCH

        public void connectingWithTryCatch()
        {

            //con obj create
            SqlConnection con = null;
            try {
                //create connection string
                string cs = "data source =SUMAIRAA;database = studentDB;integrated security=SSPI";

                con = new SqlConnection(cs);



                con.Open();
                Console.WriteLine("connection succedd");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e);
            }
            finally
            {
                con.Close();
            }


        }
    }