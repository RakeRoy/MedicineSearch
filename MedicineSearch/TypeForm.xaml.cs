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
    /// Interaction logic for TypeForm.xaml
    /// </summary>
    public partial class TypeForm : Window
    {
        public TypeForm()
        {
            InitializeComponent();
        }

        private void InsertData()
        {
            Objects.Type Obj = new Objects.Type();
            Obj.TypeID = new BLL.Type().GetMaxID();
            Obj.TypeName= txtType.Text;
            int vCheck = new BLL.Type().InsertData(Obj);
            if (vCheck == 1)
            {
                MessageBox.Show("Data Inserted");
            }
        }

        private void TypeBtn(object sender, RoutedEventArgs e)
        {
            InsertData();
        }
    }
}
