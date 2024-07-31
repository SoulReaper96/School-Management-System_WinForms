using System.Data;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Teachers : Form
    {
        SqlConnection tcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");
        public int Tkey = 0;

        public Teachers()
        {
            InitializeComponent();
            DisplayTeacher();
        }

        private void DisplayTeacher()
        {
            tcon.Open();
            string query = "SELECT * FROM TeacherTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, tcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TData_dgv.DataSource = ds.Tables[0];
            tcon.Close();
        }

        private void Reset()
        {
            Tkey = 0;
            TName_tb.Text = "";
            TSurname_tb.Text = "";
            TPhone_tb.Text = "";
            TAddress_tb.Text = "";
            TGender_cmb.SelectedIndex = 0;
            TSubjects_cmb.SelectedIndex = 0;
            TDOB_dtp.Value = DateTime.Now;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TData_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TData_dgv.SelectedRows.Count > 0) // Check if there are selected rows
            {
                DataGridViewRow selectedRow = TData_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 8) // Check if there are enough cells in the row
                {
                    TName_tb.Text = selectedRow.Cells[1].Value?.ToString() ?? ""; // Use null-conditional operator to avoid null reference exception
                    Tkey = selectedRow.Cells[0].Value == null ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
                    TSurname_tb.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    TGender_cmb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    TDOB_dtp.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    TPhone_tb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
                    TSubjects_cmb.Text = selectedRow.Cells[6].Value?.ToString() ?? "";
                    TAddress_tb.Text = selectedRow.Cells[7].Value?.ToString() ?? "";
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

        private void TAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TName_tb.Text) || string.IsNullOrEmpty(TSurname_tb.Text) || string.IsNullOrEmpty(TPhone_tb.Text) || string.IsNullOrEmpty(TAddress_tb.Text) || TGender_cmb.SelectedIndex == -1 || TSubjects_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tcon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TeacherTable(TName, TSurname, TGender, TDob, TSubjects, TPhone, TAddress) VALUES (@Tname, @Tsurname, @Tgender, @Tdob, @Tsubjects, @Tphone, @Taddress)", tcon);
                    cmd.Parameters.AddWithValue("@Tname", TName_tb.Text);
                    cmd.Parameters.AddWithValue("@Tsurname", TSurname_tb.Text);
                    cmd.Parameters.AddWithValue("@Tgender", TGender_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tdob", TDOB_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@Tphone", TPhone_tb.Text);
                    cmd.Parameters.AddWithValue("@Tsubjects", TSubjects_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Taddress", TAddress_tb.Text);
                    cmd.ExecuteNonQuery();
                    tcon.Close();
                    MessageBox.Show("Teacher Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacher();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TName_tb.Text) || string.IsNullOrEmpty(TSurname_tb.Text) || string.IsNullOrEmpty(TPhone_tb.Text) || string.IsNullOrEmpty(TAddress_tb.Text) || TGender_cmb.SelectedIndex == -1 || TSubjects_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tcon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TeacherTable SET TName = @Tname, TSurname = @Tsurname, TGender = @Tgender, TDob = @Tdob, Tsubjects = @Tsubjects, Tphone = @Tphone, TAddress = @Taddress where TId = @TeachID", tcon);
                    cmd.Parameters.AddWithValue("@Tname", TName_tb.Text);
                    cmd.Parameters.AddWithValue("@Tsurname", TSurname_tb.Text);
                    cmd.Parameters.AddWithValue("@Tgender", TGender_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Tdob", TDOB_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@Tphone", TPhone_tb.Text);
                    cmd.Parameters.AddWithValue("@Tsubjects", TSubjects_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Taddress", TAddress_tb.Text);
                    cmd.Parameters.AddWithValue("@TeachID", Tkey);
                    cmd.ExecuteNonQuery();
                    tcon.Close();
                    MessageBox.Show("Student Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacher();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TDelete_btn_Click(object sender, EventArgs e)
        {
            if (Tkey == 0)
            {
                MessageBox.Show("Select A Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tcon.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM TeacherTable WHERE TId = @Tkey", tcon);
                    cmd.Parameters.AddWithValue("@Tkey", Tkey);
                    cmd.ExecuteNonQuery();
                    tcon.Close();
                    MessageBox.Show("Teacher Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayTeacher();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TBack_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
