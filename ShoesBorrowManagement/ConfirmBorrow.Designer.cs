namespace ShoesBorrowManagement
{
    partial class ConfirmBorrow
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.borrowDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Location = new System.Drawing.Point(324, 238);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(210, 46);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Cho mượn";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmLabel.Location = new System.Drawing.Point(30, 31);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(312, 90);
            this.confirmLabel.TabIndex = 1;
            this.confirmLabel.Text = "Xác nhận cho mượn \r\nN giày vào ngày";
            // 
            // borrowDate
            // 
            this.borrowDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowDate.Location = new System.Drawing.Point(30, 170);
            this.borrowDate.Name = "borrowDate";
            this.borrowDate.Size = new System.Drawing.Size(504, 39);
            this.borrowDate.TabIndex = 2;
            // 
            // ConfirmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 318);
            this.Controls.Add(this.borrowDate);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.confirmButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmBorrow";
            this.Text = "ConfirmBorrow";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button confirmButton;
        private Label confirmLabel;
        private DateTimePicker borrowDate;
    }
}