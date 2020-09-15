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

namespace MedicineSearch
{
    /// <summary>
    /// Interaction logic for ControlPanel.xaml
    /// </summary>
    public partial class ControlPanel : Window
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void UseBtn(object sender, RoutedEventArgs e)
        {
            new SymptomForm().Show();
        }

        private void FormulaBtn(object sender, RoutedEventArgs e)
        {
            new FormulaForm().Show();
        }

        private void ManufBtn(object sender, RoutedEventArgs e)
        {
            new ManufacturerForm().Show();
        }

        private void TypeBtn(object sender, RoutedEventArgs e)
        {
            new TypeForm().Show();
        }

        //Exit Button
        private void HeaderBtn(object sender, RoutedEventArgs e)
        {
            new SymptomForm().Show();
        }

        private void ShowBtn(object sender, RoutedEventArgs e)
        {

            new ListWindow().Show();
            //Close();
        }

        private void ExitBtn(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InsertShowBtn(object sender, RoutedEventArgs e)
        {
            new Insert_Data().Show();
        }

        private void RegisterBtn(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
        }

        private void LogoutBtn(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            Close();
        }

        private void RecordsBtn(object sender, RoutedEventArgs e)
        {
            new RecordWindow().Show();
        }

        private void AboutUsBtn(object sender, RoutedEventArgs e)
        {
            new AboutUs().Show();
        }
    }
}
