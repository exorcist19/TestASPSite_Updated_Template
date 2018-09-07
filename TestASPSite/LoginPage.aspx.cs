using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestASPSite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        MySqlConnection conn;
        string myConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void BtnHandle(object sender, EventArgs e)
        {
            NameValueCollection nvc = Request.Form;

            String _username = username.Value.ToString();
            String _password = password.Value.ToString();

            try
            {
                myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=root;database=test;" + "SSL Mode=None;";

                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                String sql = "Select username, id "
                    + "from users where username='" + _username
                    + "' AND password='" + _password
                    + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                int numberOfResults = dt.Rows.Count;

                rdr.Close();

                if (numberOfResults == 1)
                {
                    Response.Cookies.Add(new HttpCookie("authenticated", "true"));
                    Response.Cookies.Add(new HttpCookie("user_id", dt.Rows[0].Field<int>("id").ToString()));

                    Response.Redirect("DashboardPage.aspx");
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

