using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Add_Teachers : System.Web.UI.Page
    {
        DataManage dm = new DataManage();
        public string Gender;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblAccess.Text = Session["user"].ToString();

                if (!Page.IsPostBack)
                {
                    LoadGridAddTeachers();
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        public void LoadGridAddTeachers()
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

            GridViewAddTeachers.DataSource = dm.GetDataTable(query);
            GridViewAddTeachers.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (rbGNMale.Checked == true)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
            string Date_of_Join = ddlDay.Text + "-" + ddlMonth.Text + "-" + ddlYear.Text;
            int ID = Convert.ToInt32(txtID.Text);

            string query = @"INSERT INTO [dbo].[Teachers] ([ID],[Name],[Designation],[Gender],[Date_of_Join],[Phone],[Email],[Address]) VALUES (" + ID + ",'" + txtName.Text + "','" + ddlDesignation.Text + "','" + Gender + "','" + Date_of_Join + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
            dm.Execute(query);
            LoadGridAddTeachers();

            PanelAddTeachers.Visible = false;
            PanelViewTeachers.Visible = true;
        }

        protected void GridViewAddTeachers_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridViewAddTeachers_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridViewAddTeachers.Rows[e.RowIndex].FindControl("Label1");
            TextBox txtUId = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox txtUName = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox txtUDesignation = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox txtUGender = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox txtUDJoin = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox5");
            TextBox txtUPhone = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox txtUEmail = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox txtUAddress = (TextBox)GridViewAddTeachers.Rows[e.RowIndex].FindControl("TextBox8");


            string query = @"UPDATE [dbo].[Teachers]
                                SET [Name] = '" + txtUName.Text + "',[Designation] = '" + txtUDesignation.Text + "',[Gender] = '" + txtUGender.Text + "',[Date_of_Join] = '" + txtUDJoin.Text + "',[Phone] = '" + txtUPhone.Text + "',[Email] = '" + txtUEmail.Text + "',[Address] = '" + txtUAddress.Text + "' WHERE ID  = " + txtUId.Text + "";

            if (dm.Execute(query) == 1)
            {
                GridViewAddTeachers.EditIndex = -1;
                LoadGridAddTeachers();
            }
        }

        protected void GridViewAddTeachers_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewAddTeachers.EditIndex = -1;
            LoadGridAddTeachers();
        }

        protected void GridViewAddTeachers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblID = (Label)GridViewAddTeachers.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM [dbo].[Teachers]
                                    WHERE ID = " + lblID.Text;
            if (dm.Execute(query) == 1)
            {
                LoadGridAddTeachers();
            }
        }

        protected void btnSAdd_Click(object sender, EventArgs e)
        {
            PanelAddTeachers.Visible = true;
            PanelViewTeachers.Visible = false;
        }

        protected void btnSView_Click(object sender, EventArgs e)
        {
            PanelAddTeachers.Visible = false;
            PanelViewTeachers.Visible = true;
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }
    }
}