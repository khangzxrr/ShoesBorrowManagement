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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalog = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deleteShoe = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(1116, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(403, 853);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm giày mới";
            // 
            // addShoeButton
            // 
            this.addShoeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addShoeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addShoeButton.Location = new System.Drawing.Point(11, 764);
            this.addShoeButton.Margin = new System.Windows.Forms.Padding(6);
            this.addShoeButton.Name = "addShoeButton";
            this.addShoeButton.Size = new System.Drawing.Size(381, 73);
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
            this.catalogCombobox.Location = new System.Drawing.Point(11, 196);
            this.catalogCombobox.Margin = new System.Windows.Forms.Padding(6);
            this.catalogCombobox.Name = "catalogCombobox";
            this.catalogCombobox.Size = new System.Drawing.Size(377, 53);
            this.catalogCombobox.TabIndex = 3;
            // 
            // shoeSizeTextbox
            // 
            this.shoeSizeTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeSizeTextbox.Location = new System.Drawing.Point(11, 122);
            this.shoeSizeTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.shoeSizeTextbox.Name = "shoeSizeTextbox";
            this.shoeSizeTextbox.PlaceholderText = "Size";
            this.shoeSizeTextbox.Size = new System.Drawing.Size(377, 50);
            this.shoeSizeTextbox.TabIndex = 2;
            // 
            // shoeDetailTextbox
            // 
            this.shoeDetailTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shoeDetailTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeDetailTextbox.Location = new System.Drawing.Point(11, 277);
            this.shoeDetailTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.shoeDetailTextbox.Multiline = true;
            this.shoeDetailTextbox.Name = "shoeDetailTextbox";
            this.shoeDetailTextbox.PlaceholderText = "Chi tiết";
            this.shoeDetailTextbox.Size = new System.Drawing.Size(377, 443);
            this.shoeDetailTextbox.TabIndex = 1;
            this.shoeDetailTextbox.TextChanged += new System.EventHandler(this.shoeDetailTextbox_TextChanged);
            // 
            // shoeNameTextbox
            // 
            this.shoeNameTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeNameTextbox.Location = new System.Drawing.Point(11, 47);
            this.shoeNameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.shoeNameTextbox.Name = "shoeNameTextbox";
            this.shoeNameTextbox.PlaceholderText = "Tên giày";
            this.shoeNameTextbox.Size = new System.Drawing.Size(377, 50);
            this.shoeNameTextbox.TabIndex = 0;
            // 
            // dataGridview
            // 
            this.dataGridview.AllowUserToAddRows = false;
            this.dataGridview.AllowUserToDeleteRows = false;
            this.dataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.size,
            this.detail,
            this.catalog});
            this.dataGridview.Location = new System.Drawing.Point(22, 26);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.RowHeadersWidth = 82;
            this.dataGridview.RowTemplate.Height = 50;
            this.dataGridview.Size = new System.Drawing.Size(1083, 725);
            this.dataGridview.TabIndex = 1;
            this.dataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellContentClick);
            this.dataGridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_cell_end_edit);
            this.dataGridview.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.datagrid_cellValidating);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 10;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 200;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.HeaderText = "Tên";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.Width = 97;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 10;
            this.size.Name = "size";
            this.size.Width = 200;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.detail.HeaderText = "Detail";
            this.detail.MinimumWidth = 10;
            this.detail.Name = "detail";
            this.detail.Width = 121;
            // 
            // catalog
            // 
            this.catalog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.catalog.HeaderText = "Catalog";
            this.catalog.MinimumWidth = 10;
            this.catalog.Name = "catalog";
            // 
            // deleteShoe
            // 
            this.deleteShoe.Location = new System.Drawing.Point(22, 789);
            this.deleteShoe.Margin = new System.Windows.Forms.Padding(6);
            this.deleteShoe.Name = "deleteShoe";
            this.deleteShoe.Size = new System.Drawing.Size(139, 49);
            this.deleteShoe.TabIndex = 2;
            this.deleteShoe.Text = "Xóa";
            this.deleteShoe.UseVisualStyleBackColor = true;
            this.deleteShoe.Click += new System.EventHandler(this.deleteShoe_Click);
            // 
            // ShoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 905);
            this.Controls.Add(this.deleteShoe);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private DataGridViewComboBoxColumn catalog;
    }
}