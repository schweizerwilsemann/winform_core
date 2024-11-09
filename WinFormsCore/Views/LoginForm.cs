using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsCore.Views
{
    public partial class LoginForm : Form
    {
        private readonly AccountController _accountController;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(ShopContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _accountController = new AccountController(context);
            _serviceProvider = serviceProvider;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if(username.IsNullOrEmpty() || password.IsNullOrEmpty())
                {
                    return;
                }

                var checkLogin = (from c in _accountController.Querry
                                  where c.Username == username && c.Password == password
                                  select c).SingleOrDefault();

                if (checkLogin == null)
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu sai");
                }

                else
                {
                    // set role for user.
                    User.Role = checkLogin.Role;
                    //move on to another form

                    var mainForm = _serviceProvider.GetRequiredService<ProductForm>();
                    mainForm.FormClosed += CloseLoginForm; // khi form chính đóng sẽ gọi hàm này
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch { }
        }

        private void CloseLoginForm(object sender, FormClosedEventArgs e)
        {
            this.Close(); // Close the login form when MainForm closes
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
