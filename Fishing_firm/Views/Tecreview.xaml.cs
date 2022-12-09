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
    /// Логика взаимодействия для Tecreview.xaml
    /// </summary>
    public partial class Tecreview : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        public Tecreview()
        {
            InitializeComponent();
            humanGrid.ItemsSource = repo.TecReview.GetAllTecReview(trackChanges: false);
            comboBoxColum.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.TecReview.CreateTecReview((Fishing_firm.Entities.Models.TecReview)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.TecReview.GetAllTecReview(trackChanges: false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var team = repo.TecReview.GetTecReview(((Fishing_firm.Entities.Models.TecReview)humanGrid.SelectedItem).Id, true);
            repo.TecReview.DeleteTecReview(team);
            humanGrid.ItemsSource = repo.TecReview.GetAllTecReview(trackChanges: false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.TecReview.CreateTecReview((Fishing_firm.Entities.Models.TecReview)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.TecReview.GetAllTecReview(trackChanges: false);
        }
    }
}
