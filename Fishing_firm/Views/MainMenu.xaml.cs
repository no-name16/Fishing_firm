using Fishing_firm.Entities;
using Fishing_firm.Repository;
using System.Windows;

namespace Fishing_firm.Views
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            FishingFirmContext db = new FishingFirmContext();
            RepositoryManager repo = new RepositoryManager(db);
            repo.Fish.GetAllFish(false);
            repo.Fishing.GetAllFishings(false);
            repo.Teams.GetAllTeams(false);
            repo.Caters.GetAllCaters(false);
        }

        private void human_Click(object sender, RoutedEventArgs e)
        {
            Human window = new Human();
            window.Show();
            this.Close();
        }

        private void team_Click(object sender, RoutedEventArgs e)
        {
            Team window = new Team();
            window.Show();
            this.Close();
        }

        private void cater_Click(object sender, RoutedEventArgs e)
        {
            Cater window = new Cater();
            window.Show();
            this.Close();
        }

        private void cater_type_Click(object sender, RoutedEventArgs e)
        {
            CaterType window = new CaterType();
            window.Show();
            this.Close();
        }

        private void fishing_Click(object sender, RoutedEventArgs e)
        {
            Fishing window = new Fishing();
            window.Show();
            this.Close();
        }

        private void fish_type_Click(object sender, RoutedEventArgs e)
        {
            FishType window = new FishType();
            window.Show();
            this.Close();
        }

        private void place_Click(object sender, RoutedEventArgs e)
        {
            Place window = new Place();
            window.Show();
            this.Close();
        }

        private void tecreview_Click(object sender, RoutedEventArgs e)
        {
            Tecreview window = new Tecreview();
            window.Show();
            this.Close();
        }

        private void close_app(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void fish_Click(object sender, RoutedEventArgs e)
        {
            Fish window = new Fish();
            window.Show();
            this.Close();
        }
    }
}
