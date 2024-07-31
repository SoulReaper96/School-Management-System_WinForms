using System.Data;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Fees : Form
    {
        SqlConnection fcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");
        public int Feeskey = 0;

        public Fees()
        {
            InitializeComponent();
            FillStudID();
            DisplayFees();
        }

        private void FillStudID()
        {
            fcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT StId FROM StudentTable", fcon);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(reader);
            FeesStId_cmb.ValueMember = "StId";
            FeesStId_cmb.DataSource = dt;
            cmd.ExecuteNonQuery();
            fcon.Close();
            MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetStudName()
        {
            try
            {
                fcon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTable where StId = @SID", fcon);
                cmd.Parameters.AddWithValue("@SID", FeesStId_cmb.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    FeesStName_tb.Text = dr["StName"].ToString();
                }
                fcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            FeesStName_tb.Text = "";
            FeesAmount_tb.Text = "";
            FeesStId_cmb.SelectedIndex = 0;
            FeesDate_dtp.Value = DateTime.Now;
            FeesStatus_cmb.SelectedIndex = 0;
        }

        private void DisplayFees()
        {
            fcon.Open();
            string query = "SELECT * FROM FeesTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, fcon);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesData_dgv.DataSource = ds.Tables[0];
            fcon.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FeesBack_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void FeesDelete_btn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FeesData_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FeesData_dgv.SelectedRows.Count > 0) // Check if there are selected rows
            {
                DataGridViewRow selectedRow = FeesData_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 6) // Check if there are enough cells in the row
                {
                    FeesStId_cmb.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                    Feeskey = selectedRow.Cells[0].Value == null ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
                    FeesStName_tb.Text = selectedRow.Cells[2].Value?.ToString() ?? ""; // Use null-conditional operator to avoid null reference exception
                    FeesDate_dtp.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
                    FeesAmount_tb.Text = selectedRow.Cells[4].Value?.ToString() ?? "";
                    FeesStatus_cmb.Text = selectedRow.Cells[5].Value?.ToString() ?? "";
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

        private void FeesAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FeesStName_tb.Text) || string.IsNullOrEmpty(FeesAmount_tb.Text) || FeesStatus_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*
                string PaymentPeriod;
                PaymentPeriod = FeesDate_dtp.Value.Month.ToString("yyyy-MM-dd") + FeesDate_dtp.Value.Year.ToString("yyyy-MM-dd");
                fcon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from FeesTable where StId = " + FeesStId_cmb.SelectedValue.ToString() + " and Month = '" + PaymentPeriod.ToString() + "'", fcon);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Student Already Paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //fcon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO FeesTable(StId, StName, Month, Amount, Status) VALUES (@StId, @Stname, @Month, @Amount, @Status)", fcon);
                    cmd.Parameters.AddWithValue("@StId", FeesStId_cmb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", FeesStName_tb.Text);
                    cmd.Parameters.AddWithValue("@Month", FeesDate_dtp.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Amount", FeesAmount_tb.Text);
                    cmd.Parameters.AddWithValue("@Status", FeesStatus_cmb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayFees();
                    Reset();
                }
                fcon.Close();
                */
                
                try
                {
                    fcon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO FeesTable(StId, StName, Month, Amount, Status) VALUES (@StId, @Stname, @Month, @Amount, @Status)", fcon);
                    cmd.Parameters.AddWithValue("@StId", FeesStId_cmb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", FeesStName_tb.Text);
                    cmd.Parameters.AddWithValue("@Month", FeesDate_dtp.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Amount", FeesAmount_tb.Text);
                    cmd.Parameters.AddWithValue("@Status", FeesStatus_cmb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    fcon.Close();
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayFees();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void FeesEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FeesStName_tb.Text) || string.IsNullOrEmpty(FeesAmount_tb.Text) || FeesStatus_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    fcon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE FeesTable SET FeesStId = @StId, StName = @StName, Month = @Month, Amount = @Amount, Status = @Status where PayID = @PayId", fcon);
                    cmd.Parameters.AddWithValue("@StId", FeesStId_cmb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", FeesStName_tb.Text);
                    cmd.Parameters.AddWithValue("@Month", FeesDate_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@Amount", FeesAmount_tb.Text);
                    cmd.Parameters.AddWithValue("@Status", FeesStatus_cmb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PayId", Feeskey);
                    cmd.ExecuteNonQuery();
                    fcon.Close();
                    MessageBox.Show("Record Edited Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayFees();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FeesStId_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }
    }
}
