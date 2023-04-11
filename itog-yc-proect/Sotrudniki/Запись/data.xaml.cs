using itog_yc_proect.itDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace itog_yc_proect.Sotrudniki.Запись
{
    /// <summary>
    /// Логика взаимодействия для data.xaml
    /// </summary>
    public partial class data : Window
    {
        Дата_ПриёмаTableAdapter d = new Дата_ПриёмаTableAdapter();
        public data()
        {
            InitializeComponent();
            spisok.ItemsSource = d.GetData();
        }
        string dat = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d";
        string vr = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (date.Text != "" && vrema.Text != "" && cab.Text != "" && Regex.IsMatch(date.Text, dat, RegexOptions.IgnoreCase) && Regex.IsMatch(vrema.Text, vr, RegexOptions.IgnoreCase))
            {
                d.InsertQuery(date.Text, vrema.Text, cab.Text);

            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = d.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            if (date.Text != "" && vrema.Text != "" && cab.Text != "")
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                d.DeleteQuery(Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = d.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (date.Text != "" && vrema.Text != "" && cab.Text != "" && Regex.IsMatch(date.Text, dat, RegexOptions.IgnoreCase) && Regex.IsMatch(vrema.Text, vr, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object id1 = (spisok.SelectedItem as DataRowView).Row[1];
                object id2 = (spisok.SelectedItem as DataRowView).Row[2];
                object id3 = (spisok.SelectedItem as DataRowView).Row[3];
                d.UpdateQuery(date.Text, vrema.Text, cab.Text, Convert.ToInt32(id));

            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = d.GetData();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Window1 cotrydniki = new Window1();
            cotrydniki.Show();
            this.Close();
        }
    }
}
