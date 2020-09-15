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
    /// Interaction logic for Insert_Data.xaml
    /// </summary>
    public partial class Insert_Data : Window
    {
        public Insert_Data()
        {
            InitializeComponent();
            fillCombo();
        }
        private void fillCombo()
        {
            TypeComboBox.ItemsSource = new BLL.Medicine().GetTypeData().DefaultView;
            TypeComboBox.DisplayMemberPath = "Type";
            TypeComboBox.SelectedValuePath= "TypeID";
            UseComboBox.ItemsSource = new BLL.Medicine().GetUseData().DefaultView;
            UseComboBox.DisplayMemberPath = "Symptom";
            UseComboBox.SelectedValuePath = "SymptomID";
        }

        private void InsertBtn(object sender, RoutedEventArgs e)
        {
            if (checkIfEmpty())
            {
                Objects.Medicine Obj = new Objects.Medicine();
                Obj.MedID = new BLL.Medicine().GetMaxID();
                Obj.MedName = txtMedName.Text;
                Obj.Formula = txtFormula.Text;
                Obj.ExpTime = txtExpiry.Text;
                Obj.TypeID = new BLL.Medicine().GetTypeID(TypeComboBox.Text.ToString());
                Obj.SymptomID = new BLL.Medicine().GetUseID(UseComboBox.Text.ToString());
                Obj.Manufacturer = txtManufacturer.Text;
                Obj.Quantity = Convert.ToInt32(txtQuantity.Text);
                Obj.Price = Convert.ToInt32(txtPrice.Text);
                int vCheck = new BLL.Medicine().InsertData(Obj);
                MessageBox.Show("Data Inserted");

                txtExpiry.Text = "";
                txtQuantity.Text = "";
                txtManufacturer.Text = "";
                txtPrice.Text = "";
                txtFormula.Text = "";
                txtMedName.Text = "";
                TypeComboBox.SelectedIndex = -1;
                UseComboBox.SelectedIndex = -1;

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
    }
}
