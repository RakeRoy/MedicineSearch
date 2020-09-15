using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MedicineSearch
{
    /// <summary>
    /// Interaction logic for BuyForm.xaml
    /// </summary>
    public partial class BuyForm : Window
    {
        public BuyForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            //DataRowView row = ListWindow.MedicineGrid.SelectedItems[0];
        }
    }
}
