using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace TrafficWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Click the Button below to view the traffic data");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //This will connect the web to the database
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TrafficDataConnectionString"].ConnectionString);

                //open the connection
                con.Open();

                /*SQL query to insert database data into viewable tables in home pg

                string insert = "insert into TrafficTable (Direction,DateTime) values(@Direction,@DateTime)";
                SqlCommand cmd = new SqlCommand(insert,con);
                cmd.Parameters.AddWithValue("@Direction", TextBox1.Text); */
                //cmd.Parameters.AddWithValue("@DateTime", TextBox2.Text);
                //cmd.ExecuteNonQuery();

                //execute scalar



                // Once the button on page is pressed, should be redirected to home page displaying data
                Response.Redirect("home.aspx");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
            }
    }
}