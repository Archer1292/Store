using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using StoreLibrary;


namespace Store
{
    /// <summary>
    /// Interaction logic for testDB.xaml
    /// </summary>
    public partial class testDB : Window
    {
        string connectionString;
        SqlDataAdapter adapter;
        DataTable usersTable;
        public testDB()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter);
            adapter.Update(usersTable);
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Implement impl = new Implement();
            
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = Employee.AllItems.ToString();
        }
    }
}
