namespace School_Management_System
{
    partial class Loading
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Loading_pbar = new ProgressBar();
            label2 = new Label();
            LoadPercentage_lbl = new Label();
            LoadingTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(168, 21);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 0;
            label1.Text = "My High School";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Loading_pbar
            // 
            Loading_pbar.Location = new Point(12, 280);
            Loading_pbar.Name = "Loading_pbar";
            Loading_pbar.Size = new Size(589, 17);
            Loading_pbar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(12, 248);
            label2.Name = "label2";
            label2.Size = new Size(221, 29);
            label2.TabIndex = 3;
            label2.Text = "Loading Modules:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadPercentage_lbl
            // 
            LoadPercentage_lbl.AutoSize = true;
            LoadPercentage_lbl.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadPercentage_lbl.ForeColor = Color.Blue;
            LoadPercentage_lbl.Location = new Point(239, 248);
            LoadPercentage_lbl.Name = "LoadPercentage_lbl";
            LoadPercentage_lbl.Size = new Size(44, 29);
            LoadPercentage_lbl.TabIndex = 4;
            LoadPercentage_lbl.Text = "0%";
            LoadPercentage_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoadingTimer
            // 
            LoadingTimer.Tick += LoadingTimer_Tick;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(613, 309);
            Controls.Add(LoadPercentage_lbl);
            Controls.Add(label2);
            Controls.Add(Loading_pbar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ProgressBar Loading_pbar;
        private Label label2;
        private Label LoadPercentage_lbl;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}
