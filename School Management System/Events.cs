using System.Data;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Events : Form
    {
        SqlConnection econ = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\Documents\School_db.mdf;Integrated Security=True;Connect Timeout=30");
        public int Evkey = 0;

        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }

        private void Reset()
        {
            EventName_tb.Text = "";
            EventDuration_tb.Text = "";
        }

        private void DisplayEvents()
        {
            econ.Open();
            string query = "SELECT * FROM EventsTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, econ);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EvntData_dgv.DataSource = ds.Tables[0];
            econ.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EvBack_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void EvDelete_btn_Click(object sender, EventArgs e)
        {
            if (Evkey == 0)
            {
                MessageBox.Show("Select An Event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    econ.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM EventsTable WHERE EventID = @EventID", econ);
                    cmd.Parameters.AddWithValue("@EventID", Evkey);
                    cmd.ExecuteNonQuery();
                    econ.Close();
                    MessageBox.Show("Event Removed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EvntData_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EvntData_dgv.SelectedRows.Count > 0) // Check if there are selected rows
            {
                DataGridViewRow selectedRow = EvntData_dgv.SelectedRows[0];

                if (selectedRow.Cells.Count >= 4) // Check if there are enough cells in the row
                {
                    EventName_tb.Text = selectedRow.Cells[1].Value?.ToString() ?? ""; // Use null-conditional operator to avoid null reference exception
                    Evkey = selectedRow.Cells[0].Value == null ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value);
                    EventDate_dtp.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                    EventDuration_tb.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
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

        private void EvAdd_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EventName_tb.Text) || string.IsNullOrEmpty(EventDuration_tb.Text))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    econ.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO EventsTable(EventName, EventDate, EventDuration) VALUES (@EventName, @EventDate, @EventDuration)", econ);
                    cmd.Parameters.AddWithValue("@EventName", EventName_tb.Text);
                    cmd.Parameters.AddWithValue("@EventDate", EventDate_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@EventDuration", EventDuration_tb.Text);
                    cmd.ExecuteNonQuery();
                    econ.Close();
                    MessageBox.Show("Event Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EvEdit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EventName_tb.Text) || string.IsNullOrEmpty(EventDuration_tb.Text))
            {
                MessageBox.Show("Missing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    econ.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE EventsTable SET EventName = @Eventname, EventDate = @EventDate, EventDuration = @EventDuration where EventID = @EventID", econ);
                    cmd.Parameters.AddWithValue("@EventName", EventName_tb.Text);
                    cmd.Parameters.AddWithValue("@EventDate", EventDate_dtp.Value.Date);
                    cmd.Parameters.AddWithValue("@EventDuration", EventDuration_tb.Text);
                    cmd.Parameters.AddWithValue("@EventID", Evkey);
                    cmd.ExecuteNonQuery();
                    econ.Close();
                    MessageBox.Show("Events Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayEvents();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
