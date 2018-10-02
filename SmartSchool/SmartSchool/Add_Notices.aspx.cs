using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Add_Notices : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                LoadGridAddNotices();
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        public void LoadGridAddNotices()
        {
            string query = @"SELECT [Id]
                                   ,[Title]
                                   ,[Description]
                                   ,[Date_of_Publish]
                               FROM [dbo].[Notices]";

            GridViewAddNotices.DataSource = dm.GetDataTable(query);
            GridViewAddNotices.DataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }

        protected void btnPublish_Click(object sender, EventArgs e)
        {
            string Date = ddlDay.Text + "-" + ddlMonth.Text + "-" + ddlYear.Text;

            string query = @"INSERT INTO [dbo].[Notices] ([Title],[Description],[Date_of_Publish]) VALUES ('" + txtTitle.Text + "','" + txtDescription.Text + "','" + Date + "')";
            dm.Execute(query);
            LoadGridAddNotices();
            PanelNPublish.Visible = true;
        }

        protected void GridViewAddNotices_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblID = (Label)GridViewAddNotices.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM [dbo].[Notices]
                                    WHERE ID = " + lblID.Text;
            if (dm.Execute(query) == 1)
            {
                LoadGridAddNotices();
            }
        }
    }
}