using Fishing_firm.Entities;
using Fishing_firm.Repository;
using System;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fishing_firm.Views
{
    /// <summary>
    /// Логика взаимодействия для Human.xaml
    /// </summary>
    public partial class Human : Window
    {
        static FishingFirmContext db = new FishingFirmContext();
        RepositoryManager repo = new RepositoryManager(db);
        String teamName;
        public Human()
        {
            InitializeComponent();
            db = new FishingFirmContext();
            humanGrid.ItemsSource = repo.Humans.GetAllHumans(trackChanges: false);
            comboBoxColum.ItemsSource = repo.Teams.GetAllTeams(trackChanges: false);
            //if (readers.TblBooks != null)
            //{
            //    bookid = readers.BookId.ToString();
            //}
            //Id = userId;

        }
        private void CloseApp(object sender, MouseButtonEventArgs e)
        {
            MainMenu window = new MainMenu();
            window.Show();
            this.Close();
        }

        private void addHuman_Click(object sender, RoutedEventArgs e)
        {
            var human = (Fishing_firm.Entities.Models.Human)humanGrid.SelectedItem;
            repo.Humans.CreateHuman(human);
            humanGrid.ItemsSource = repo.Humans.GetAllHumans(trackChanges: true);
        }

        private void deleteHuman_Click(object sender, RoutedEventArgs e)
        {
            var human = repo.Humans.GetHumans(((Fishing_firm.Entities.Models.Human)humanGrid.SelectedItem).Id, true);
            repo.Humans.DeleteHuman(human);
            humanGrid.ItemsSource = repo.Humans.GetAllHumans(trackChanges: true);
        }

        private void updateHuman_Click(object sender, RoutedEventArgs e)
        {
            repo.Humans.UpdateHuman((Fishing_firm.Entities.Models.Human)humanGrid.SelectedItem);
            humanGrid.ItemsSource = repo.Humans.GetAllHumans(trackChanges: true);
        }
        private void ComboBook_Selected_1(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            String selectedItem = (String)comboBox.SelectedItem;
            teamName = selectedItem;
        }
    }
}
