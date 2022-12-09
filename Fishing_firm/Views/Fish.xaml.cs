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
    /// Логика взаимодействия для Fish.xaml
    /// </summary>
    public partial class Fish : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public Fish()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.Fish.GetAllFish(trackChanges: false);
            comboBoxColumFishing.ItemsSource = repo.Fishing.GetAllFishings(trackChanges: false);
            comboBoxColumPlace.ItemsSource = repo.Places.GetAllPlaces(trackChanges: false);
            comboBoxColumSpecies.ItemsSource = repo.FishTypes.GetAllTypes(trackChanges: false);
        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Fish.CreateFish((Fishing_firm.Entities.Models.Fish)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Fish.GetAllFish(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var fish = repo.Fish.GetFish(((Fishing_firm.Entities.Models.Fish)humanGrid.SelectedItem).Id, true);
            repo.Fish.DeleteFish(fish);
            humanGrid.ItemsSource = repo.Fish.GetAllFish(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Fish.UpdateFish((Fishing_firm.Entities.Models.Fish)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Fish.GetAllFish(trackChanges: false);
        }
    }
}

