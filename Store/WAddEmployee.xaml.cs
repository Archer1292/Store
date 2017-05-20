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

namespace Store
{
    /// <summary>
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public Employees()
        {
            InitializeComponent();
            
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            //Employee e1 = new Employee(tbFirstName.Text, tbLastName.Text);
            
            //e1.Unit.Id =Guid.Parse(tbEmployeeUnit.Text);
            //Refresh_lbEmployees();
            
            
        }
        //TODO сделать привязку к данным
        private void Refresh_lbEmployees()
        {
            //lbEmployees.ItemsSource = null;
           // lbEmployees.ItemsSource = Employee.Employees;
        }
    }
}
