﻿using System;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;
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

        protected void Button3_Click(object sender, EventArgs e)
        {
            CountryDropDownList.SelectedIndex = 0;
            StateDropDownList.Items.Clear();
            StateDropDownList.Items.Add("--Select State--");
            CityDropDownList.Items.Clear();
            CityDropDownList.Items.Add("--Select City--");

            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PhoneNumberTextBox.Text = string.Empty;
            EMailTextBox.Text = string.Empty;

            GenderRadioButtonList.ClearSelection();

            StreamCheckBoxList.ClearSelection();

            FirstNameValidateLabel.Visible = true;
            FirstNameValidateLabel.Text = "*";

            LastNameValidateLabel.Visible = true;
            LastNameValidateLabel.Text = "*";

            PhoneNoValidateLabel.Visible = true;
            PhoneNoValidateLabel.Text = "*";

            EMailValidateLabel.Visible = true;
            EMailValidateLabel.Text = "*";

            GenderValidityLabel.Text = "*";
            GenderValidityLabel.Visible = true;

            StreamValidityLabel.Text = "*";
            StreamValidityLabel.Visible = true;

            DOBValidationLabel.Text = "*";
            DOBValidationLabel.Visible = true;
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
            CheckTextBoxValidity(FirstNameTextBox, FirstNameValidateLabel, "First Name is Required");
            CheckTextBoxValidity(LastNameTextBox, LastNameValidateLabel, "Last Name is Required");
            CheckTextBoxValidity(PhoneNumberTextBox, PhoneNoValidateLabel, "Phone Number is Required");
            CheckTextBoxValidity(EMailTextBox, EMailValidateLabel, "E-Mail is Required");

            if (GenderRadioButtonList.SelectedItem == null)
                GenderValidityLabel.Text = "Gender is required";
            else
                GenderValidityLabel.Visible = false;

            if (StreamCheckBoxList.SelectedValue.Length == 0)
                StreamValidityLabel.Text = "Please choose any one of the Stream";
            else
                StreamValidityLabel.Visible = false;

            if (DOBCalendar.SelectedDate == new DateTime(0001, 1, 1, 0, 0, 0) || DOBCalendar.SelectedDate == DateTime.Now.Date || DOBCalendar.SelectedDate.Date.CompareTo(DateTime.Now.Date)>0)
                DOBValidationLabel.Text = "Invalid Date Of Birth";
            else
                DOBValidationLabel.Visible = false;

            if (CountryDropDownList.SelectedValue == "--Select Country--")
                CountryValidityLabel.Text = "Please choose a country";
            else
            {
                if (StateDropDownList.SelectedValue == "--Select State--")
                    StateValidityLabel.Text = "Please choose a state";
                else
                {
                    if (CityDropDownList.Text == "--Select City--")
                        CityValidityLabel.Text = "Please choose a city";
                    else
                        CityValidityLabel.Visible = false;

                    StateValidityLabel.Visible = false;
                }
                CountryValidityLabel.Visible = false;
            }
        }

    }
}