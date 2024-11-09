namespace WinFormsCore.Views
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            lblManage = new Label();
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPhone = new TextBox();
            lblPhone = new Label();
            panel2 = new Panel();
            txtNation = new TextBox();
            txtName = new TextBox();
            lblNation = new Label();
            lblName = new Label();
            panel1 = new Panel();
            cbCity = new ComboBox();
            txtFirst = new TextBox();
            lblCity = new Label();
            lblFirst = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ordersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            chinhSuaToolStripMenuItem = new ToolStripMenuItem();
            xoaToolStripMenuItem = new ToolStripMenuItem();
            errorProvider1 = new ErrorProvider(components);
            panel4 = new Panel();
            cbColumn = new ComboBox();
            cbSort = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblColumn = new Label();
            lblSort = new Label();
            panel5 = new Panel();
            btnPrint = new Button();
            cbRow = new ComboBox();
            lblIndex = new Label();
            btnPageAfter = new Button();
            btnPageBefore = new Button();
            lblRow = new Label();
            customerBindingSource = new BindingSource(components);
            btnCusList = new Button();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblManage
            // 
            lblManage.AutoSize = true;
            lblManage.Location = new Point(330, 13);
            lblManage.Name = "lblManage";
            lblManage.Size = new Size(135, 20);
            lblManage.TabIndex = 0;
            lblManage.Text = "Quan li khach hang";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(49, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(621, 213);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thong tin khach hang";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(lblPhone);
            panel3.Location = new Point(7, 163);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 44);
            panel3.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(467, 7);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cap nhat";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(320, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Them moi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(117, 8);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(40, 12);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(78, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Dien thoai";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtNation);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lblNation);
            panel2.Controls.Add(lblName);
            panel2.Location = new Point(7, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 44);
            panel2.TabIndex = 1;
            // 
            // txtNation
            // 
            txtNation.Location = new Point(409, 11);
            txtNation.Name = "txtNation";
            txtNation.Size = new Size(151, 27);
            txtNation.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // lblNation
            // 
            lblNation.AutoSize = true;
            lblNation.Location = new Point(320, 11);
            lblNation.Name = "lblNation";
            lblNation.Size = new Size(69, 20);
            lblNation.TabIndex = 3;
            lblNation.Text = "Quoc gia";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 13);
            lblName.Name = "lblName";
            lblName.Size = new Size(32, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Ten";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbCity);
            panel1.Controls.Add(txtFirst);
            panel1.Controls.Add(lblCity);
            panel1.Controls.Add(lblFirst);
            panel1.Location = new Point(7, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 44);
            panel1.TabIndex = 0;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(409, 8);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(151, 28);
            cbCity.TabIndex = 3;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(86, 8);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(125, 27);
            txtFirst.TabIndex = 2;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(320, 12);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(59, 20);
            lblCity.TabIndex = 1;
            lblCity.Text = "Tinh/TP";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(42, 12);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(29, 20);
            lblFirst.TabIndex = 0;
            lblFirst.Text = "Ho";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, ordersDataGridViewTextBoxColumn });
            dataGridView1.Location = new Point(49, 325);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(621, 221);
            dataGridView1.TabIndex = 2;
            dataGridView1.MouseDown += dataGridView1_MouseDown;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.ReadOnly = true;
            countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            ordersDataGridViewTextBoxColumn.MinimumWidth = 6;
            ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            ordersDataGridViewTextBoxColumn.ReadOnly = true;
            ordersDataGridViewTextBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { chinhSuaToolStripMenuItem, xoaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(142, 52);
            // 
            // chinhSuaToolStripMenuItem
            // 
            chinhSuaToolStripMenuItem.Name = "chinhSuaToolStripMenuItem";
            chinhSuaToolStripMenuItem.Size = new Size(141, 24);
            chinhSuaToolStripMenuItem.Text = "Chinh sua";
            chinhSuaToolStripMenuItem.Click += chinhSuaToolStripMenuItem_Click;
            // 
            // xoaToolStripMenuItem
            // 
            xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            xoaToolStripMenuItem.Size = new Size(141, 24);
            xoaToolStripMenuItem.Text = "Xoa";
            xoaToolStripMenuItem.Click += xoaToolStripMenuItem_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel4
            // 
            panel4.Controls.Add(cbColumn);
            panel4.Controls.Add(cbSort);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(lblSearch);
            panel4.Controls.Add(lblColumn);
            panel4.Controls.Add(lblSort);
            panel4.Location = new Point(53, 253);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(617, 65);
            panel4.TabIndex = 3;
            // 
            // cbColumn
            // 
            cbColumn.DropDownStyle = ComboBoxStyle.DropDownList;
            cbColumn.FormattingEnabled = true;
            cbColumn.Items.AddRange(new object[] { "STT", "Ten" });
            cbColumn.Location = new Point(281, 19);
            cbColumn.Margin = new Padding(3, 4, 3, 4);
            cbColumn.Name = "cbColumn";
            cbColumn.Size = new Size(124, 28);
            cbColumn.TabIndex = 5;
            cbColumn.SelectedIndexChanged += cbColumn_SelectedIndexChanged;
            // 
            // cbSort
            // 
            cbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSort.FormattingEnabled = true;
            cbSort.Location = new Point(107, 19);
            cbSort.Margin = new Padding(3, 4, 3, 4);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(124, 28);
            cbSort.TabIndex = 4;
            cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(471, 19);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(413, 23);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 20);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Tim kiem";
            // 
            // lblColumn
            // 
            lblColumn.AutoSize = true;
            lblColumn.Location = new Point(246, 23);
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(32, 20);
            lblColumn.TabIndex = 1;
            lblColumn.Text = "Cot";
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Location = new Point(46, 23);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(62, 20);
            lblSort.TabIndex = 0;
            lblSort.Text = "Sap xep";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbRow);
            panel5.Controls.Add(lblIndex);
            panel5.Controls.Add(btnPageAfter);
            panel5.Controls.Add(btnPageBefore);
            panel5.Controls.Add(lblRow);
            panel5.Location = new Point(53, 557);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(617, 63);
            panel5.TabIndex = 4;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(544, 9);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "button1";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // cbRow
            // 
            cbRow.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRow.FormattingEnabled = true;
            cbRow.Items.AddRange(new object[] { "5", "15", "10", "15", "20", "25", "30", "100" });
            cbRow.Location = new Point(107, 16);
            cbRow.Margin = new Padding(3, 4, 3, 4);
            cbRow.Name = "cbRow";
            cbRow.Size = new Size(138, 28);
            cbRow.TabIndex = 4;
            cbRow.SelectedIndexChanged += cbRow_SelectedIndexChanged;
            // 
            // lblIndex
            // 
            lblIndex.Location = new Point(475, 20);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(110, 31);
            lblIndex.TabIndex = 3;
            // 
            // btnPageAfter
            // 
            btnPageAfter.Location = new Point(350, 20);
            btnPageAfter.Margin = new Padding(3, 4, 3, 4);
            btnPageAfter.Name = "btnPageAfter";
            btnPageAfter.Size = new Size(86, 31);
            btnPageAfter.TabIndex = 2;
            btnPageAfter.Text = "Trang ke";
            btnPageAfter.UseVisualStyleBackColor = true;
            btnPageAfter.Click += btnPageAfter_Click;
            // 
            // btnPageBefore
            // 
            btnPageBefore.Location = new Point(257, 20);
            btnPageBefore.Margin = new Padding(3, 4, 3, 4);
            btnPageBefore.Name = "btnPageBefore";
            btnPageBefore.Size = new Size(86, 31);
            btnPageBefore.TabIndex = 1;
            btnPageBefore.Text = "Trang truoc";
            btnPageBefore.UseVisualStyleBackColor = true;
            btnPageBefore.Click += btnPageBefore_Click;
            // 
            // lblRow
            // 
            lblRow.AutoSize = true;
            lblRow.Location = new Point(43, 20);
            lblRow.Name = "lblRow";
            lblRow.Size = new Size(65, 20);
            lblRow.TabIndex = 0;
            lblRow.Text = "So dong";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Entities.Customer);
            // 
            // btnCusList
            // 
            btnCusList.Location = new Point(142, 4);
            btnCusList.Name = "btnCusList";
            btnCusList.Size = new Size(94, 29);
            btnCusList.TabIndex = 6;
            btnCusList.Text = "button1";
            btnCusList.UseVisualStyleBackColor = true;
            btnCusList.Click += btnCusList_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 659);
            Controls.Add(btnCusList);
            Controls.Add(btnPrint);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(lblManage);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManage;
        private GroupBox groupBox1;
        private Panel panel3;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPhone;
        private Label lblPhone;
        private Panel panel2;
        private TextBox txtNation;
        private TextBox txtName;
        private Label lblNation;
        private Label lblName;
        private Panel panel1;
        private TextBox txtFirst;
        private Label lblCity;
        private Label lblFirst;
        private ComboBox cbCity;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem chinhSuaToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private Panel panel4;
        private Panel panel5;
        private Label lblIndex;
        private Button btnPageAfter;
        private Button btnPageBefore;
        private Label lblRow;
        private TextBox txtSearch;
        private Label lblSearch;
        private Label lblColumn;
        private Label lblSort;
        private ComboBox cbRow;
        private ComboBox cbColumn;
        private ComboBox cbSort;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
        private Button btnPrint;
        private Button btnCusList;
    }
}
