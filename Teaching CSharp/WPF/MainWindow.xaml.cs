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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listings.ItemsSource = PhoneBook.Entries;
        }

        private void AddNewUser_Click(object sender, RoutedEventArgs e)
        {
            PhoneBook.Entries.Add(new PhoneBookEntry(lastName.Text, firstName.Text, phoneNumber.Text));
            RefreshListings();
            MessageBox.Show(firstName.Text + " " + lastName.Text + " has been added to the phone book");
        }

        private void RemoveSelectedUser_Click(object sender, RoutedEventArgs e)
        {
            if (listings.SelectedItem != null)
            {
                PhoneBook.Entries.Remove((PhoneBookEntry)listings.SelectedItem);
                RefreshListings();
                MessageBox.Show("Listing removed");
            }
            else
            {
                MessageBox.Show("Please select a listing to remove");
            }
        }

        private void RefreshListings()
        {
            listings.ItemsSource = PhoneBook.Entries.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            searchResults.ItemsSource = PhoneBook.SearchByLastName(toSearch.Text);
        }
    }
}
