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

namespace itog_yc_proect
{
    /// <summary>
    /// Логика взаимодействия для Status.xaml
    /// </summary>
    public partial class Status : Window
    {
        статусTableAdapter statustab = new статусTableAdapter();
        public Status()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Роль");
            spisok.ItemsSource = statustab.GetData();
        }
        string pat = @"[А-я]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (Rolsot.Text != "" && Regex.IsMatch(Rolsot.Text, pat, RegexOptions.IgnoreCase))
            {
                statustab.InsertQuery(Rolsot.Text);
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = statustab.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                statustab.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = statustab.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (Rolsot.Text != "" && Regex.IsMatch(Rolsot.Text, pat, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object ids = (spisok.SelectedItem as DataRowView).Row[1];
                statustab.UpdateQuery(Rolsot.Text, Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = statustab.GetData();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Cotrydniki cotrydniki = new Cotrydniki();
            cotrydniki.Show();
            this.Close();
        }
    }
}
