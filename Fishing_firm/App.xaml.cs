using Fishing_firm.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Fishing_firm
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Thread thread = new Thread(
                new System.Threading.ThreadStart(
                    delegate ()
                    {
                        MainWindow window = new MainWindow();
                        window.Show();
                        System.Windows.Threading.Dispatcher.Run();
                    }
                ));
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();
            var application = new MainMenu();
            application.InitializeComponent();
            thread.Abort();
            application.Show();
            application.Activate();
        }
    }
}

