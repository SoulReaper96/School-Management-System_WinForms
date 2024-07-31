namespace School_Management_System
{
    public partial class Loading : Form
    {
        private int Startpoint = 0;

        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            Startpoint += 1;
            Loading_pbar.Value = Startpoint;
            LoadPercentage_lbl.Text = Startpoint + "%";
            if (Loading_pbar.Value == 100)
            {
                Loading_pbar.Value = 0;
                LoadingTimer.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

    }
}
