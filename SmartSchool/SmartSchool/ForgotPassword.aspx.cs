using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
        }

        protected void btnFSubmit_Click(object sender, EventArgs e)
        {
            
            if (CheckEmaliValidation(txtFEmail.Text) != 0)
            {
                if(txtFPassword.Text != "")
                {
                    if (txtFPassword.Text == txtFCPassword.Text)
                    {
                        RecoveryPassword(txtFEmail.Text, txtFCPassword.Text);

                        Response.Redirect("Login.aspx");
                        lblPassMessage.Text = "";
                    }
                    else
                    {
                        lblPassMessage.Text = "Please input same password";
                    }
                }
                else
                {
                    lblPassMessage.Text = "Please input a password";
                }
                lblEmailMessage.Text = "";
            }
            else
            {
                lblEmailMessage.Text = "Invalid email!";
                lblPassMessage.Text = "";
            }
        }

        public int CheckEmaliValidation(string email)
        {
            string query = @"SELECT * FROM Login WHERE Email = '" + email + "'";
            dm.GetDataTable(query);

            return dm.count;
        }

        public void RecoveryPassword(string email, string password)
        {
            string query = @"UPDATE Login SET Password = '" + password + "' WHERE Email = '" + email + "'";
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