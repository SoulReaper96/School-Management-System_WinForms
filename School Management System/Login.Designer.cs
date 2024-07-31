namespace School_Management_System
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UsrName_tb = new TextBox();
            Password_tb = new TextBox();
            Login_btn = new Button();
            Reset_lbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 57);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(570, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 1;
            label1.Text = "My High School";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(48, 267);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 32);
            panel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(328, 81);
            label2.Name = "label2";
            label2.Size = new Size(162, 29);
            label2.TabIndex = 4;
            label2.Text = "USER LOGIN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(246, 146);
            label3.Name = "label3";
            label3.Size = new Size(102, 22);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(247, 196);
            label4.Name = "label4";
            label4.Size = new Size(99, 22);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsrName_tb
            // 
            UsrName_tb.Location = new Point(354, 146);
            UsrName_tb.Name = "UsrName_tb";
            UsrName_tb.Size = new Size(186, 26);
            UsrName_tb.TabIndex = 7;
            // 
            // Password_tb
            // 
            Password_tb.Location = new Point(354, 196);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(186, 26);
            Password_tb.TabIndex = 8;
            // 
            // Login_btn
            // 
            Login_btn.ForeColor = Color.Gold;
            Login_btn.Location = new Point(354, 267);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(136, 32);
            Login_btn.TabIndex = 9;
            Login_btn.Text = "LOGIN";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // Reset_lbl
            // 
            Reset_lbl.AutoSize = true;
            Reset_lbl.Font = new Font("Arial", 13F, FontStyle.Underline);
            Reset_lbl.ForeColor = Color.Gold;
            Reset_lbl.Location = new Point(394, 302);
            Reset_lbl.Name = "Reset_lbl";
            Reset_lbl.Size = new Size(57, 21);
            Reset_lbl.TabIndex = 10;
            Reset_lbl.Text = "Reset";
            Reset_lbl.TextAlign = ContentAlignment.MiddleCenter;
            Reset_lbl.Click += Reset_lbl_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(614, 342);
            Controls.Add(Reset_lbl);
            Controls.Add(Login_btn);
            Controls.Add(Password_tb);
            Controls.Add(UsrName_tb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UsrName_tb;
        private TextBox Password_tb;
        private Button Login_btn;
        private Label Reset_lbl;
        private PictureBox pictureBox2;
    }
}