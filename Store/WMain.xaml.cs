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
using System.Data.SqlClient;
using System.Data;
using StoreLibrary;
using System.Configuration;
using System.Data.Entity;
using System.Windows;


namespace Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StoreContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new StoreContext();
            db.Implements.Load();// загружаем данные
            gridImplements.ItemsSource = db.Implements.Local.ToBindingList();// устанавливаем привязку к кэшу
            this.Closing += Window_Closing;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void gridStorages_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
