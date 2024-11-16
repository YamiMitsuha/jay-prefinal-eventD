namespace FrmReadingFiles
{
    partial class Form1
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
            lvShowText = new ListView();
            register_btn = new Button();
            find_btn = new Button();
            upload_btn = new Button();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            path_link = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lvShowText
            // 
            lvShowText.Location = new Point(66, 104);
            lvShowText.Name = "lvShowText";
            lvShowText.Size = new Size(383, 275);
            lvShowText.TabIndex = 0;
            lvShowText.UseCompatibleStateImageBehavior = false;
            lvShowText.View = View.List;
            // 
            // register_btn
            // 
            register_btn.Location = new Point(483, 88);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(118, 46);
            register_btn.TabIndex = 1;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // find_btn
            // 
            find_btn.Location = new Point(483, 152);
            find_btn.Name = "find_btn";
            find_btn.Size = new Size(118, 47);
            find_btn.TabIndex = 1;
            find_btn.Text = "Find";
            find_btn.UseVisualStyleBackColor = true;
            find_btn.Click += find_btn_Click;
            // 
            // upload_btn
            // 
            upload_btn.BackColor = Color.FromArgb(192, 255, 192);
            upload_btn.Location = new Point(483, 254);
            upload_btn.Name = "upload_btn";
            upload_btn.Size = new Size(118, 87);
            upload_btn.TabIndex = 1;
            upload_btn.Text = "Upload";
            upload_btn.UseVisualStyleBackColor = false;
            upload_btn.Click += upload_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 16);
            label1.Name = "label1";
            label1.Size = new Size(233, 38);
            label1.TabIndex = 2;
            label1.Text = "VIEW RECORD";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // path_link
            // 
            path_link.Enabled = false;
            path_link.Location = new Point(66, 65);
            path_link.Name = "path_link";
            path_link.Size = new Size(383, 23);
            path_link.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 4;
            label2.Text = "Path:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(645, 407);
            Controls.Add(label2);
            Controls.Add(path_link);
            Controls.Add(label1);
            Controls.Add(upload_btn);
            Controls.Add(find_btn);
            Controls.Add(register_btn);
            Controls.Add(lvShowText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvShowText;
        private Button register_btn;
        private Button find_btn;
        private Button upload_btn;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private TextBox path_link;
        private Label label2;
    }
}
