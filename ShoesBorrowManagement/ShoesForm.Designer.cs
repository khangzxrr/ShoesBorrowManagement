namespace ShoesBorrowManagement
{
    partial class ShoesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addShoeButton = new System.Windows.Forms.Button();
            this.catalogCombobox = new System.Windows.Forms.ComboBox();
            this.shoeSizeTextbox = new System.Windows.Forms.TextBox();
            this.shoeDetailTextbox = new System.Windows.Forms.TextBox();
            this.shoeNameTextbox = new System.Windows.Forms.TextBox();
            this.dataGridview = new System.Windows.Forms.DataGridView();
            this.deleteShoe = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loại = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addShoeButton);
            this.groupBox1.Controls.Add(this.catalogCombobox);
            this.groupBox1.Controls.Add(this.shoeSizeTextbox);
            this.groupBox1.Controls.Add(this.shoeDetailTextbox);
            this.groupBox1.Controls.Add(this.shoeNameTextbox);
            this.groupBox1.Location = new System.Drawing.Point(601, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm giày mới";
            // 
            // addShoeButton
            // 
            this.addShoeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addShoeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addShoeButton.Location = new System.Drawing.Point(6, 358);
            this.addShoeButton.Name = "addShoeButton";
            this.addShoeButton.Size = new System.Drawing.Size(205, 34);
            this.addShoeButton.TabIndex = 4;
            this.addShoeButton.Text = "Thêm giày mới";
            this.addShoeButton.UseVisualStyleBackColor = true;
            this.addShoeButton.Click += new System.EventHandler(this.addShoeButton_Click);
            // 
            // catalogCombobox
            // 
            this.catalogCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catalogCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogCombobox.FormattingEnabled = true;
            this.catalogCombobox.Location = new System.Drawing.Point(6, 92);
            this.catalogCombobox.Name = "catalogCombobox";
            this.catalogCombobox.Size = new System.Drawing.Size(205, 29);
            this.catalogCombobox.TabIndex = 3;
            // 
            // shoeSizeTextbox
            // 
            this.shoeSizeTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeSizeTextbox.Location = new System.Drawing.Point(6, 57);
            this.shoeSizeTextbox.Name = "shoeSizeTextbox";
            this.shoeSizeTextbox.PlaceholderText = "Size";
            this.shoeSizeTextbox.Size = new System.Drawing.Size(205, 29);
            this.shoeSizeTextbox.TabIndex = 2;
            // 
            // shoeDetailTextbox
            // 
            this.shoeDetailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoeDetailTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeDetailTextbox.Location = new System.Drawing.Point(6, 130);
            this.shoeDetailTextbox.Multiline = true;
            this.shoeDetailTextbox.Name = "shoeDetailTextbox";
            this.shoeDetailTextbox.PlaceholderText = "Chi tiết";
            this.shoeDetailTextbox.Size = new System.Drawing.Size(205, 210);
            this.shoeDetailTextbox.TabIndex = 1;
            this.shoeDetailTextbox.TextChanged += new System.EventHandler(this.shoeDetailTextbox_TextChanged);
            // 
            // shoeNameTextbox
            // 
            this.shoeNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeNameTextbox.Location = new System.Drawing.Point(6, 22);
            this.shoeNameTextbox.Name = "shoeNameTextbox";
            this.shoeNameTextbox.PlaceholderText = "Tên giày";
            this.shoeNameTextbox.Size = new System.Drawing.Size(205, 29);
            this.shoeNameTextbox.TabIndex = 0;
            // 
            // dataGridview
            // 
            this.dataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.detail,
            this.Loại});
            this.dataGridview.Location = new System.Drawing.Point(12, 12);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowTemplate.Height = 25;
            this.dataGridview.Size = new System.Drawing.Size(583, 340);
            this.dataGridview.TabIndex = 1;
            // 
            // deleteShoe
            // 
            this.deleteShoe.Location = new System.Drawing.Point(12, 370);
            this.deleteShoe.Name = "deleteShoe";
            this.deleteShoe.Size = new System.Drawing.Size(75, 23);
            this.deleteShoe.TabIndex = 2;
            this.deleteShoe.Text = "Xóa";
            this.deleteShoe.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Tên";
            this.name.Name = "name";
            this.name.Width = 50;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detail.HeaderText = "Chi tiết";
            this.detail.Name = "detail";
            // 
            // Loại
            // 
            this.Loại.HeaderText = "catalog";
            this.Loại.Name = "Loại";
            // 
            // ShoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 424);
            this.Controls.Add(this.deleteShoe);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShoesForm";
            this.Text = "ShoesForm";
            this.Load += new System.EventHandler(this.ShoesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridview;
        private TextBox shoeSizeTextbox;
        private TextBox shoeDetailTextbox;
        private TextBox shoeNameTextbox;
        private ComboBox catalogCombobox;
        private Button addShoeButton;
        private Button deleteShoe;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn detail;
        private DataGridViewComboBoxColumn Loại;
    }
}