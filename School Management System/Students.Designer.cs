namespace School_Management_System
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            StAdd_btn = new Button();
            StEdit_btn = new Button();
            StDelete_btn = new Button();
            StBack_btn = new Button();
            StData_dgv = new DataGridView();
            label8 = new Label();
            StAddress_tb = new TextBox();
            label9 = new Label();
            label10 = new Label();
            StClass_cmb = new ComboBox();
            StSurname_tb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            StDOB_dtp = new DateTimePicker();
            label13 = new Label();
            StGender_cmb = new ComboBox();
            StFees_tb = new TextBox();
            label14 = new Label();
            StName_tb = new TextBox();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StData_dgv).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 6;
            label2.Text = "Students";
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
            // StAdd_btn
            // 
            StAdd_btn.ForeColor = Color.Gold;
            StAdd_btn.Location = new Point(204, 124);
            StAdd_btn.Name = "StAdd_btn";
            StAdd_btn.Size = new Size(136, 32);
            StAdd_btn.TabIndex = 20;
            StAdd_btn.Text = "ADD";
            StAdd_btn.UseVisualStyleBackColor = true;
            StAdd_btn.Click += StAdd_btn_Click;
            // 
            // StEdit_btn
            // 
            StEdit_btn.ForeColor = Color.Gold;
            StEdit_btn.Location = new Point(346, 124);
            StEdit_btn.Name = "StEdit_btn";
            StEdit_btn.Size = new Size(136, 32);
            StEdit_btn.TabIndex = 21;
            StEdit_btn.Text = "EDIT";
            StEdit_btn.UseVisualStyleBackColor = true;
            StEdit_btn.Click += StEdit_btn_Click;
            // 
            // StDelete_btn
            // 
            StDelete_btn.ForeColor = Color.Gold;
            StDelete_btn.Location = new Point(488, 124);
            StDelete_btn.Name = "StDelete_btn";
            StDelete_btn.Size = new Size(136, 32);
            StDelete_btn.TabIndex = 22;
            StDelete_btn.Text = "DELETE";
            StDelete_btn.UseVisualStyleBackColor = true;
            StDelete_btn.Click += StDelete_btn_Click;
            // 
            // StBack_btn
            // 
            StBack_btn.ForeColor = Color.Gold;
            StBack_btn.Location = new Point(630, 124);
            StBack_btn.Name = "StBack_btn";
            StBack_btn.Size = new Size(136, 32);
            StBack_btn.TabIndex = 23;
            StBack_btn.Text = "BACK";
            StBack_btn.UseVisualStyleBackColor = true;
            StBack_btn.Click += StBack_btn_Click;
            // 
            // StData_dgv
            // 
            StData_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StData_dgv.BackgroundColor = Color.WhiteSmoke;
            StData_dgv.BorderStyle = BorderStyle.None;
            StData_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            StData_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StData_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            StData_dgv.Location = new Point(12, 194);
            StData_dgv.Name = "StData_dgv";
            StData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StData_dgv.Size = new Size(1023, 465);
            StData_dgv.TabIndex = 24;
            StData_dgv.CellContentClick += StData_dgv_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(437, 169);
            label8.Name = "label8";
            label8.Size = new Size(110, 22);
            label8.TabIndex = 25;
            label8.Text = "Student List";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StAddress_tb
            // 
            StAddress_tb.Location = new Point(809, 92);
            StAddress_tb.Multiline = true;
            StAddress_tb.Name = "StAddress_tb";
            StAddress_tb.Size = new Size(226, 64);
            StAddress_tb.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(809, 67);
            label9.Name = "label9";
            label9.Size = new Size(87, 22);
            label9.TabIndex = 58;
            label9.Text = "Address:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(546, 67);
            label10.Name = "label10";
            label10.Size = new Size(63, 22);
            label10.TabIndex = 57;
            label10.Text = "Class:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StClass_cmb
            // 
            StClass_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StClass_cmb.FormattingEnabled = true;
            StClass_cmb.Items.AddRange(new object[] { "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th" });
            StClass_cmb.Location = new Point(546, 92);
            StClass_cmb.Name = "StClass_cmb";
            StClass_cmb.Size = new Size(121, 26);
            StClass_cmb.TabIndex = 56;
            // 
            // StSurname_tb
            // 
            StSurname_tb.Location = new Point(158, 92);
            StSurname_tb.Name = "StSurname_tb";
            StSurname_tb.Size = new Size(140, 26);
            StSurname_tb.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(158, 67);
            label11.Name = "label11";
            label11.Size = new Size(91, 22);
            label11.TabIndex = 54;
            label11.Text = "Surname:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(420, 67);
            label12.Name = "label12";
            label12.Size = new Size(120, 22);
            label12.TabIndex = 53;
            label12.Text = "Date of Birth:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StDOB_dtp
            // 
            StDOB_dtp.Format = DateTimePickerFormat.Short;
            StDOB_dtp.Location = new Point(420, 92);
            StDOB_dtp.Name = "StDOB_dtp";
            StDOB_dtp.Size = new Size(120, 26);
            StDOB_dtp.TabIndex = 52;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Gold;
            label13.Location = new Point(304, 67);
            label13.Name = "label13";
            label13.Size = new Size(79, 22);
            label13.TabIndex = 51;
            label13.Text = "Gender:";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StGender_cmb
            // 
            StGender_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StGender_cmb.FormattingEnabled = true;
            StGender_cmb.Items.AddRange(new object[] { "Male", "Female" });
            StGender_cmb.Location = new Point(304, 92);
            StGender_cmb.Name = "StGender_cmb";
            StGender_cmb.Size = new Size(110, 26);
            StGender_cmb.TabIndex = 50;
            // 
            // StFees_tb
            // 
            StFees_tb.Location = new Point(673, 92);
            StFees_tb.Name = "StFees_tb";
            StFees_tb.Size = new Size(130, 26);
            StFees_tb.TabIndex = 49;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Gold;
            label14.Location = new Point(673, 67);
            label14.Name = "label14";
            label14.Size = new Size(59, 22);
            label14.TabIndex = 48;
            label14.Text = "Fees:";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StName_tb
            // 
            StName_tb.Location = new Point(12, 92);
            StName_tb.Name = "StName_tb";
            StName_tb.Size = new Size(140, 26);
            StName_tb.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gold;
            label15.Location = new Point(12, 67);
            label15.Name = "label15";
            label15.Size = new Size(122, 22);
            label15.TabIndex = 46;
            label15.Text = "Full Name(s):";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 671);
            Controls.Add(StAddress_tb);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(StClass_cmb);
            Controls.Add(StSurname_tb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(StDOB_dtp);
            Controls.Add(label13);
            Controls.Add(StGender_cmb);
            Controls.Add(StFees_tb);
            Controls.Add(label14);
            Controls.Add(StName_tb);
            Controls.Add(label15);
            Controls.Add(label8);
            Controls.Add(StData_dgv);
            Controls.Add(StBack_btn);
            Controls.Add(StDelete_btn);
            Controls.Add(StEdit_btn);
            Controls.Add(StAdd_btn);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Students";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StData_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button StAdd_btn;
        private Button StEdit_btn;
        private Button StDelete_btn;
        private Button StBack_btn;
        private DataGridView StData_dgv;
        private Label label8;
        private TextBox StAddress_tb;
        private Label label9;
        private Label label10;
        private ComboBox StClass_cmb;
        private TextBox StSurname_tb;
        private Label label11;
        private Label label12;
        private DateTimePicker StDOB_dtp;
        private Label label13;
        private ComboBox StGender_cmb;
        private TextBox StFees_tb;
        private Label label14;
        private TextBox StName_tb;
        private Label label15;
    }
}