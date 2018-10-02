using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblAccess.Text = Session["user"].ToString();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void btnStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Students.aspx");
        }

        protected void btnTeachers_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Teachers.aspx");
        }

        protected void btnNotice_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Notices.aspx");
        }
    }
}