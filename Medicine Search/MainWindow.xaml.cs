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

namespace Medicine_Search
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            List<User> items = new List<User>();
            items.Add(new User() { Medicine = "Panadol", Type= "Tablet", Formula= "C8H9NO2", Manufacturer = "McNeil Healthcare", Use = "Painkiller", ExpTime="2 Years" });                 
            items.Add(new User() { Medicine = "DIV", Type= "Injection", Formula= "CH696", Manufacturer = "McNeil Healthcare", Use = "Painkiller", ExpTime="2 Years" });                 

            Medicine_ListView.ItemsSource = items;
        }
    }
    public class User
    {
        public string medicine, formula, type, manufacturer, expTime, use;
        public string Medicine { get; set; }

        public string Formula { get; set; }

        public string Manufacturer { get; set; }

        public string Type{ get; set; }

        public string ExpTime{ get; set; }

        public string Use{ get; set; }
    }
}

