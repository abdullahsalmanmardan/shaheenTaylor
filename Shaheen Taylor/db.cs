using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaheen_Taylor
{
    public class db
    {
        protected SqlConnection getConnection()
        {
            string path=Path.GetFullPath(Environment.CurrentDirectory);
            string databaseName = "shaheenTaylordb.mdf";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + path + @"\" + databaseName + ";Integrated Security=True");
            return con;
         }

        // this function will return the query
        // this function accept the connection string
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // here we have filled the dataset object with the data
            // coming formthe database
            da.Fill(ds);

            con.Close();
            return ds;
        }

        // function to set the data

        public void setData(string query, string message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();

            //  passing the connection  in the cmd;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
