using Microsoft.Extensions.DependencyInjection;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsCore.Controllers;
using WinFormsCore.Models.Entities;

namespace WinFormsCore.Views
{
    public partial class ProductForm : Form
    {
        private readonly ProductController _productController;
        IServiceProvider _serviceProvider;
        ShopContext _context;

        public ProductForm(ShopContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _productController = new ProductController(context);
            _serviceProvider = serviceProvider;
            _context = context;
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DANG XUAT ???", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var login = _serviceProvider.GetRequiredService<LoginForm>();
                login.FormClosed += CloseMainForm; // khi form chính đóng sẽ gọi hàm này
                login.Show();
                this.Hide();
            }
        }

        private void CloseMainForm(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when MainForm closes
        }

        private void LoadDataGridView()
        {
            try
            {
                dgvProducts.AutoGenerateColumns = false;

                dgvProducts.Columns.Clear();
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "STT", DataPropertyName = "STT" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên sản phẩm", DataPropertyName = "Name" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên nhà cung cấp", DataPropertyName = "SupplierName" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Giá sản phẩm", DataPropertyName = "UnitPrice" });
                dgvProducts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quốc Gia", DataPropertyName = "IsDiscontinued" });

                //LoadPagedCustomers();
                _productController.DisplayToGirdView(dgvProducts);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at class ManageProduct(Form) function LoadDataGridView " + ex.Message);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("THOAT ???", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void improtSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog.FileName;
                IWorkbook workbook;

                using (FileStream file = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                {
                    workbook = new XSSFWorkbook(file); // Đọc file .xlsx
                }
                ISheet sheet = workbook.GetSheetAt(0);

                for (int i = 1; i <= sheet.LastRowNum; i++)// Bỏ qua dòng đầu tiên (header)
                {
                    IRow row = sheet.GetRow(i);
                    if (row == null) continue;

                    var product = new Product
                    {
                        ProductName = row.GetCell(1).StringCellValue,
                        SupplierId = (int)row.GetCell(2).NumericCellValue,
                        UnitPrice = (decimal)row.GetCell(3).NumericCellValue,
                        IsDiscontinued = row.GetCell(4).BooleanCellValue
                    };

                    _context.Products.Add(product);
                }

                _context.SaveChanges();
                workbook.Close();
                MessageBox.Show("Nhập dữ liệu thành công!");

                // Hiển thị lại dữ liệu từ database lên DataGridView
                LoadDataGridView();
            }
        }

        private void exportSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.FileName = "DanhSachSanPham.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Products");

                // Tạo header
                IRow headerRow = sheet.CreateRow(0);
                headerRow.CreateCell(0).SetCellValue("STT");
                headerRow.CreateCell(1).SetCellValue("Tên sản phẩm");
                headerRow.CreateCell(2).SetCellValue("Tên nhà cung cấp");
                headerRow.CreateCell(3).SetCellValue("Giá sản phẩm");
                headerRow.CreateCell(4).SetCellValue("Quốc Gia");

                for (int i = 0; i < dgvProducts.Rows.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + 1);

                    row.CreateCell(0).SetCellValue(Convert.ToInt32(dgvProducts.Rows[i].Cells[0].Value));
                    row.CreateCell(1).SetCellValue(dgvProducts.Rows[i].Cells[1].Value.ToString());
                    row.CreateCell(2).SetCellValue(dgvProducts.Rows[i].Cells[2].Value.ToString());
                    row.CreateCell(3).SetCellValue(Convert.ToDouble(dgvProducts.Rows[i].Cells[3].Value));
                    row.CreateCell(4).SetCellValue(Convert.ToBoolean(dgvProducts.Rows[i].Cells[4].Value));
                }
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }

                workbook.Close();
                MessageBox.Show("Xuất dữ liệu thành công!");

            }
        }
    }
}
