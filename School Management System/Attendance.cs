using System.Data;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Attendance : Form
    {
        SqlConnection Acon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");
        public int ANum = 0;

        public Attendance()
        {
            InitializeComponent();
            FillStudID();
            DisplayAttendance();
        }

        private void FillStudID()
        {
            Acon.Open();
            SqlCommand cmd = new SqlCommand("SELECT StId FROM StudentTable", Acon);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(reader);
            AttStId_cmb.ValueMember = "StId";
            AttStId_cmb.DataSource = dt;
            cmd.ExecuteNonQuery();
            Acon.Close();
            MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetStudName()
        {
            try
            {
                Acon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable where StId = @SID", Acon);
                cmd.Parameters.AddWithValue("@SID", AttStId_cmb.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    AttStName_tb.Text = dr["StName"].ToString();
                }
                Acon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayAttendance()
        {
            Acon.Open();
            string query = "SELECT * FROM AttendanceTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Acon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttData_dgv.DataSource = ds.Tables[0];
            Acon.Close();
        }

        private void Reset()
        {
            AttStId_cmb.SelectedIndex = 0;
            AttStName_tb.Text = "";
            AttStatus_cmb.SelectedIndex = 0;
        }

        private void AttData_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AttData_dgv.SelectedRows.Count > 0) // Check if there are selected rows
            {
                DataGridViewRow selectedRow = AttData_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 5) // Check if there are enough cells in the row
                {
                    AttStId_cmb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    ANum = selectedRow.Cells[0].Value == null ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
                    AttStName_tb.Text = selectedRow.Cells[2].Value?.ToString() ?? ""; // Use null-conditional operator to avoid null reference exception
                    AttDate_dtp.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    AttStatus_cmb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
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

        private void AttAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AttStName_tb.Text) || AttStatus_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Acon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO AttendanceTable(AttStId, AttStName, AttDate, AttStatus) VALUES (@StId, @Stname, @AttDate, @AttStatus)", Acon);
                    cmd.Parameters.AddWithValue("@StId", AttStId_cmb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", AttStName_tb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDate_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@AttStatus", AttStatus_cmb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    Acon.Close();
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AttEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AttStName_tb.Text) || AttStatus_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Acon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AttendanceTable SET AttStId = @StId, AttStName = @StName, AttDate = @AttDate, AttStatus = @AttStatus where AttNum = @ANum", Acon);
                    cmd.Parameters.AddWithValue("@StId", AttStId_cmb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", AttStName_tb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDate_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@AttStatus", AttStatus_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", ANum);
                    cmd.ExecuteNonQuery();
                    Acon.Close();
                    MessageBox.Show("Record Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AttDelete_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AttBack_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void AttStId_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }
    }
}
