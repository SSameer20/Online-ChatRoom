using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ChatRoom
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZENX\SQLEXPRESS04;Initial Catalog=chatroom;Integrated Security=true;");
        SqlCommand cmd;




        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
  

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Value;
            string password = txtPassword.Value;

            // Open connection
            con.Open();

            // Create SQL command with parameters
            cmd = new SqlCommand("SELECT * FROM userTable WHERE username = @user AND password = @password", con);
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@password", password);

            // Execute query
            SqlDataReader reader = cmd.ExecuteReader();

            // Check if user exists
            if (reader.HasRows)
            {
                // User exists, do something (e.g., redirect to another page)
                Response.Redirect("components/home.aspx");
            }
            else
            {
                // User does not exist or credentials are incorrect, handle accordingly
                // For example, you can display an error message
                Response.Write("Invalid username or password.");
            }

            // Close connection and reader
            reader.Close();
            con.Close();


        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("components/register.aspx");
        }
    }
}