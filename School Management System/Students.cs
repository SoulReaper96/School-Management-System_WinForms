using System.Data.SqlClient;
using System.Data;

namespace School_Management_System
{
    public partial class Students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");
        public int StKey = 0;

        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }

        private void DisplayStudent()
        {
            con.Open();
            string query = "SELECT * FROM StudentTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StData_dgv.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Reset()
        {
            StKey = 0;
            StName_tb.Text = "";
            StSurname_tb.Text = "";
            StFees_tb.Text = "";
            StAddress_tb.Text = "";
            StGender_cmb.SelectedIndex = 0;
            StClass_cmb.SelectedIndex = 0;
            StDOB_dtp.Value = DateTime.Now;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StName_tb.Text) || string.IsNullOrEmpty(StSurname_tb.Text) || string.IsNullOrEmpty(StFees_tb.Text) || string.IsNullOrEmpty(StAddress_tb.Text) || StGender_cmb.SelectedIndex == -1 || StClass_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentTable(StName, StSurname, StGender, StDob, StClass, StFees, StAddress) VALUES (@Sname, @Ssurname, @Sgender, @Sdob, @Sclass, @Sfees, @Saddress)", con);
                    cmd.Parameters.AddWithValue("@Sname", StName_tb.Text);
                    cmd.Parameters.AddWithValue("@Ssurname", StSurname_tb.Text);
                    cmd.Parameters.AddWithValue("@Sgender", StGender_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Sdob", StDOB_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@Sclass", StClass_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Sfees", StFees_tb.Text);
                    cmd.Parameters.AddWithValue("@Saddress", StAddress_tb.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StData_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StData_dgv.SelectedRows.Count > 0) // Check if there are selected rows
            {
                DataGridViewRow selectedRow = StData_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 8) // Check if there are enough cells in the row
                {
                    StName_tb.Text = selectedRow.Cells[1].Value?.ToString() ?? ""; // Use null-conditional operator to avoid null reference exception
                    StKey = selectedRow.Cells[0].Value == null ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
                    StSurname_tb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    StGender_cmb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    StDOB_dtp.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    StClass_cmb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    StFees_tb.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
                    StAddress_tb.Text = selectedRow.Cells[7].Value?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("Selected row does not have enough cells.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StDelete_btn_Click(object sender, EventArgs e)
        {
            if (StKey == 0)
            {
                MessageBox.Show("Select A Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM StudentTable WHERE StId = @StKey", con);
                    cmd.Parameters.AddWithValue("@StKey", StKey);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StName_tb.Text) || string.IsNullOrEmpty(StSurname_tb.Text) || string.IsNullOrEmpty(StFees_tb.Text) || string.IsNullOrEmpty(StAddress_tb.Text) || StGender_cmb.SelectedIndex == -1 || StClass_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE StudentTable SET StName = @Sname, StSurname = @Ssurname, StGender = @Sgender, StDob = @Sdob, StClass = @Sclass, StFees = @Sfees, StAddress = @Saddress where StId = @StudentID", con);
                    cmd.Parameters.AddWithValue("@Sname", StName_tb.Text);
                    cmd.Parameters.AddWithValue("@Ssurname", StSurname_tb.Text);
                    cmd.Parameters.AddWithValue("@Sgender", StGender_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Sdob", StDOB_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@Sclass", StClass_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Sfees", StFees_tb.Text);
                    cmd.Parameters.AddWithValue("@Saddress", StAddress_tb.Text);
                    cmd.Parameters.AddWithValue("@StudentID", StKey);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Student Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StBack_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
