using WinFormsCore.Views;
using WinFormsCore.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace WinFormsCore
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Kích hoạt giao diện hiện đại cho ứng dụng WinForms
            Application.EnableVisualStyles();

            // Đặt cấu hình rendering text (phải gọi trước khi khởi tạo UI)
            Application.SetCompatibleTextRenderingDefault(false);

            // Tùy chỉnh cấu hình ứng dụng (ví dụ: cài đặt DPI, font mặc định)
            ApplicationConfiguration.Initialize();

            // Xây dựng cấu hình từ appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            // Đăng ký dịch vụ và xây dựng service provider
            var services = new ServiceCollection();

            // Cấu hình dịch vụ DI (trong đó có MainForm) sau khi gọi SetCompatibleTextRenderingDefault
            var serviceProvider = ServiceConfigurator.ConfigureServices(services, configuration);

            // Khởi tạo MainForm bằng DI (Dependency Injection)
            var mainForm = serviceProvider.GetRequiredService<MainForm>();
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            // Chạy ứng dụng với MainForm
            Application.Run(loginForm);
        }
    }
}