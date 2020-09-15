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
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        public UpdateWindow(Objects.Medicine med)
        {
            
            InitializeComponent();
            fillCombo();
            FillForm(med);

        }
        private void fillCombo()
        {
            TypeComboBox.ItemsSource = new BLL.Medicine().GetTypeData().DefaultView;
            TypeComboBox.DisplayMemberPath = "Type";
            TypeComboBox.SelectedValuePath = "TypeID";
            UseComboBox.ItemsSource = new BLL.Medicine().GetUseData().DefaultView;
            UseComboBox.DisplayMemberPath = "Symptom";
            UseComboBox.SelectedValuePath = "SymptomID";
        }

        private void UpdateBtn(object sender, RoutedEventArgs e)
        {
            if (checkIfEmpty())
            {
                Objects.Medicine Obj = new Objects.Medicine();
                //Obj.MedID = new BLL.Medicine().GetMaxID();
                Obj.MedName = txtMedName.Text.ToString();
                Obj.Formula = txtFormula.Text.ToString();
                Obj.ExpTime = txtExpiry.Text.ToString();
                Obj.TypeID = new BLL.Medicine().GetTypeID(TypeComboBox.Text.ToString());
                Obj.SymptomID = new BLL.Medicine().GetUseID(UseComboBox.Text.ToString());
                Obj.Manufacturer = txtManufacturer.Text.ToString();
                Obj.Quantity = Convert.ToInt32(txtQuantity.Text);
                Obj.Price = Convert.ToInt32(txtPrice.Text);
                int vCheck = new BLL.Medicine().UpdateData(Obj);
                MessageBox.Show("Data Updated");

                txtExpiry.Text = "";
                txtQuantity.Text = "";
                txtManufacturer.Text = "";
                txtPrice.Text = "";
                txtFormula.Text = "";
                txtMedName.Text = "";
                TypeComboBox.SelectedIndex = -1;
                UseComboBox.SelectedIndex = -1;
                Close();
            }
            else
                MessageBox.Show("Please Fill All The Inputs.");
            
        }

        private bool checkIfEmpty()
        {
            if (txtMedName.Text.ToString() == "" || txtMedName.Text.Length < 1)
                return false;
            if (txtFormula.Text.ToString() == "" || txtFormula.Text.Length < 1)
                return false;
            if (txtQuantity.Text.ToString() == "" || txtQuantity.Text.Length < 1)
                return false;
            if (txtPrice.Text.ToString() == "" || txtPrice.Text.Length < 1)
                return false;
            if (txtExpiry.Text.ToString() == "" || txtExpiry.Text.Length < 1)
                return false;
            if (txtManufacturer.Text.ToString() == "" || txtExpiry.Text.Length < 1)
                return false;
            if (TypeComboBox.SelectedIndex == -1)
                return false;
            if (UseComboBox.SelectedIndex == -1)
                return false;

            return true;
        }

        private void FillForm(Objects.Medicine med)
        {
            txtMedName.Text = med.MedName;
            txtManufacturer.Text = med.Manufacturer;
            txtQuantity.Text = med.Quantity.ToString();
            txtPrice.Text = med.Price.ToString();
            txtFormula.Text = med.Formula.ToString();
            txtExpiry.Text = med.ExpTime.ToString();
            TypeComboBox.SelectedIndex = med.TypeID - 1;
            UseComboBox.SelectedIndex = med.SymptomID-1;
        }
    }
}
