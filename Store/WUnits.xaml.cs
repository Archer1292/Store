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
using StoreLibrary;

namespace Store
{
    /// <summary>
    /// Interaction logic for WUnits.xaml
    /// </summary>
    public partial class WUnits : Window
    {
        public WUnits()
        {
            InitializeComponent();
        }
        
        private void lbUnitName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (cbParent.SelectedItem != null)
            {

            }
            //CompanyUnit u1 = new CompanyUnit();
            //u1.Name = tbUnitName.Text;
            //if (tbParentUnit.Text == "" | tbParentUnit.Text == null) u1.ParentUnit = null;
            //else {
            //    u1.ParentUnit = (CompanyUnit.Units.Find(x => x.Name == tbParentUnit.Text));
            //}
        }
    }
}
