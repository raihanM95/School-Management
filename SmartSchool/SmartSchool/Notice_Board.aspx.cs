using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Notice_Board : System.Web.UI.Page
    {
        DataManage dm = new DataManage();

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckedLogin();
            LoadGridViewNotices();
        }

        public void LoadGridViewNotices()
        {
            string query = @"SELECT [Id]
                                   ,[Title]
                                   ,[Description]
                                   ,[Date_of_Publish]
                               FROM [dbo].[Notices]";

            GridViewNoticeBoard.DataSource = dm.GetDataTable(query);
            GridViewNoticeBoard.DataBind();
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