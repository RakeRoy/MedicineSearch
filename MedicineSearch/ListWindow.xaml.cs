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
using System.Data;

namespace MedicineSearch
{
    
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        private int counter;

        public ListWindow()
        {
            InitializeComponent();
            formload();
        }


        public void clearAll()
        {
            Search_Formula.Clear();
            Search_Manufacturer.Clear();
            Search_Name.Clear();
            Search_Symptom.Clear();
        }


        private void formload()
        {
            counter = 1;
            txtQuantity.Text = counter.ToString();
            

            Objects.Medicine Obj = new Objects.Medicine();
            DataTable dt = new DataTable();
            dt = new BLL.Medicine().formload(Obj);
            MedicineGrid.ItemsSource = dt.AsDataView();
        }

        private void FormulaBtn(object sender, RoutedEventArgs e)
        {
            Objects.Medicine Obj = new Objects.Medicine();
            DataTable dt = new DataTable();
            dt = new BLL.Medicine().formloadFormula(Obj, Search_Formula.Text.ToString());

            MedicineGrid.ItemsSource = dt.AsDataView();
            clearAll();
            
        }

        private void NameBtn(object sender, RoutedEventArgs e)
        {
            Objects.Medicine Obj = new Objects.Medicine();
            DataTable dt = new DataTable();
            dt = new BLL.Medicine().formloadName(Obj, Search_Name.Text);

            MedicineGrid.ItemsSource = dt.AsDataView();

            clearAll();
        }

        private void ManufacturerBtn(object sender, RoutedEventArgs e)
        {
            Objects.Medicine Obj = new Objects.Medicine();
            DataTable dt = new DataTable();
            dt = new BLL.Medicine().formloadManufacturer(Obj, Search_Manufacturer.Text.ToString());

            MedicineGrid.ItemsSource = dt.AsDataView();
            clearAll();
        }

        private void SymptomBtn(object sender, RoutedEventArgs e)
        {
            Objects.Medicine Obj = new Objects.Medicine();
            DataTable dt = new DataTable();
            dt = new BLL.Medicine().formloadSymptom(Obj, Search_Symptom.Text.ToString());

            MedicineGrid.ItemsSource = dt.AsDataView();
            clearAll();
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {
            formload();
        }

        private void BuyBtn(object sender, RoutedEventArgs e)
        {
            string MedName;
            BLL.Medicine Obj = new BLL.Medicine();
            int Quantity = Convert.ToInt32(txtQuantity.Text.ToString());
            if(MedicineGrid.SelectedIndex != -1)
            {
                DataRowView rows = (DataRowView)MedicineGrid.SelectedItems[0];
                MedName = rows["Medicine_Name"].ToString();
                int totalPrice = Obj.getPrice(MedName, Quantity) * Quantity;
                MessageBox.Show("Item: " + MedName + "\nQuantity: " + Quantity + "\nTotal Payment: Rs. "
                    + totalPrice + "\nThanks for purchasing");
                Obj.BuyMedicine(MedName, Quantity);
                formload();
            }
            else
            {
                MessageBox.Show("Please select an entry from the table.");
            }
        }

        private void UpBtn(object sender, RoutedEventArgs e)
        {
            counter++;
            txtQuantity.Text = counter.ToString();
        }
        private void DownBtn(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(txtQuantity.Text) > 0)
                counter--;
            txtQuantity.Text = counter.ToString();
        }

        private void SymptomEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                SymptomBtn(this, new RoutedEventArgs());
            }
        }

        private void NameEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                NameBtn(this, new RoutedEventArgs());
            }
        }

        private void ManufacturerEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ManufacturerBtn(this, new RoutedEventArgs());
            }
        }

        private void FormulaEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                FormulaBtn(this, new RoutedEventArgs());
            }
        }

        private void MedicineGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (MedicineGrid.SelectedIndex != -1)
            {
                BLL.Medicine Obj = new BLL.Medicine();
                Objects.Medicine med = new Objects.Medicine();
                string MedName;
                DataRowView rows = (DataRowView)MedicineGrid.SelectedItems[0];
                MedName = rows["Medicine_Name"].ToString();

                med = Obj.getRow(MedName);
                new UpdateWindow(med).Show();
            }
            else
            {
                MessageBox.Show("Please select an entry from the table.");
            }
        }

        private void MedicineGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F)
            {
                string MedName;
                BLL.Medicine Obj = new BLL.Medicine();
                int Quantity = Convert.ToInt32(txtQuantity.Text.ToString());
                if (MedicineGrid.SelectedIndex != -1)
                {
                    DataRowView rows = (DataRowView)MedicineGrid.SelectedItems[0];
                    MedName = rows["Medicine_Name"].ToString();
                    int vCheck = Obj.DeleteData(MedName);
                    MessageBox.Show("Entry Deleted");
                    formload();
                }
                else
                {
                    MessageBox.Show("Please select an entry from the table.");
                }
            }
        }
    }
}

    
















