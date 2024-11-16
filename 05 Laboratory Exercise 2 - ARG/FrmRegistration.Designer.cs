namespace FrmReadingFiles
{
    partial class frmRegistration
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
            label1 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            cbGender = new ComboBox();
            cbPrograms = new ComboBox();
            datePickerBirtday = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 20);
            label1.Name = "label1";
            label1.Size = new Size(331, 53);
            label1.TabIndex = 0;
            label1.Text = "REGISTRATION";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(71, 126);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(209, 23);
            txtStudentNo.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(71, 205);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(209, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(71, 294);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(209, 23);
            txtAge.TabIndex = 3;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(327, 386);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(185, 23);
            txtContactNo.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(327, 205);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 23);
            txtFirstName.TabIndex = 5;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(538, 205);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(100, 23);
            txtMiddleInitial.TabIndex = 6;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(327, 299);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(185, 23);
            cbGender.TabIndex = 7;
            // 
            // cbPrograms
            // 
            cbPrograms.FormattingEnabled = true;
            cbPrograms.Items.AddRange(new object[] { "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Engineering", "Bachelor of Science in Tourism Management", "Bachelor of Science in Business Administration", "Bachelor of Science in Accountancy" });
            cbPrograms.Location = new Point(324, 126);
            cbPrograms.Name = "cbPrograms";
            cbPrograms.Size = new Size(314, 23);
            cbPrograms.TabIndex = 8;
            // 
            // datePickerBirtday
            // 
            datePickerBirtday.Location = new Point(71, 386);
            datePickerBirtday.Name = "datePickerBirtday";
            datePickerBirtday.Size = new Size(209, 23);
            datePickerBirtday.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 175);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(324, 175);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 175);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 10;
            label5.Text = "Middle Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 88);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Programs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 255);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 10;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 255);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 10;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 345);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 10;
            label9.Text = "Birthday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(324, 345);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 10;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 255, 128);
            btnRegister.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(71, 446);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(567, 41);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(717, 526);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(datePickerBirtday);
            Controls.Add(cbPrograms);
            Controls.Add(cbGender);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private ComboBox cbGender;
        private ComboBox cbPrograms;
        private DateTimePicker datePickerBirtday;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnRegister;
    }
}