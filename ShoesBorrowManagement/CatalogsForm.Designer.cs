namespace ShoesBorrowManagement
{
    partial class CatalogsForm
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
            this.components = new System.ComponentModel.Container();
            this.catalogName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.catalogDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.catalogServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogServicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // catalogName
            // 
            this.catalogName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.catalogName.Location = new System.Drawing.Point(112, 337);
            this.catalogName.Name = "catalogName";
            this.catalogName.PlaceholderText = "Tên loại giày mới";
            this.catalogName.Size = new System.Drawing.Size(295, 29);
            this.catalogName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại giày";
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(12, 387);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(395, 43);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Thêm loại mới";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // catalogDataGridView
            // 
            this.catalogDataGridView.AllowUserToAddRows = false;
            this.catalogDataGridView.AllowUserToDeleteRows = false;
            this.catalogDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.catalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDataGridView.Location = new System.Drawing.Point(12, 12);
            this.catalogDataGridView.Name = "catalogDataGridView";
            this.catalogDataGridView.RowTemplate.Height = 25;
            this.catalogDataGridView.Size = new System.Drawing.Size(395, 249);
            this.catalogDataGridView.TabIndex = 3;
            this.catalogDataGridView.VirtualMode = true;
            this.catalogDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.catalogDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellEndEdit);
            this.catalogDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridview_cellValidating);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Location = new System.Drawing.Point(12, 267);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 24);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "xóa";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // catalogServicesBindingSource
            // 
            this.catalogServicesBindingSource.DataSource = typeof(ShoesBorrowManagement.Services.CatalogServices);
            // 
            // CatalogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 442);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.catalogDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.catalogName);
            this.Name = "CatalogsForm";
            this.Text = "CatalogsForm";
            this.Load += new System.EventHandler(this.CatalogsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogServicesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox catalogName;
        private Label label1;
        private Button addButton;
        private ErrorProvider errorProvider;
        private DataGridView catalogDataGridView;
        private Button deleteButton;
        private BindingSource catalogServicesBindingSource;
    }
}