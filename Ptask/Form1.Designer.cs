namespace BasicComputation
{
    partial class FrmBasicCalculator
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
            fNum = new TextBox();
            sNum = new TextBox();
            operatorCmb = new ComboBox();
            totalViews = new ListView();
            label1 = new Label();
            compute_btn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // fNum
            // 
            fNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fNum.Location = new Point(103, 80);
            fNum.Name = "fNum";
            fNum.Size = new Size(235, 39);
            fNum.TabIndex = 0;
            fNum.TextAlign = HorizontalAlignment.Right;
            // 
            // sNum
            // 
            sNum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sNum.Location = new Point(103, 176);
            sNum.Name = "sNum";
            sNum.Size = new Size(235, 39);
            sNum.TabIndex = 1;
            sNum.TextAlign = HorizontalAlignment.Right;
            // 
            // operatorCmb
            // 
            operatorCmb.FormattingEnabled = true;
            operatorCmb.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operatorCmb.Location = new Point(103, 135);
            operatorCmb.Name = "operatorCmb";
            operatorCmb.Size = new Size(121, 23);
            operatorCmb.TabIndex = 2;
            // 
            // totalViews
            // 
            totalViews.BackColor = Color.Black;
            totalViews.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalViews.ForeColor = Color.Lime;
            totalViews.Location = new Point(60, 245);
            totalViews.Name = "totalViews";
            totalViews.Size = new Size(235, 112);
            totalViews.TabIndex = 3;
            totalViews.UseCompatibleStateImageBehavior = false;
            totalViews.View = View.List;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 26);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 4;
            label1.Text = "Basic Calculator";
            // 
            // compute_btn
            // 
            compute_btn.BackColor = Color.FromArgb(192, 255, 192);
            compute_btn.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            compute_btn.Location = new Point(60, 383);
            compute_btn.Name = "compute_btn";
            compute_btn.Size = new Size(235, 46);
            compute_btn.TabIndex = 5;
            compute_btn.Text = "Compute";
            compute_btn.UseVisualStyleBackColor = false;
            compute_btn.Click += compute_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "First Digit";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 188);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "First Digit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 140);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Operation";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(350, 451);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(compute_btn);
            Controls.Add(label1);
            Controls.Add(totalViews);
            Controls.Add(operatorCmb);
            Controls.Add(sNum);
            Controls.Add(fNum);
            Name = "FrmBasicCalculator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fNum;
        private TextBox sNum;
        private ComboBox operatorCmb;
        private ListView totalViews;
        private Label label1;
        private Button compute_btn;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
