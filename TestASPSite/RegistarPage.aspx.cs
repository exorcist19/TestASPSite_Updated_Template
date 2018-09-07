using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestASPSite
{
    public partial class RegistarPage : System.Web.UI.Page
    {
        MySqlConnection conn;
        string myConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void BtnHandle(object sender, EventArgs e)
        {
            String _username = username.Value.ToString();
            String _password = password.Value.ToString();
            String _confirmation = confirmation.Value.ToString();






            if (_password != _confirmation ||
                _password == String.Empty ||
                _confirmation == String.Empty)

            {
                return;

            }


            if (_username == String.Empty)
            {
                return;
            }



            try
            {
                myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=root;database=test;" + "SSL Mode=None;";

                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                String sql = "insert into users(username, password) " +
                    "values('"+ _username +"', '"+ _password +"')";
                    
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                //Determine the number of rows affected 
                //using the proprty on the reader object
                int sucessfulNumberOfInserts = rdr.RecordsAffected;




                rdr.Close();

                if (sucessfulNumberOfInserts == 1)
                {
                    output.Text = "Success";
                    Response.Redirect("LoginPage.aspx");
                }

                else
                    output.Text = "Failed";
            }
            catch (Exception ex)
            {
                // Console.WriteLine("there's been an error:" + ex.ToString());
                output.Text = ex.Message;
            }

            conn.Close();

        }
    }
}