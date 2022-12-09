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
    /// Логика взаимодействия для FishType.xaml
    /// </summary>
    public partial class FishType : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public FishType()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.FishTypes.GetAllTypes(trackChanges: false);

        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }


        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.FishTypes.CreateFishType((Fishing_firm.Entities.Models.FishSpecies)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.FishTypes.GetAllTypes(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var type = repo.FishTypes.GetType(((Fishing_firm.Entities.Models.FishSpecies)humanGrid.SelectedItem).Id, true);
            repo.FishTypes.DeleteFishType(type);
            humanGrid.ItemsSource = repo.FishTypes.GetAllTypes(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.FishTypes.UpdateFishType((Fishing_firm.Entities.Models.FishSpecies)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.FishTypes.GetAllTypes(trackChanges: false);
        }
    }
}
