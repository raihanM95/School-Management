using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Register : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtREmail.Text != "" && txtRUsername.Text != "" && txtRPassword.Text != "")
            {
                if(txtRPassword.Text == txtRCPassword.Text)
                {
                    Registers(txtREmail.Text, txtRUsername.Text, txtRCPassword.Text);
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblMessage.Text = "Please input same password";
                }
            }
            else
            {
                lblMessage.Text = "Please enter all information";
            }
        }

        public void Registers(string email, string username, string password)
        {
            string query = @"INSERT INTO Login VALUES ('" + email + "','" + username + "','" + password + "')";
            dm.Execute(query);
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