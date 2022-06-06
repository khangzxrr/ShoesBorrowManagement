namespace ShoesBorrowManagement
{
    partial class BorrowForm
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
            this.unborrowedDatagrid = new System.Windows.Forms.DataGridView();
            this.borrowGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.borrowShoeBtn = new System.Windows.Forms.Button();
            this.deleteBorrowButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showBorrowDateCount = new System.Windows.Forms.Label();
            this.shoeBorrowDate = new System.Windows.Forms.Label();
            this.shoeDetail = new System.Windows.Forms.Label();
            this.shoeSize = new System.Windows.Forms.Label();
            this.shoeCatalog = new System.Windows.Forms.Label();
            this.shoeName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLíGiàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíLoạiGiàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.unborrowedDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // unborrowedDatagrid
            // 
            this.unborrowedDatagrid.AllowUserToAddRows = false;
            this.unborrowedDatagrid.AllowUserToDeleteRows = false;
            this.unborrowedDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unborrowedDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unborrowedDatagrid.Location = new System.Drawing.Point(862, 114);
            this.unborrowedDatagrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.unborrowedDatagrid.Name = "unborrowedDatagrid";
            this.unborrowedDatagrid.ReadOnly = true;
            this.unborrowedDatagrid.RowHeadersWidth = 82;
            this.unborrowedDatagrid.RowTemplate.Height = 41;
            this.unborrowedDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unborrowedDatagrid.Size = new System.Drawing.Size(430, 363);
            this.unborrowedDatagrid.TabIndex = 0;
            // 
            // borrowGrid
            // 
            this.borrowGrid.AllowUserToAddRows = false;
            this.borrowGrid.AllowUserToDeleteRows = false;
            this.borrowGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.borrowGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowGrid.Location = new System.Drawing.Point(22, 118);
            this.borrowGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.borrowGrid.Name = "borrowGrid";
            this.borrowGrid.ReadOnly = true;
            this.borrowGrid.RowHeadersWidth = 82;
            this.borrowGrid.RowTemplate.Height = 41;
            this.borrowGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowGrid.Size = new System.Drawing.Size(445, 359);
            this.borrowGrid.TabIndex = 1;
            this.borrowGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowGrid_onCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giày đã cho mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(865, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giày chưa cho mượn";
            // 
            // borrowShoeBtn
            // 
            this.borrowShoeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrowShoeBtn.Location = new System.Drawing.Point(860, 63);
            this.borrowShoeBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.borrowShoeBtn.Name = "borrowShoeBtn";
            this.borrowShoeBtn.Size = new System.Drawing.Size(131, 30);
            this.borrowShoeBtn.TabIndex = 5;
            this.borrowShoeBtn.Text = "Cho mượn";
            this.borrowShoeBtn.UseVisualStyleBackColor = true;
            this.borrowShoeBtn.Click += new System.EventHandler(this.borrowShoeBtn_Click);
            // 
            // deleteBorrowButton
            // 
            this.deleteBorrowButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBorrowButton.Location = new System.Drawing.Point(22, 77);
            this.deleteBorrowButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.deleteBorrowButton.Name = "deleteBorrowButton";
            this.deleteBorrowButton.Size = new System.Drawing.Size(131, 30);
            this.deleteBorrowButton.TabIndex = 6;
            this.deleteBorrowButton.Text = "Xóa";
            this.deleteBorrowButton.UseVisualStyleBackColor = true;
            this.deleteBorrowButton.Click += new System.EventHandler(this.deleteBorrowButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.showBorrowDateCount);
            this.groupBox1.Controls.Add(this.shoeBorrowDate);
            this.groupBox1.Controls.Add(this.shoeDetail);
            this.groupBox1.Controls.Add(this.shoeSize);
            this.groupBox1.Controls.Add(this.shoeCatalog);
            this.groupBox1.Controls.Add(this.shoeName);
            this.groupBox1.Location = new System.Drawing.Point(499, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(322, 300);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giày";
            // 
            // showBorrowDateCount
            // 
            this.showBorrowDateCount.AutoSize = true;
            this.showBorrowDateCount.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showBorrowDateCount.Location = new System.Drawing.Point(15, 243);
            this.showBorrowDateCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showBorrowDateCount.Name = "showBorrowDateCount";
            this.showBorrowDateCount.Size = new System.Drawing.Size(93, 25);
            this.showBorrowDateCount.TabIndex = 5;
            this.showBorrowDateCount.Text = "Đã mượn:";
            // 
            // shoeBorrowDate
            // 
            this.shoeBorrowDate.AutoSize = true;
            this.shoeBorrowDate.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeBorrowDate.Location = new System.Drawing.Point(15, 193);
            this.shoeBorrowDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoeBorrowDate.Name = "shoeBorrowDate";
            this.shoeBorrowDate.Size = new System.Drawing.Size(114, 25);
            this.shoeBorrowDate.TabIndex = 4;
            this.shoeBorrowDate.Text = "Ngày mượn:";
            // 
            // shoeDetail
            // 
            this.shoeDetail.AutoSize = true;
            this.shoeDetail.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeDetail.Location = new System.Drawing.Point(15, 147);
            this.shoeDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoeDetail.Name = "shoeDetail";
            this.shoeDetail.Size = new System.Drawing.Size(76, 25);
            this.shoeDetail.TabIndex = 3;
            this.shoeDetail.Text = "Chi tiết:";
            // 
            // shoeSize
            // 
            this.shoeSize.AutoSize = true;
            this.shoeSize.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeSize.Location = new System.Drawing.Point(15, 106);
            this.shoeSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoeSize.Name = "shoeSize";
            this.shoeSize.Size = new System.Drawing.Size(50, 25);
            this.shoeSize.TabIndex = 2;
            this.shoeSize.Text = "Size:";
            // 
            // shoeCatalog
            // 
            this.shoeCatalog.AutoSize = true;
            this.shoeCatalog.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeCatalog.Location = new System.Drawing.Point(15, 65);
            this.shoeCatalog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoeCatalog.Name = "shoeCatalog";
            this.shoeCatalog.Size = new System.Drawing.Size(51, 25);
            this.shoeCatalog.TabIndex = 1;
            this.shoeCatalog.Text = "Loại:";
            // 
            // shoeName
            // 
            this.shoeName.AutoSize = true;
            this.shoeName.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shoeName.Location = new System.Drawing.Point(15, 28);
            this.shoeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shoeName.Name = "shoeName";
            this.shoeName.Size = new System.Drawing.Size(45, 25);
            this.shoeName.TabIndex = 0;
            this.shoeName.Text = "Tên:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíGiàyToolStripMenuItem,
            this.quảnLíLoạiGiàyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLíGiàyToolStripMenuItem
            // 
            this.quảnLíGiàyToolStripMenuItem.Name = "quảnLíGiàyToolStripMenuItem";
            this.quảnLíGiàyToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.quảnLíGiàyToolStripMenuItem.Text = "Quản lí giày";
            this.quảnLíGiàyToolStripMenuItem.Click += new System.EventHandler(this.managed_shoe);
            // 
            // quảnLíLoạiGiàyToolStripMenuItem
            // 
            this.quảnLíLoạiGiàyToolStripMenuItem.Name = "quảnLíLoạiGiàyToolStripMenuItem";
            this.quảnLíLoạiGiàyToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.quảnLíLoạiGiàyToolStripMenuItem.Text = "Quản lí loại giày";
            this.quảnLíLoạiGiàyToolStripMenuItem.Click += new System.EventHandler(this.managed_catalog);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteBorrowButton);
            this.Controls.Add(this.borrowShoeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borrowGrid);
            this.Controls.Add(this.unborrowedDatagrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unborrowedDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView unborrowedDatagrid;
        private DataGridView borrowGrid;
        private Label label1;
        private Label label2;
        private Button borrowShoeBtn;
        private Button deleteBorrowButton;
        private GroupBox groupBox1;
        private Label showBorrowDateCount;
        private Label shoeBorrowDate;
        private Label shoeDetail;
        private Label shoeSize;
        private Label shoeCatalog;
        private Label shoeName;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLíGiàyToolStripMenuItem;
        private ToolStripMenuItem quảnLíLoạiGiàyToolStripMenuItem;
    }
}