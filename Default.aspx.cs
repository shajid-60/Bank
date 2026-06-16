using System;
using System.Configuration;
using System.Data.SqlClient;

namespace A2_B1
{
    public partial class _Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager
                    .ConnectionStrings["GradeDB"]
                    .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGradeCounts();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);

            if (number < 0 || number > 100)
            {
                lblGrade.Text = "Invalid Number";
                return;
            }

            GradingSystem gs =
                new GradingSystem(txtStudentID.Text, number);

            string grade = gs.SetGrade();

            lblGrade.Text = grade;

            using (SqlConnection con =
                new SqlConnection(cs))
            {
                string query =
                @"INSERT INTO Students
                (StudentID, Number, Grade)
                VALUES
                (@StudentID, @Number, @Grade)";

                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@StudentID",
                    txtStudentID.Text);

                cmd.Parameters.AddWithValue(
                    "@Number",
                    number);

                cmd.Parameters.AddWithValue(
                    "@Grade",
                    grade);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadGradeCounts();
        }

        private void LoadGradeCounts()
        {
            using (SqlConnection con =
                new SqlConnection(cs))
            {
                con.Open();

                lblAPlus.Text =
                    GetCount(con, "A+").ToString();

                lblBPlus.Text =
                    GetCount(con, "B+").ToString();

                lblCPlus.Text =
                    GetCount(con, "C+").ToString();

                lblF.Text =
                    GetCount(con, "F").ToString();
            }
        }

        private int GetCount(
            SqlConnection con,
            string grade)
        {
            string query =
                "SELECT COUNT(*) FROM Students WHERE Grade=@Grade";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@Grade",
                grade);

            return (int)cmd.ExecuteScalar();
        }
    }
}