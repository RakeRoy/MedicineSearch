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
    /// Interaction logic for FormulaForm.xaml
    /// </summary>
    public partial class FormulaForm : Window
    {
        /*
        public FormulaForm()
        {
            InitializeComponent();
        }

        private void FormulaBtn(object sender, RoutedEventArgs e)
        {
            InsertData();
        }

        private void InsertData()
        {
            Objects.Formula Obj = new Objects.Formula();
            Obj.FormulaID = new BLL.Formula().GetMaxID();
            Obj.FormulaName = txtFormula.Text;
            int vCheck = new BLL.Formula().InsertData(Obj);
            if (vCheck == 1)
            {
                MessageBox.Show("Data Inserted");
            }
        }
        */
    }
}
