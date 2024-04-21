using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
namespace InsertDemo
{
    public class Class1
    {
        SqlConnection con;
        SqlCommand cmd;

        public Class1()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
        }

        public void Insert(string name, string city)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "insert into tb values (@name,@city)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@city",city);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

    }
}