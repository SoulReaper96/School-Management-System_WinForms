namespace School_Management_System
{
    partial class Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label10 = new Label();
            AttStatus_cmb = new ComboBox();
            AttStName_tb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            AttDate_dtp = new DateTimePicker();
            label15 = new Label();
            AttBack_btn = new Button();
            AttDelete_btn = new Button();
            AttEdit_btn = new Button();
            AttAdd_btn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            panel1 = new Panel();
            AttStId_cmb = new ComboBox();
            AttData_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttData_dgv).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(430, 72);
            label10.Name = "label10";
            label10.Size = new Size(68, 22);
            label10.TabIndex = 78;
            label10.Text = "Status:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AttStatus_cmb
            // 
            AttStatus_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AttStatus_cmb.FormattingEnabled = true;
            AttStatus_cmb.Items.AddRange(new object[] { "Present", "Absent" });
            AttStatus_cmb.Location = new Point(430, 97);
            AttStatus_cmb.Name = "AttStatus_cmb";
            AttStatus_cmb.Size = new Size(121, 26);
            AttStatus_cmb.TabIndex = 77;
            // 
            // AttStName_tb
            // 
            AttStName_tb.Enabled = false;
            AttStName_tb.Location = new Point(158, 98);
            AttStName_tb.Name = "AttStName_tb";
            AttStName_tb.Size = new Size(140, 26);
            AttStName_tb.TabIndex = 76;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(158, 73);
            label11.Name = "label11";
            label11.Size = new Size(135, 22);
            label11.TabIndex = 75;
            label11.Text = "Student Name:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(304, 73);
            label12.Name = "label12";
            label12.Size = new Size(55, 22);
            label12.TabIndex = 74;
            label12.Text = "Date:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AttDate_dtp
            // 
            AttDate_dtp.Format = DateTimePickerFormat.Short;
            AttDate_dtp.Location = new Point(304, 98);
            AttDate_dtp.Name = "AttDate_dtp";
            AttDate_dtp.Size = new Size(120, 26);
            AttDate_dtp.TabIndex = 73;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gold;
            label15.Location = new Point(12, 73);
            label15.Name = "label15";
            label15.Size = new Size(105, 22);
            label15.TabIndex = 67;
            label15.Text = "Student ID:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AttBack_btn
            // 
            AttBack_btn.ForeColor = Color.Gold;
            AttBack_btn.Location = new Point(630, 130);
            AttBack_btn.Name = "AttBack_btn";
            AttBack_btn.Size = new Size(136, 32);
            AttBack_btn.TabIndex = 64;
            AttBack_btn.Text = "BACK";
            AttBack_btn.UseVisualStyleBackColor = true;
            AttBack_btn.Click += AttBack_btn_Click;
            // 
            // AttDelete_btn
            // 
            AttDelete_btn.ForeColor = Color.Gold;
            AttDelete_btn.Location = new Point(488, 130);
            AttDelete_btn.Name = "AttDelete_btn";
            AttDelete_btn.Size = new Size(136, 32);
            AttDelete_btn.TabIndex = 63;
            AttDelete_btn.Text = "DELETE";
            AttDelete_btn.UseVisualStyleBackColor = true;
            AttDelete_btn.Click += AttDelete_btn_Click;
            // 
            // AttEdit_btn
            // 
            AttEdit_btn.ForeColor = Color.Gold;
            AttEdit_btn.Location = new Point(346, 130);
            AttEdit_btn.Name = "AttEdit_btn";
            AttEdit_btn.Size = new Size(136, 32);
            AttEdit_btn.TabIndex = 62;
            AttEdit_btn.Text = "EDIT";
            AttEdit_btn.UseVisualStyleBackColor = true;
            AttEdit_btn.Click += AttEdit_btn_Click;
            // 
            // AttAdd_btn
            // 
            AttAdd_btn.ForeColor = Color.Gold;
            AttAdd_btn.Location = new Point(204, 130);
            AttAdd_btn.Name = "AttAdd_btn";
            AttAdd_btn.Size = new Size(136, 32);
            AttAdd_btn.TabIndex = 61;
            AttAdd_btn.Text = "ADD";
            AttAdd_btn.UseVisualStyleBackColor = true;
            AttAdd_btn.Click += AttAdd_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 6;
            label2.Text = "Attendance";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1003, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(430, 169);
            label8.Name = "label8";
            label8.Size = new Size(141, 22);
            label8.TabIndex = 66;
            label8.Text = "Attendance List";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 55);
            panel1.TabIndex = 60;
            // 
            // AttStId_cmb
            // 
            AttStId_cmb.FormattingEnabled = true;
            AttStId_cmb.Location = new Point(12, 97);
            AttStId_cmb.Name = "AttStId_cmb";
            AttStId_cmb.Size = new Size(140, 27);
            AttStId_cmb.TabIndex = 81;
            AttStId_cmb.SelectionChangeCommitted += AttStId_cmb_SelectionChangeCommitted;
            // 
            // AttData_dgv
            // 
            AttData_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttData_dgv.BackgroundColor = Color.WhiteSmoke;
            AttData_dgv.BorderStyle = BorderStyle.None;
            AttData_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AttData_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttData_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            AttData_dgv.Location = new Point(12, 194);
            AttData_dgv.Name = "AttData_dgv";
            AttData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AttData_dgv.Size = new Size(1023, 465);
            AttData_dgv.TabIndex = 82;
            AttData_dgv.CellContentClick += AttData_dgv_CellContentClick;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 671);
            Controls.Add(AttData_dgv);
            Controls.Add(AttStId_cmb);
            Controls.Add(label10);
            Controls.Add(AttStatus_cmb);
            Controls.Add(AttStName_tb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(AttDate_dtp);
            Controls.Add(label15);
            Controls.Add(AttBack_btn);
            Controls.Add(AttDelete_btn);
            Controls.Add(AttEdit_btn);
            Controls.Add(AttAdd_btn);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Attendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttData_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private ComboBox AttStatus_cmb;
        private TextBox AttStName_tb;
        private Label label11;
        private Label label12;
        private DateTimePicker AttDate_dtp;
        private Label label15;
        private Button AttBack_btn;
        private Button AttDelete_btn;
        private Button AttEdit_btn;
        private Button AttAdd_btn;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label8;
        private Panel panel1;
        private ComboBox AttStId_cmb;
        private DataGridView AttData_dgv;
    }
}