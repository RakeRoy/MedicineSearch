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
    /// Interaction logic for SymptomForm.xaml
    /// </summary>
    public partial class SymptomForm : Window
    {
        public SymptomForm()
        {
            InitializeComponent();
        }

        private void InsertData()
        {
            Objects.Symptom Obj = new Objects.Symptom();
            Obj.SymptomID = new BLL.Symptom().GetMaxID();
            Obj.SympName = txtSymptomName.Text;
            int vCheck = new BLL.Symptom().InsertData(Obj);
            if (vCheck == 1)
            {
                MessageBox.Show("Data Inserted");
            }
        }

        private void SympBtn(object sender, RoutedEventArgs e)
        {
            InsertData();
        }
    }
}
