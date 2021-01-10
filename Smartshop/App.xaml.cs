using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Smartshop.Data;

namespace Smartshop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IConfiguration Configuration { get; private set; }
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", false, true);

            Configuration = builder.Build();

            var services = new ServiceCollection();
            ConfigureServices(services);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            ServiceProvider = services.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
            services.AddTransient<SmartshopDbContext>();
        }
    }
}
