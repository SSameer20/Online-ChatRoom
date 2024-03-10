using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatRoom.components
{
    public partial class post : System.Web.UI.Page
    {

        SqlCommand cmd = null;

        SqlConnection con = new SqlConnection(@"Data Source=ZENX\SQLEXPRESS04;Initial Catalog=chatroom;Integrated Security=true;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                // Create a SqlCommand object for calling the stored procedure
                SqlCommand cmd = new SqlCommand("sp_newThread", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters required by the stored procedure
                cmd.Parameters.AddWithValue("@user", txtUser.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescription.Text);
                cmd.Parameters.AddWithValue("@like", 0); // Assuming default value for like is 0

                // Execute the stored procedure
                cmd.ExecuteNonQuery();

                // Optional: Provide feedback to the user
                Response.Write("<script>alert('New thread created successfully!');</script>");
                con.Close();
                Response.Redirect("home.aspx");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}