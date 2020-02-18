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
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=EPINHYDW011C\\MSSQLSERVER1;Initial Catalog=FormDB;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users WHERE Username = @username AND Password = @password", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                sqlCommand.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Open();
                int temp = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    Application["Name"] = UsernameTextBox.Text;
                    Response.Redirect("WelcomePage.aspx");
                }
                else
                {
                    Response.Write("Invalid username or password. Please try again.");
                }
            }
            else
            {

            }
        }
    }
}