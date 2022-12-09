using ECoSCore;
using Fishing_firm.Entities;
using Fishing_firm.Entities.Models;
using Fishing_firm.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fishing_firm.Views
{
    /// <summary>
    /// Логика взаимодействия для Fishing.xaml
    /// </summary>
    public partial class Fishing : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        FishingBinding bind = new FishingBinding();
        public Fishing()
        {
            InitializeComponent();
            humanGrid.ItemsSource = bind.GetAllFishingBindings(false);
            comboBoxColumTeam.ItemsSource = repo.Teams.GetAllTeams(trackChanges: false);
            comboBoxColumCater.ItemsSource = repo.Caters.GetAllCaters(trackChanges: false);
        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Fishing.CreateFishing((Fishing_firm.Entities.Models.Fishing)humanGrid.SelectedItem);
            humanGrid.ItemsSource = bind.GetAllFishingBindings(false);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var type = repo.Fishing.GetFishing(((Fishing_firm.Entities.Models.Fishing)humanGrid.SelectedItem).Id, true);
            repo.Fishing.DeleteFishing(type);
            humanGrid.ItemsSource = bind.GetAllFishingBindings(false);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Fishing.UpdateFishing((Fishing_firm.Entities.Models.Fishing)humanGrid.SelectedItem);
            humanGrid.ItemsSource = bind.GetAllFishingBindings(false);
        }
    }
}


