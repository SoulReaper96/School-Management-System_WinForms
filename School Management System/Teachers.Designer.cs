namespace School_Management_System
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            TBack_btn = new Button();
            TDelete_btn = new Button();
            TEdit_btn = new Button();
            TAdd_btn = new Button();
            label7 = new Label();
            TSubjects_cmb = new ComboBox();
            TSurname_tb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            TDOB_dtp = new DateTimePicker();
            label4 = new Label();
            TGender_cmb = new ComboBox();
            TPhone_tb = new TextBox();
            label1 = new Label();
            TName_tb = new TextBox();
            label3 = new Label();
            TAddress_tb = new TextBox();
            label9 = new Label();
            TData_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TData_dgv).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(996, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
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
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 6;
            label2.Text = "Teachers";
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
            label8.Location = new Point(437, 169);
            label8.Name = "label8";
            label8.Size = new Size(123, 22);
            label8.TabIndex = 43;
            label8.Text = "Teachers List";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TBack_btn
            // 
            TBack_btn.ForeColor = Color.Gold;
            TBack_btn.Location = new Point(630, 124);
            TBack_btn.Name = "TBack_btn";
            TBack_btn.Size = new Size(136, 32);
            TBack_btn.TabIndex = 41;
            TBack_btn.Text = "BACK";
            TBack_btn.UseVisualStyleBackColor = true;
            TBack_btn.Click += TBack_btn_Click;
            // 
            // TDelete_btn
            // 
            TDelete_btn.ForeColor = Color.Gold;
            TDelete_btn.Location = new Point(488, 124);
            TDelete_btn.Name = "TDelete_btn";
            TDelete_btn.Size = new Size(136, 32);
            TDelete_btn.TabIndex = 40;
            TDelete_btn.Text = "DELETE";
            TDelete_btn.UseVisualStyleBackColor = true;
            TDelete_btn.Click += TDelete_btn_Click;
            // 
            // TEdit_btn
            // 
            TEdit_btn.ForeColor = Color.Gold;
            TEdit_btn.Location = new Point(346, 124);
            TEdit_btn.Name = "TEdit_btn";
            TEdit_btn.Size = new Size(136, 32);
            TEdit_btn.TabIndex = 39;
            TEdit_btn.Text = "EDIT";
            TEdit_btn.UseVisualStyleBackColor = true;
            TEdit_btn.Click += TEdit_btn_Click;
            // 
            // TAdd_btn
            // 
            TAdd_btn.ForeColor = Color.Gold;
            TAdd_btn.Location = new Point(204, 124);
            TAdd_btn.Name = "TAdd_btn";
            TAdd_btn.Size = new Size(136, 32);
            TAdd_btn.TabIndex = 38;
            TAdd_btn.Text = "ADD";
            TAdd_btn.UseVisualStyleBackColor = true;
            TAdd_btn.Click += TAdd_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(682, 67);
            label7.Name = "label7";
            label7.Size = new Size(101, 22);
            label7.TabIndex = 37;
            label7.Text = "Subject(s):";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TSubjects_cmb
            // 
            TSubjects_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TSubjects_cmb.FormattingEnabled = true;
            TSubjects_cmb.Items.AddRange(new object[] { "Home Language", "First Additional Language", "Maths", "Natural Science", "Arts & Culture" });
            TSubjects_cmb.Location = new Point(682, 92);
            TSubjects_cmb.Name = "TSubjects_cmb";
            TSubjects_cmb.Size = new Size(121, 26);
            TSubjects_cmb.TabIndex = 36;
            // 
            // TSurname_tb
            // 
            TSurname_tb.Location = new Point(158, 92);
            TSurname_tb.Name = "TSurname_tb";
            TSurname_tb.Size = new Size(140, 26);
            TSurname_tb.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gold;
            label6.Location = new Point(158, 67);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 34;
            label6.Text = "Surname:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(420, 67);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 33;
            label5.Text = "Date of Birth:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TDOB_dtp
            // 
            TDOB_dtp.Format = DateTimePickerFormat.Short;
            TDOB_dtp.Location = new Point(420, 92);
            TDOB_dtp.Name = "TDOB_dtp";
            TDOB_dtp.Size = new Size(120, 26);
            TDOB_dtp.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(304, 67);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 31;
            label4.Text = "Gender:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TGender_cmb
            // 
            TGender_cmb.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TGender_cmb.FormattingEnabled = true;
            TGender_cmb.Items.AddRange(new object[] { "Male", "Female" });
            TGender_cmb.Location = new Point(304, 92);
            TGender_cmb.Name = "TGender_cmb";
            TGender_cmb.Size = new Size(110, 26);
            TGender_cmb.TabIndex = 30;
            // 
            // TPhone_tb
            // 
            TPhone_tb.Location = new Point(546, 92);
            TPhone_tb.Name = "TPhone_tb";
            TPhone_tb.Size = new Size(130, 26);
            TPhone_tb.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(546, 67);
            label1.Name = "label1";
            label1.Size = new Size(70, 22);
            label1.TabIndex = 28;
            label1.Text = "Phone:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TName_tb
            // 
            TName_tb.Location = new Point(12, 92);
            TName_tb.Name = "TName_tb";
            TName_tb.Size = new Size(140, 26);
            TName_tb.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 26;
            label3.Text = "Full Name(s):";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TAddress_tb
            // 
            TAddress_tb.Location = new Point(809, 92);
            TAddress_tb.Multiline = true;
            TAddress_tb.Name = "TAddress_tb";
            TAddress_tb.Size = new Size(226, 64);
            TAddress_tb.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(809, 67);
            label9.Name = "label9";
            label9.Size = new Size(87, 22);
            label9.TabIndex = 44;
            label9.Text = "Address:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TData_dgv
            // 
            TData_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TData_dgv.BackgroundColor = Color.WhiteSmoke;
            TData_dgv.BorderStyle = BorderStyle.None;
            TData_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TData_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TData_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            TData_dgv.Location = new Point(12, 194);
            TData_dgv.Name = "TData_dgv";
            TData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TData_dgv.Size = new Size(1023, 465);
            TData_dgv.TabIndex = 46;
            TData_dgv.CellContentClick += TData_dgv_CellContentClick;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 671);
            Controls.Add(TData_dgv);
            Controls.Add(TAddress_tb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TBack_btn);
            Controls.Add(TDelete_btn);
            Controls.Add(TEdit_btn);
            Controls.Add(TAdd_btn);
            Controls.Add(label7);
            Controls.Add(TSubjects_cmb);
            Controls.Add(TSurname_tb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(TDOB_dtp);
            Controls.Add(label4);
            Controls.Add(TGender_cmb);
            Controls.Add(TPhone_tb);
            Controls.Add(label1);
            Controls.Add(TName_tb);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TData_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label8;
        private Button TBack_btn;
        private Button TDelete_btn;
        private Button TEdit_btn;
        private Button TAdd_btn;
        private Label label7;
        private ComboBox TSubjects_cmb;
        private TextBox TSurname_tb;
        private Label label6;
        private Label label5;
        private DateTimePicker TDOB_dtp;
        private Label label4;
        private ComboBox TGender_cmb;
        private TextBox TPhone_tb;
        private Label label1;
        private TextBox TName_tb;
        private Label label3;
        private TextBox TAddress_tb;
        private Label label9;
        private DataGridView TData_dgv;
    }
}