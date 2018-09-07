using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestASPSite
{
    public partial class _default : System.Web.UI.Page
    {

        MySqlConnection conn;
        string myConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            myConnectionString = "server=127.0.0.1;uid=root;" +
            "pwd=root;database=test;" + "SSL Mode=None;";

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void Button_event_handler(object sender, EventArgs e)
        {
            List<String> users = new List<String>();

            try
            {
                String sql = "Select * from users;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    // Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                    // Add the user to the list
                    users.Add( rdr[1].ToString() );
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("there's been an error:" + ex.ToString());
                //Label1.Text = "there's been an error " + ex.ToString();
            }

            conn.Close();

            int index;
            //int.TryParse(myInputField.Value, out index);

            //if (index >= 0 && index < users.Count -1)
                //Label1.Text = users.ElementAt(index);
        }
    }
}