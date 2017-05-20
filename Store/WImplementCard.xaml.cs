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
    /// Логика взаимодействия для WImplementCard.xaml
    /// </summary>
    public partial class WImplementCard : Window
    {
        public WImplementCard()
        {
            InitializeComponent();
            Binding binding = new Binding();

            binding.ElementName = "Storage"; // элемент-источник
            binding.Source = Storage.AllItems; // свойство элемента-источника
            cbStorage.SetBinding(TextBlock.TextProperty, binding); // установка привязки для элемента-приемника
        }
        
    }
}
