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

namespace itog_yc_proect.Доктор
{
    /// <summary>
    /// Логика взаимодействия для zap.xaml
    /// </summary>
    public partial class zap : Window
    {
        Дата_ПриёмаTableAdapter dat = new Дата_ПриёмаTableAdapter();
        public zap()
        {
            InitializeComponent();
            spisok.ItemsSource = dat.GetData();
        }
        string da = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d";
        string vr = @"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (date.Text != "" && vrema.Text != "" && cab.Text != "" && Regex.IsMatch(date.Text, da, RegexOptions.IgnoreCase)
                && Regex.IsMatch(vrema.Text, vr, RegexOptions.IgnoreCase))
            {
                dat.InsertQuery(date.Text, vrema.Text, cab.Text);

            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = dat.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                dat.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = dat.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (date.Text != "" && vrema.Text != "" && cab.Text != "" && Regex.IsMatch(date.Text, da, RegexOptions.IgnoreCase) && Regex.IsMatch(vrema.Text, vr, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object id1 = (spisok.SelectedItem as DataRowView).Row[1];
                object id2 = (spisok.SelectedItem as DataRowView).Row[2];
                object id3 = (spisok.SelectedItem as DataRowView).Row[3];
                dat.UpdateQuery(date.Text, vrema.Text, cab.Text, Convert.ToInt32(id));

            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = dat.GetData();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }
    }
}
