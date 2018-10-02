using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Teachers : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
            LoadGridViewTeachers();
        }

        public void LoadGridViewTeachers()
        {
            string query = @"SELECT [ID]
                                   ,[Name]
                                   ,[Designation]
                                   ,[Gender]
                                   ,[Date_of_Join]
                                   ,[Phone]
                                   ,[Email]
                                   ,[Address]
                               FROM [dbo].[Teachers]";

            GridViewTeachers.DataSource = dm.GetDataTable(query);
            GridViewTeachers.DataBind();
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