using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ChatRoom.components
{
    public partial class register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=ZENX\SQLEXPRESS04;Initial Catalog=chatroom;Integrated Security=true;");

        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Value;
            string password = txtPassword.Value;
            string email = txtEmail.Value;

            
            if(!username.Equals("") && !password.Equals("") && !email.Equals("")) {

                cmd = new SqlCommand("insert into userTable (username,password,email) values(@username,@password,@email)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                con.Close();

                Response.Redirect("../login.aspx");
            }
            else{
                Response.Write("Please fill all the details");
            }
         
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../login.aspx");
        }
    }
}