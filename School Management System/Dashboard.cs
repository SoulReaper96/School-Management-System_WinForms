using System.Data.SqlClient;
using System.Data;

namespace School_Management_System
{
    public partial class Dashboard : Form
    {
        SqlConnection dcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CountStudent();
            CountTeachers();
            CountEvents();
            SumFees();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOut_pb_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void CountStudent()
        {
            dcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from StudentTable", dcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StCount_lbl.Text = dt.Rows[0][0].ToString();
            dcon.Close();
        }

        private void CountTeachers()
        {
            dcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TeacherTable", dcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TchCount_lbl.Text = dt.Rows[0][0].ToString();
            dcon.Close();
        }

        private void CountEvents()
        {
            dcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EventsTable", dcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EvCount_lbl.Text = dt.Rows[0][0].ToString();
            dcon.Close();
        }

        private void SumFees()
        {
            dcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select sum(Amount) from FeesTable", dcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Fees_lbl.Text = dt.Rows[0][0].ToString();
            dcon.Close();
        }

    }
}
