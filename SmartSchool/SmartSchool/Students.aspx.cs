using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Students : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
            LoadGridViewStudents();
        }

        public void LoadGridViewStudents()
        {
            string query = @"SELECT [ID]
                                   ,[Name]
                                   ,[Fathers_name]
                                   ,[Mothers_name]
                                   ,[Date_of_Birth]
                                   ,[Date_of_Admission]
                                   ,[Gender]
                                   ,[Class]
                                   ,[Class_Roll]
                                   ,[Phone]
                                   ,[Email]
                                   ,[Address]
                               FROM [dbo].[Students]";

            GridViewStudents.DataSource = dm.GetDataTable(query);
            GridViewStudents.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSearch(txtSearch.Text);
        }

        public void DataSearch(string SearchKey)
        {
            string query = @"SELECT * FROM Students WHERE Name LIKE '%" + SearchKey + "%' OR Fathers_name LIKE '%" + SearchKey + "%' OR Mothers_name LIKE '%" + SearchKey + "%' OR Date_of_Admission LIKE '%" + SearchKey + "%' OR Gender LIKE '%" + SearchKey + "%' OR Class LIKE '%" + SearchKey + "%' OR Class_Roll LIKE '%" + SearchKey + "%' OR Address LIKE '%" + SearchKey + "%'";
            GridViewStudents.DataSource = dm.GetDataTable(query);
            GridViewStudents.DataBind();
            if (dm.count == 0)
            {
                lblSearchResult.Text = "Sorry! no data found";
            }
            else
            {
                lblSearchResult.Text = "";
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