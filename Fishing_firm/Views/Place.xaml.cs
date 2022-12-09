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
    /// Логика взаимодействия для Place.xaml
    /// </summary>
    public partial class Place : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public Place()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.Places.GetAllPlaces(trackChanges: false);
        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Places.CreatePlace((Fishing_firm.Entities.Models.Place)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Places.GetAllPlaces(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var type = repo.Places.GetPlace(((Fishing_firm.Entities.Models.Place)humanGrid.SelectedItem).Id, true);
            repo.Places.DeletePlace(type);
            humanGrid.ItemsSource = repo.Places.GetAllPlaces(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Places.UpdatePlace((Fishing_firm.Entities.Models.Place)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Places.GetAllPlaces(trackChanges: false);
        }
    }
}
