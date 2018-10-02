using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartSchool
{
    public partial class Add_Students : System.Web.UI.Page
    {
        DataManage dm = new DataManage();
        public string Gender;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                lblAccess.Text = Session["user"].ToString();

                if (!Page.IsPostBack)
                {
                    LoadGridAddStudents();
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
            
        }

        public void LoadGridAddStudents()
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

            GridViewAddStudents.DataSource = dm.GetDataTable(query);
            GridViewAddStudents.DataBind();
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
            string Date_of_Birth = ddlDBDay.Text + "-" + ddlDBMonth.Text + "-" + ddlDBYear.Text;
            string Date_of_Admission = ddlDADay.Text + "-" + ddlDAMonth.Text + "-" + ddlDAYear.Text;

            string query = @"INSERT INTO Students (Name, Fathers_name, Mothers_name, Date_of_Birth, Date_of_Admission, Gender, Class, Class_Roll, Phone, Email, Address) VALUES ('" + txtName.Text + "','" + txtFName.Text + "','" + txtMName.Text + "','" + Date_of_Birth + "','" + Date_of_Admission + "','" + Gender + "','" + ddlClass.Text + "','" + txtClassRoll.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "')";
            dm.Execute(query);
            LoadGridAddStudents();

            PanelAddStudents.Visible = false;
            PanelViewStudents.Visible = true;
        }

        protected void GridViewAddStudents_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridViewAddStudents_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label lblID = (Label)GridViewAddStudents.Rows[e.RowIndex].FindControl("Label1");
            TextBox txtUId = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox1");
            TextBox txtUName = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox txtUFName = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox txtUMName = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox txtUDBirth = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox5");
            TextBox txtUDAdmission = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox6");
            TextBox txtUGender = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox7");
            TextBox txtUClass = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox8");
            TextBox txtUCRoll = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox9");
            TextBox txtUPhone = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox10");
            TextBox txtUEmail = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox11");
            TextBox txtUAddress = (TextBox)GridViewAddStudents.Rows[e.RowIndex].FindControl("TextBox12");

            string query = @"UPDATE [dbo].[Students]
                                SET [Name] = '" + txtUName.Text + "',[Fathers_name] = '" + txtUFName.Text + "',[Mothers_name] = '" + txtUMName.Text + "',[Date_of_Birth] = '" + txtUDBirth.Text + "',[Date_of_Admission] = '" + txtUDAdmission.Text + "',[Gender] = '" + txtUGender.Text + "',[Class] = '" + txtUClass.Text + "',[Class_Roll] = '" + txtUCRoll.Text + "',[Phone] = '" + txtUPhone.Text + "',[Email] = '" + txtUEmail.Text + "',[Address] = '" + txtUAddress.Text + "' WHERE ID  = " + txtUId.Text + "";

            if (dm.Execute(query) == 1)
            {
                GridViewAddStudents.EditIndex = -1;
                LoadGridAddStudents();
            }
        }

        protected void GridViewAddStudents_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridViewAddStudents.EditIndex = -1;
            LoadGridAddStudents();
        }

        protected void GridViewAddStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label lblID = (Label)GridViewAddStudents.Rows[e.RowIndex].FindControl("Label1");
            string query = @"DELETE FROM [dbo].[Students]
                                    WHERE ID = " + lblID.Text;
            if (dm.Execute(query) == 1)
            {
                LoadGridAddStudents();
            }
        }

        protected void btnSAdd_Click(object sender, EventArgs e)
        {
            PanelAddStudents.Visible = true;
            PanelViewStudents.Visible = false;
        }

        protected void btnSView_Click(object sender, EventArgs e)
        {
            PanelAddStudents.Visible = false;
            PanelViewStudents.Visible = true;
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            DataSearch(txtSearch.Text);
        }

        public void DataSearch(string SearchKey)
        {
            string query = @"SELECT * FROM Students WHERE Name LIKE '%" + SearchKey + "%' OR Fathers_name LIKE '%" + SearchKey + "%' OR Mothers_name LIKE '%" + SearchKey + "%' OR Date_of_Admission LIKE '%" + SearchKey + "%' OR Gender LIKE '%" + SearchKey + "%' OR Class LIKE '%" + SearchKey + "%' OR Class_Roll LIKE '%" + SearchKey + "%' OR Address LIKE '%" + SearchKey + "%'";
            GridViewAddStudents.DataSource = dm.GetDataTable(query);
            GridViewAddStudents.DataBind();
            if (dm.count == 0)
            {
                lblSearchResult.Text = "Sorry! no data found";
            }
            else
            {
                lblSearchResult.Text = "";
            }
        }
    }
}