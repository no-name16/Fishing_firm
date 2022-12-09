using Fishing_firm.Entities;
using Fishing_firm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fishing_firm.Views
{
    /// <summary>
    /// Логика взаимодействия для Cater.xaml
    /// </summary>
    public partial class Cater : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public Cater()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
            comboBoxColum.ItemsSource = repo.CaterTypes.GetAllTypes(trackChanges: false);

        }

        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Caters.CreateCater((Fishing_firm.Entities.Models.Cater)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var type = repo.Caters.GetCater(((Fishing_firm.Entities.Models.Cater)humanGrid.SelectedItem).Id, true);
            repo.Caters.DeleteCater(type);
            humanGrid.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Caters.UpdateCater((Fishing_firm.Entities.Models.Cater)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
        }
    }

}
