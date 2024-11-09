namespace WinFormsCore.Views
{
    partial class ProductForm
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
            menuStrip1 = new MenuStrip();
            tepToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            hangHoaToolStripMenuItem = new ToolStripMenuItem();
            improtSanPhamToolStripMenuItem = new ToolStripMenuItem();
            exportSanPhamToolStripMenuItem = new ToolStripMenuItem();
            dgvProducts = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tepToolStripMenuItem, hangHoaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(895, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tepToolStripMenuItem
            // 
            tepToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            tepToolStripMenuItem.Name = "tepToolStripMenuItem";
            tepToolStripMenuItem.Size = new Size(47, 24);
            tepToolStripMenuItem.Text = "Tep";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(224, 26);
            dangXuatToolStripMenuItem.Text = "Dang xuat";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(224, 26);
            thoatToolStripMenuItem.Text = "Thoat";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // hangHoaToolStripMenuItem
            // 
            hangHoaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { improtSanPhamToolStripMenuItem, exportSanPhamToolStripMenuItem });
            hangHoaToolStripMenuItem.Name = "hangHoaToolStripMenuItem";
            hangHoaToolStripMenuItem.Size = new Size(88, 24);
            hangHoaToolStripMenuItem.Text = "Hang hoa";
            // 
            // improtSanPhamToolStripMenuItem
            // 
            improtSanPhamToolStripMenuItem.Name = "improtSanPhamToolStripMenuItem";
            improtSanPhamToolStripMenuItem.Size = new Size(224, 26);
            improtSanPhamToolStripMenuItem.Text = "Improt san pham";
            improtSanPhamToolStripMenuItem.Click += improtSanPhamToolStripMenuItem_Click;
            // 
            // exportSanPhamToolStripMenuItem
            // 
            exportSanPhamToolStripMenuItem.Name = "exportSanPhamToolStripMenuItem";
            exportSanPhamToolStripMenuItem.Size = new Size(224, 26);
            exportSanPhamToolStripMenuItem.Text = "Export san pham";
            exportSanPhamToolStripMenuItem.Click += exportSanPhamToolStripMenuItem_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(24, 62);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(826, 399);
            dgvProducts.TabIndex = 1;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 473);
            Controls.Add(dgvProducts);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProductForm";
            Text = "ProductForm";
            Load += ProductForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tepToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem hangHoaToolStripMenuItem;
        private ToolStripMenuItem improtSanPhamToolStripMenuItem;
        private ToolStripMenuItem exportSanPhamToolStripMenuItem;
        private DataGridView dgvProducts;
    }
}