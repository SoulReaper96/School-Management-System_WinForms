namespace School_Management_System
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            EventDuration_tb = new TextBox();
            label10 = new Label();
            EventName_tb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            EventDate_dtp = new DateTimePicker();
            pictureBox2 = new PictureBox();
            EvBack_btn = new Button();
            EvDelete_btn = new Button();
            EvEdit_btn = new Button();
            EvAdd_btn = new Button();
            label8 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            EvntData_dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EvntData_dgv).BeginInit();
            SuspendLayout();
            // 
            // EventDuration_tb
            // 
            EventDuration_tb.Location = new Point(342, 101);
            EventDuration_tb.Name = "EventDuration_tb";
            EventDuration_tb.Size = new Size(159, 26);
            EventDuration_tb.TabIndex = 114;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(342, 76);
            label10.Name = "label10";
            label10.Size = new Size(159, 22);
            label10.TabIndex = 112;
            label10.Text = "Duration in Hours:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventName_tb
            // 
            EventName_tb.Location = new Point(12, 101);
            EventName_tb.Name = "EventName_tb";
            EventName_tb.Size = new Size(198, 26);
            EventName_tb.TabIndex = 111;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Gold;
            label11.Location = new Point(12, 76);
            label11.Name = "label11";
            label11.Size = new Size(63, 22);
            label11.TabIndex = 110;
            label11.Text = "Event:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Gold;
            label12.Location = new Point(216, 76);
            label12.Name = "label12";
            label12.Size = new Size(55, 22);
            label12.TabIndex = 109;
            label12.Text = "Date:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventDate_dtp
            // 
            EventDate_dtp.Format = DateTimePickerFormat.Short;
            EventDate_dtp.Location = new Point(216, 101);
            EventDate_dtp.Name = "EventDate_dtp";
            EventDate_dtp.Size = new Size(120, 26);
            EventDate_dtp.TabIndex = 108;
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
            // EvBack_btn
            // 
            EvBack_btn.ForeColor = Color.Gold;
            EvBack_btn.Location = new Point(630, 134);
            EvBack_btn.Name = "EvBack_btn";
            EvBack_btn.Size = new Size(136, 32);
            EvBack_btn.TabIndex = 104;
            EvBack_btn.Text = "BACK";
            EvBack_btn.UseVisualStyleBackColor = true;
            EvBack_btn.Click += EvBack_btn_Click;
            // 
            // EvDelete_btn
            // 
            EvDelete_btn.ForeColor = Color.Gold;
            EvDelete_btn.Location = new Point(488, 134);
            EvDelete_btn.Name = "EvDelete_btn";
            EvDelete_btn.Size = new Size(136, 32);
            EvDelete_btn.TabIndex = 103;
            EvDelete_btn.Text = "DELETE";
            EvDelete_btn.UseVisualStyleBackColor = true;
            EvDelete_btn.Click += EvDelete_btn_Click;
            // 
            // EvEdit_btn
            // 
            EvEdit_btn.ForeColor = Color.Gold;
            EvEdit_btn.Location = new Point(346, 134);
            EvEdit_btn.Name = "EvEdit_btn";
            EvEdit_btn.Size = new Size(136, 32);
            EvEdit_btn.TabIndex = 102;
            EvEdit_btn.Text = "EDIT";
            EvEdit_btn.UseVisualStyleBackColor = true;
            EvEdit_btn.Click += EvEdit_btn_Click;
            // 
            // EvAdd_btn
            // 
            EvAdd_btn.ForeColor = Color.Gold;
            EvAdd_btn.Location = new Point(204, 134);
            EvAdd_btn.Name = "EvAdd_btn";
            EvAdd_btn.Size = new Size(136, 32);
            EvAdd_btn.TabIndex = 101;
            EvAdd_btn.Text = "ADD";
            EvAdd_btn.UseVisualStyleBackColor = true;
            EvAdd_btn.Click += EvAdd_btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(441, 169);
            label8.Name = "label8";
            label8.Size = new Size(103, 22);
            label8.TabIndex = 106;
            label8.Text = "Events List";
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
            panel1.TabIndex = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 12);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 6;
            label2.Text = "Events";
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
            // EvntData_dgv
            // 
            EvntData_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EvntData_dgv.BackgroundColor = Color.WhiteSmoke;
            EvntData_dgv.BorderStyle = BorderStyle.None;
            EvntData_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            EvntData_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EvntData_dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            EvntData_dgv.Location = new Point(12, 194);
            EvntData_dgv.Name = "EvntData_dgv";
            EvntData_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EvntData_dgv.Size = new Size(1023, 465);
            EvntData_dgv.TabIndex = 115;
            EvntData_dgv.CellContentClick += EvntData_dgv_CellContentClick;
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1047, 671);
            Controls.Add(EvntData_dgv);
            Controls.Add(EventDuration_tb);
            Controls.Add(label10);
            Controls.Add(EventName_tb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(EventDate_dtp);
            Controls.Add(EvBack_btn);
            Controls.Add(EvDelete_btn);
            Controls.Add(EvEdit_btn);
            Controls.Add(EvAdd_btn);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Events";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Events";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EvntData_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox EventDuration_tb;
        private Label label10;
        private TextBox EventName_tb;
        private Label label11;
        private Label label12;
        private DateTimePicker EventDate_dtp;
        private PictureBox pictureBox2;
        private Button EvBack_btn;
        private Button EvDelete_btn;
        private Button EvEdit_btn;
        private Button EvAdd_btn;
        private Label label8;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView EvntData_dgv;
    }
}