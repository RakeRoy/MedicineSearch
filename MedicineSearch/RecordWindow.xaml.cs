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
    /// Interaction logic for RecordWindow.xaml
    /// </summary>
    public partial class RecordWindow : Window
    {
        DataTable dt;
        public RecordWindow()
        {
            InitializeComponent();
            formload();
        }

        private void F5Refresh(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.F5)
            formload();
        }
        private void formload()
        {


//            Objects.Record Obj = new Objects.Record();
            DataTable dt = new DataTable();
            dt = new BLL.Record().formload();
            RecordGrid.ItemsSource = dt.AsDataView();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            formload();
        }

        private void TxtRecName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                SearchRecName(txtRecName.Text.ToString());
        }

        private void SearchRecName(string Medicine)
        {
            DataTable dt = new DataTable();
            dt = new BLL.Record().SearchByName(Medicine);
            RecordGrid.ItemsSource = dt.AsDataView();
        }

        /*
        private void RecDatePicker_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                MessageBox.Show(RecDatePicker.ToString());
                DataTable dt = new DataTable();
                dt = new BLL.Record().SearchByDate(RecDatePicker.SelectedDate.Value);
                RecordGrid.ItemsSource = dt.AsDataView();
            }
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //RecDatePicker_KeyDown(new object(), new KeyEventArgs ());
            //MessageBox.Show(RecDatePicker.SelectedDate.Value.ToString());
           
            DateTime dateTime = new DateTime();
            dateTime = Convert.ToDateTime(RecDatePicker.SelectedDate.Value.ToString());
            String.Format("{0:u}", dateTime);
            MessageBox.Show(dateTime.ToString());

            DataTable dt = new DataTable();
            dt = new BLL.Record().SearchByDate(RecDatePicker.SelectedDate.Value);
            RecordGrid.ItemsSource = dt.AsDataView();
        } */
    }
}
