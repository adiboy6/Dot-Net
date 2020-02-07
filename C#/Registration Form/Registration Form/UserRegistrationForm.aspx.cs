using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class UserRegistrationForm : System.Web.UI.Page
    {

        private string ConnectionString = "Data Source=EPINHYDW011C\\MSSQLSERVER1;Initial Catalog=FormDB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Country", sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CountryDropDownList.DataSource = dt;
                CountryDropDownList.DataBind();
            }

        }

        protected void CountryDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateDropDownList.Items.Clear();
            StateDropDownList.Items.Add("--Select State--");
            CityDropDownList.Items.Clear();
            CityDropDownList.Items.Add("--Select City--");

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            if (CountryDropDownList.SelectedItem.Value != "--Select Country--")
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM State WHERE Country_Id=" + CountryDropDownList.SelectedItem.Value, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StateDropDownList.DataSource = dt;
                StateDropDownList.DataBind();
            }
        }

        protected void StateDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityDropDownList.Items.Clear();
            CityDropDownList.Items.Add("--Select City--");

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            if (StateDropDownList.SelectedItem.Text != "--Select State--")
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM City WHERE State_Id=" + StateDropDownList.SelectedItem.Value, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CityDropDownList.DataSource = dt;
                CityDropDownList.DataBind();
            }
        }

        protected void CityDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CountryDropDownList.SelectedIndex = 0;
            StateDropDownList.Items.Clear();
            StateDropDownList.Items.Add("--Select State--");
            CityDropDownList.Items.Clear();
            CityDropDownList.Items.Add("--Select City--");

            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;

            RadioButtonList1.ClearSelection();

            CheckBoxList1.ClearSelection();

        }

        protected void ValidationMessage(Label label,string message)
        {
            label.Text = message;
        }

        protected void CheckTextBoxValidity(TextBox textBox, Label label, string message)
        {
            if (textBox.Text == string.Empty)
                ValidationMessage(label, message);
            else
                label.Visible = false;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            CheckTextBoxValidity(TextBox1, FirstNameValidateLabel, "First Name is Required");
            CheckTextBoxValidity(TextBox2, LastNameValidateLabel, "Last Name is Required");
            CheckTextBoxValidity(TextBox3, PhoneNoValidateLabel, "Phone Number is Required");
            CheckTextBoxValidity(TextBox4, EMailValidateLabel,"E-Mail is Required");

        }
    }
}