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
    /// Логика взаимодействия для CaterType.xaml
    /// </summary>
    public partial class CaterType : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public CaterType()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.CaterTypes.GetAllTypes(trackChanges: false);
        }

        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.CaterTypes.CreateCaterType((Fishing_firm.Entities.Models.CaterType)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.CaterTypes.GetAllTypes(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var type = repo.CaterTypes.GetType(((Fishing_firm.Entities.Models.CaterType)humanGrid.SelectedItem).Id, true);
            repo.CaterTypes.DeleteCaterType(type);
            humanGrid.ItemsSource = repo.CaterTypes.GetAllTypes(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.CaterTypes.UpdateCaterType((Fishing_firm.Entities.Models.CaterType)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.CaterTypes.GetAllTypes(trackChanges: false);
        }
    }
}
