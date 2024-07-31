namespace School_Management_System
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            FeesStId_cmb = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            FeesStName_tb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            FeesDate_dtp = new DateTimePicker();
            label15 = new Label();
            FeesBack_btn = new Button();
            FeesDelete_btn = new Button();
            FeesEdit_btn = new Button();
            FeesAdd_btn = new Button();
            label8 = new Label();
            panel1 = new Panel();
            FeesAmount_tb = new TextBox();
            label1 = new Label();
            FeesStatus_cmb = new ComboBox();
            FeesData_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FeesData_dgv).BeginInit();
            SuspendLayout();
            // 
            // FeesStId_cmb
            // 
            FeesStId_cmb.FormattingEnabled = true;
            FeesStId_cmb.Location = new Point(12, 100);
            FeesStId_cmb.Name = "FeesStId_cmb";
            FeesStId_cmb.Size = new Size(140, 27);
            FeesStId_cmb.TabIndex = 96;
            FeesStId_cmb.SelectionChangeCommitted += FeesStId_cmb_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 6;
            label2.Text = "Fees";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(430, 75);
            label10.Name = "label10";
            label10.Size = new Size(80, 22);
            label10.TabIndex = 95;
            label10.Text = "Amount:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeesStName_tb
            // 
            FeesStName_tb.Location = new Point(158, 101);
            FeesStName_tb.Name = "FeesStName_tb";
            FeesStName_tb.Size = new Size(140, 26);
            FeesStName_tb.TabIndex = 93;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(158, 76);
            label11.Name = "label11";
            label11.Size = new Size(135, 22);
            label11.TabIndex = 92;
            label11.Text = "Student Name:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(304, 76);
            label12.Name = "label12";
            label12.Size = new Size(71, 22);
            label12.TabIndex = 91;
            label12.Text = "Period:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeesDate_dtp
            // 
            FeesDate_dtp.Format = DateTimePickerFormat.Short;
            FeesDate_dtp.Location = new Point(304, 101);
            FeesDate_dtp.Name = "FeesDate_dtp";
            FeesDate_dtp.Size = new Size(120, 26);
            FeesDate_dtp.TabIndex = 90;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Gold;
            label15.Location = new Point(12, 76);
            label15.Name = "label15";
            label15.Size = new Size(105, 22);
            label15.TabIndex = 89;
            label15.Text = "Student ID:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeesBack_btn
            // 
            FeesBack_btn.ForeColor = Color.Gold;
            FeesBack_btn.Location = new Point(630, 133);
            FeesBack_btn.Name = "FeesBack_btn";
            FeesBack_btn.Size = new Size(136, 32);
            FeesBack_btn.TabIndex = 86;
            FeesBack_btn.Text = "BACK";
            FeesBack_btn.UseVisualStyleBackColor = true;
            FeesBack_btn.Click += FeesBack_btn_Click;
            // 
            // FeesDelete_btn
            // 
            FeesDelete_btn.ForeColor = Color.Gold;
            FeesDelete_btn.Location = new Point(488, 133);
            FeesDelete_btn.Name = "FeesDelete_btn";
            FeesDelete_btn.Size = new Size(136, 32);
            FeesDelete_btn.TabIndex = 85;
            FeesDelete_btn.Text = "DELETE";
            FeesDelete_btn.UseVisualStyleBackColor = true;
            FeesDelete_btn.Click += FeesDelete_btn_Click;
            // 
            // FeesEdit_btn
            // 
            FeesEdit_btn.ForeColor = Color.Gold;
            FeesEdit_btn.Location = new Point(346, 133);
            FeesEdit_btn.Name = "FeesEdit_btn";
            FeesEdit_btn.Size = new Size(136, 32);
            FeesEdit_btn.TabIndex = 84;
            FeesEdit_btn.Text = "EDIT";
            FeesEdit_btn.UseVisualStyleBackColor = true;
            FeesEdit_btn.Click += FeesEdit_btn_Click;
            // 
            // FeesAdd_btn
            // 
            FeesAdd_btn.ForeColor = Color.Gold;
            FeesAdd_btn.Location = new Point(204, 133);
            FeesAdd_btn.Name = "FeesAdd_btn";
            FeesAdd_btn.Size = new Size(136, 32);
            FeesAdd_btn.TabIndex = 83;
            FeesAdd_btn.Text = "ADD";
            FeesAdd_btn.UseVisualStyleBackColor = true;
            FeesAdd_btn.Click += FeesAdd_btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(453, 168);
            label8.Name = "label8";
            label8.Size = new Size(89, 22);
            label8.TabIndex = 88;
            label8.Text = "Fees List";
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
            panel1.TabIndex = 82;
            // 
            // FeesAmount_tb
            // 
            FeesAmount_tb.Location = new Point(430, 100);
            FeesAmount_tb.Name = "FeesAmount_tb";
            FeesAmount_tb.Size = new Size(140, 26);
            FeesAmount_tb.TabIndex = 97;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(576, 75);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 99;
            label1.Text = "Status:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeesStatus_cmb
            // 
            FeesStatus_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeesStatus_cmb.FormattingEnabled = true;
            FeesStatus_cmb.Items.AddRange(new object[] { "Paid", "Outstanding", "Half" });
            FeesStatus_cmb.Location = new Point(576, 100);
            FeesStatus_cmb.Name = "FeesStatus_cmb";
            FeesStatus_cmb.Size = new Size(121, 26);
            FeesStatus_cmb.TabIndex = 98;
            // 
            // FeesData_dgv
            // 
            FeesData_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FeesData_dgv.BackgroundColor = Color.WhiteSmoke;
            FeesData_dgv.BorderStyle = BorderStyle.None;
            FeesData_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            FeesData_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FeesData_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            FeesData_dgv.Location = new Point(12, 194);
            FeesData_dgv.Name = "FeesData_dgv";
            FeesData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FeesData_dgv.Size = new Size(1023, 465);
            FeesData_dgv.TabIndex = 100;
            FeesData_dgv.CellContentClick += FeesData_dgv_CellContentClick;
            // 
            // Fees
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 671);
            Controls.Add(FeesData_dgv);
            Controls.Add(label1);
            Controls.Add(FeesStatus_cmb);
            Controls.Add(FeesAmount_tb);
            Controls.Add(FeesStId_cmb);
            Controls.Add(label10);
            Controls.Add(FeesStName_tb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(FeesDate_dtp);
            Controls.Add(label15);
            Controls.Add(FeesBack_btn);
            Controls.Add(FeesDelete_btn);
            Controls.Add(FeesEdit_btn);
            Controls.Add(FeesAdd_btn);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FeesData_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox FeesStId_cmb;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private TextBox FeesStName_tb;
        private Label label11;
        private Label label12;
        private DateTimePicker FeesDate_dtp;
        private Label label15;
        private Button FeesBack_btn;
        private Button FeesDelete_btn;
        private Button FeesEdit_btn;
        private Button FeesAdd_btn;
        private Label label8;
        private Panel panel1;
        private TextBox FeesAmount_tb;
        private Label label1;
        private ComboBox FeesStatus_cmb;
        private DataGridView FeesData_dgv;
    }
}