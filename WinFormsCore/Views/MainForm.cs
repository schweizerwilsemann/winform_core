using Microsoft.Data.SqlClient;
using Spire.Additions.Xps.Schema;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinFormsCore.Controllers;
using WinFormsCore.Models.Entities;
using Spire.Doc;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace WinFormsCore.Views
{
    public partial class MainForm : Form
    {
        private readonly ShopContext _context;
        private CustomerController customerController;
        private int currentPage = 1;
        int totalPage;

        public MainForm(ShopContext context)
        {
            InitializeComponent();
            _context = context;
            customerController = new CustomerController(context);

            loadComboBoxCity();
            LoadComboBoxColumns();
            loadGDV();

        }
        private int GetPageSize()
        {
            if (!string.IsNullOrEmpty(cbRow.Text) && int.TryParse(cbRow.Text, out int pageSize))
            {
                return pageSize;
            }
            else
            {
                // Handle invalid or empty input (provide a default value or show a message)
                MessageBox.Show("Please enter a valid number for rows per page.");
                return 10; // Default page size if input is invalid
            }
        }

        private int CalculateTotalPages(int pageSize)
        {
            int totalRecords = _context.Customers.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            return totalPages;
        }

        private void UpdateLabelNumberPage()
        {
            totalPage = CalculateTotalPages(GetPageSize());
            lblIndex.Text = $"Trang : {currentPage} / {totalPage} ";
        }

        private void loadGDV()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Họ", DataPropertyName = "Ho" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên", DataPropertyName = "Ten" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tỉnh/TP", DataPropertyName = "TinhTP" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quốc Gia", DataPropertyName = "QuocGia" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Điện thoại", DataPropertyName = "DienThoai" });

            customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());
            UpdateLabelNumberPage();
        }

        private void LoadPagedCustomers()
        {
            customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());  // Gọi phương thức phân trang từ Controller
            UpdateLabelNumberPage();
        }

        private void loadComboBoxCity()
        {
            foreach (var city in _context.Cities)
            {
                cbCity.Items.Add(city.Name);
            }
        }

        private void LoadComboBoxColumns()
        {
            string[] itemsTypeSort = { "Tăng dần", "Giảm dần" };
            foreach (var item in itemsTypeSort)
            {
                cbSort.Items.Add(item);
            }

            // Kiểm tra nếu có mục trong cbCity trước khi thiết lập SelectedIndex
            if (cbCity.Items.Count > 0)
            {
                cbCity.SelectedIndex = 0; // Chỉ đặt SelectedIndex nếu có mục
            }

            // Kiểm tra nếu có mục trong cbRow trước khi thiết lập SelectedIndex
            if (cbRow.Items.Count > 0)
            {
                cbRow.SelectedIndex = 0; // Chỉ đặt SelectedIndex nếu có mục
            }

            // Kiểm tra nếu có mục trong cbSort trước khi thiết lập SelectedIndex
            if (cbSort.Items.Count > 0)
            {
                cbSort.SelectedIndex = 0; // Chỉ đặt SelectedIndex nếu có mục
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Get the location of the mouse click
                var hit = dataGridView1.HitTest(e.X, e.Y);

                // Only show the context menu if the right-click is on a valid cell
                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    // Select the row that was clicked on
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;

                    // Show the ContextMenuStrip at the mouse position
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        int indexCustomerEdit;
        private void chinhSuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                indexCustomerEdit = selectedRow.Index;

                txtFirst.Text = selectedRow.Cells[1].Value.ToString();
                txtName.Text = selectedRow.Cells[2].Value.ToString();
                txtPhone.Text = selectedRow.Cells[5].Value.ToString();
                txtNation.Text = selectedRow.Cells[4].Value.ToString();

                btnUpdate.Enabled = true;
            }
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string firstName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            string fullName = firstName + " " + name;

            DialogResult result = MessageBox.Show($"Ban co muon xoa khach hang {fullName}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                    var customerToDelete = _context.Customers
                                        .SingleOrDefault(c => c.Id == id);
                    if (customerToDelete != null)
                    {
                        if (customerToDelete.Orders.Any())
                        {
                            foreach (var order in customerToDelete.Orders)
                            {
                                if (order.OrderItems.Any())
                                {
                                    _context.OrderItems.RemoveRange(order.OrderItems);
                                }
                            }
                            _context.Orders.RemoveRange(customerToDelete.Orders);
                        }

                        customerController.RemoveCustomer(customerToDelete);
                        customerController.SaveChange();
                        MessageBox.Show("Deleted.");
                        LoadPagedCustomers();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found");
                    }
                }
                else
                {
                    MessageBox.Show("No row selected");
                }
            }
        }

        private bool IsPhoneNumberValid(string phone)
        {
            // Regex pattern for phone number format 0 followed by exactly 9 digits
            string pattern = @"^0\d{9}$";
            return Regex.IsMatch(phone, pattern);
        }

        private bool validateInput()
        {
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(txtFirst.Text)) ;
            {
                errorProvider1.SetError(txtFirst, "First Name is required.");
                isValid = false;
            }
            // Validate LastName
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Last Name is required.");
                isValid = false;
            }

            // Validate Phone
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !IsPhoneNumberValid(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone number must start with '0' followed by 9 digits.");
                isValid = false;
            }

            // Validate Country
            if (string.IsNullOrWhiteSpace(txtNation.Text))
            {
                errorProvider1.SetError(txtNation, "Country is required.");
                isValid = false;
            }

            // Validate City
            if (cbCity.SelectedItem == null)
            {
                errorProvider1.SetError(cbCity, "Please select a city.");
                isValid = false;
            }

            return isValid;
        }

        private void ClearInputFields()
        {
            txtFirst.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtNation.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool isValid = validateInput();

            if (isValid)
            {
                _context.Customers.Add(new Customer
                {
                    FirstName = txtFirst.Text,
                    LastName = txtName.Text,
                    Country = txtNation.Text,
                    City = cbCity.SelectedItem.ToString(),
                    Phone = txtPhone.Text
                });
                _context.SaveChanges();
                MessageBox.Show("Added");
                loadGDV();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xac nhan chinh sua", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (indexCustomerEdit >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[indexCustomerEdit];

                    // Assuming the first cell contains the customer ID
                    int customerId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    // Retrieve the customer from the database using the customer ID
                    var customerToUpdate = _context.Customers.FirstOrDefault(c => c.Id == customerId);

                    if (customerToUpdate != null)
                    {
                        // Update the customer data with values from input fields
                        customerToUpdate.FirstName = txtFirst.Text;
                        customerToUpdate.LastName = txtName.Text;
                        customerToUpdate.Phone = txtPhone.Text;
                        customerToUpdate.Country = txtNation.Text;
                        //customerToUpdate.City = cbCity.SelectedItem.ToString();
                        customerToUpdate.City = cbCity.Text;


                        // Save changes to the database
                        _context.SaveChanges();
                        ClearInputFields();
                        btnUpdate.Enabled = false;
                        loadGDV();

                        MessageBox.Show("Customer updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            else
            {
                btnUpdate.Enabled = false;
                ClearInputFields();
            }
        }

        private void SortData(string columnName, string sortOrder)
        {
            // Fetch all customer data from the database
            var customers = _context.Customers.ToList();

            // Sort the data based on the selected column and order
            if (sortOrder == "Ascending")
            {
                customers = customers.OrderBy(c => c.GetType().GetProperty(columnName).GetValue(c, null)).ToList();
            }
            else
            {
                customers = customers.OrderByDescending(c => c.GetType().GetProperty(columnName).GetValue(c, null)).ToList();
            }

            // Clear the existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Reload the sorted data into the DataGridView
            foreach (var customer in customers)
            {
                dataGridView1.Rows.Add(customer.Id, customer.FirstName, customer.LastName, customer.Phone, customer.Country, customer.City);
            }
        }

        private void cbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex >= 0)
            {

                bool ascending = cbSort.SelectedIndex == 0;
                if (cbColumn.SelectedIndex == 0)
                {
                    customerController.SortCustomersById(ascending);
                    //MessageBox.Show("Tang dan stt");

                }
                else if (cbColumn.SelectedIndex == 1)
                {
                    customerController.SortCustomersByName(ascending);
                }

                // Refresh the DataGridView to show sorted data
                customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());
            }
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedIndex >= 0)
            {

                bool ascending = cbSort.SelectedIndex == 0;
                if (cbColumn.SelectedIndex == 0)
                {
                    customerController.SortCustomersById(ascending);
                    //MessageBox.Show("Tang dan stt");

                }
                else if (cbColumn.SelectedIndex == 1)
                {
                    customerController.SortCustomersByName(ascending);
                }

                // Refresh the DataGridView to show sorted data
                customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());
            }
        }

        private void cbRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPageSize();
            LoadPagedCustomers();
        }

        private void btnPageBefore_Click(object sender, EventArgs e)
        {
            if (currentPage > 1 && currentPage <= totalPage)
            {
                currentPage--;
            }
            else
                currentPage = totalPage;

            LoadPagedCustomers();  // Tải dữ liệu trang trước đó
        }

        private void btnPageAfter_Click(object sender, EventArgs e)
        {
            if (currentPage + 1 < totalPage)
            {
                currentPage++;
            }
            else
            {
                currentPage = 1;
            }
            LoadPagedCustomers();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {

                string searchTerm = txtSearch.Text.ToLower();
                var foundCustomers = (from c in _context.Customers
                                      where c.FirstName.ToLower().Contains(searchTerm)
                                         || c.LastName.ToLower().Contains(searchTerm)
                                      select c).ToList();
                customerController.UpdateCustomerBinDingList(foundCustomers);
                customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());
            }
            else
            {
                // Optionally reset DataGridView or display all customers
                var allCustomers = _context.Customers.ToList();
                customerController.UpdateCustomerBinDingList(allCustomers);
                customerController.DisplayCustomerToGridView(dataGridView1, currentPage, GetPageSize());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string templatePath = "C:\\Users\\ANH TAI\\Documents\\Zalo Received Files\\THÔNG TIN KHÁCH HÀNG.docx";
            Spire.Doc.Document document = new Spire.Doc.Document();
            document.LoadFromFile(templatePath);

            string name = $"{txtFirst.Text} {txtName.Text}";

            document.Replace("{HoTen}", name, false, true);
            document.Replace("{Tinh}", cbCity.Text, false, true);
            document.Replace("{SDT}", txtPhone.Text, false, true);
            document.Replace("{Qg}", txtNation.Text, false, true);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Document (*.pdf)|*.pdf";
            saveFileDialog.FileName = "ThongTinKhachHang.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu tài liệu dưới dạng PDF
                document.SaveToFile(saveFileDialog.FileName, FileFormat.PDF);
                MessageBox.Show("Đã xuất thông tin khách hàng thành công dưới dạng PDF!");
            }

            // Giải phóng tài nguyên
            document.Close();
        }

        private void btnCusList_Click(object sender, EventArgs e)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(dataGridView1.Columns[i].HeaderText);
            }
            // Thêm dữ liệu từ DataGridView vào sheet
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ICell cell = row.CreateCell(j);
                    object value = dataGridView1.Rows[i].Cells[j].Value;
                    cell.SetCellValue(value != null ? value.ToString() : string.Empty);
                }
            }

        }
    }
}
