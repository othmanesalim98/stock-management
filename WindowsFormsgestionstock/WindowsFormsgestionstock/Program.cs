using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsgestionstock
{
    static class Program
    {
        public static SqlConnection con = new SqlConnection("Data Source=Mouad;Initial Catalog=gestion_stock;Integrated Security=True");

        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();

         public static DataTable remplirgridview (string req)
        {
            
            dt = new DataTable();
            ds = new DataSet();
            da = new SqlDataAdapter(req, con);
            da.Fill(ds, "article");
            return ds.Tables["article"];           


        }
         public static DataTable execute_req(string req)
         {

             dt = new DataTable();
             ds = new DataSet();
             da = new SqlDataAdapter(req, con);
             da.Fill(dt);
             return dt;
             
            


         }
        public static object exctt(string reqtt)
         {
             con.Open();
             cmd.CommandText = reqtt;
             object obj = Program.cmd.ExecuteScalar();
             con.Close();
             return obj;
         }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
