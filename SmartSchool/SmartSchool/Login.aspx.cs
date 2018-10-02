using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Login : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn(txtUsername.Text, txtPassword.Text);
        }

        public void LogIn(string username, string password)
        {
            string query = @"SELECT * FROM Login WHERE User_name = '" + username + "' AND Password = '" + password + "'";
            dm.GetDataTable(query);
            if(dm.count != 0)
            {
                Session["user"] = username;
                Response.Redirect("User.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password!";
            }
        }

        public void CheckedLogin()
        {
            if (Session["user"] != null)
            {
                Response.Redirect("User.aspx");
            }
        }
    }
}