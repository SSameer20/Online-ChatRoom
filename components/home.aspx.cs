using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace ChatRoom
{
    
    
    public partial class home : System.Web.UI.Page
    {
        SqlCommand cmd = null;
       
        SqlConnection con = new SqlConnection(@"Data Source=ZENX\SQLEXPRESS04;Initial Catalog=chatroom;Integrated Security=true;");
        
        public class Post
        {
            public string user;
            public string description;
            public string time;
            public int like;
        }

        public List<Post>listPost = new List<Post>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // FillData();
                FillGrid();
                //ValidateForm();
            }
        }

        public void FillGrid()
        {
            try {
                con.Open();
                cmd = new SqlCommand("select * from blog order by time DESC", con);

                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                con.Close();
            } 
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }

        protected void btnPost_Click(object sender, EventArgs e)
        {
            Response.Redirect("post.aspx");
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            bool flag = false;
            Button btn = (Button)sender;
            string selectedUser = btn.CommandArgument;
            con.Open();
            //IncrementLikeCount
            if (flag == false)
            {
              
                // Create a SqlCommand object for calling the stored procedure
                SqlCommand cmd = new SqlCommand("IncrementLikeCount", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters required by the stored procedure

                cmd.Parameters.AddWithValue("@user", selectedUser); // Assuming default value for like is 0

                // Execute the stored procedure
                cmd.ExecuteNonQuery();

                // Optional: Provide feedback to the user
                
                flag = true;
            }
            else
            {
                //sp_DecreaseLikeCount
                SqlCommand cmd = new SqlCommand("sp_DecreaseLikeCount", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters required by the stored procedure

                cmd.Parameters.AddWithValue("@user", selectedUser); // Assuming default value for like is 0

                // Execute the stored procedure
                cmd.ExecuteNonQuery();

                // Optional: Provide feedback to the user

                flag = false;
            }
            con.Close();
            Response.Redirect("home.aspx");
        }
    }
}