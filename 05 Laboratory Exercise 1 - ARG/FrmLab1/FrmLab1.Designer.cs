namespace FrmLab1
{
    partial class FrmLab1
    {
        // Paala, James P.            BSIT - 501
        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();

            txtInput.Location = new Point(81, 42);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(250, 121);
            txtInput.TabIndex = 3;

            btnCreate.Location = new Point(149, 208);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(110, 35);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(418, 283);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Name = "FrmLab1";
            Text = "FrmLab1";
            Load += FrmLab1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnCreate;
    }
}
