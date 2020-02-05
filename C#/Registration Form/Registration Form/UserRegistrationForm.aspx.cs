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
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2JS0NULB;Initial Catalog=FormsDB;Integrated Security=True");
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
            StateDropDownList.Items.Add("Select State");

            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2JS0NULB;Initial Catalog=FormsDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM State WHERE Country_Id=" + CountryDropDownList.SelectedItem.Value, sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StateDropDownList.DataSource = dt;
            StateDropDownList.DataBind();
        }

        protected void StateDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityDropDownList.Items.Clear();
            CityDropDownList.Items.Add("Select City");

            SqlConnection sqlConnection = new SqlConnection("Data Source=LAPTOP-2JS0NULB;Initial Catalog=FormsDB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM City WHERE State_Id=" + StateDropDownList.SelectedItem.Value, sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CityDropDownList.DataSource = dt;
            CityDropDownList.DataBind();
        }

        protected void CityDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}