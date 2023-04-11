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
    /// Логика взаимодействия для klassif.xaml
    /// </summary>
    public partial class klassif : Window
    {
        ХарактеристикаTableAdapter xr = new ХарактеристикаTableAdapter();
        окрасTableAdapter statys = new окрасTableAdapter();
        public klassif()
        {
            InitializeComponent();
            spisok.ItemsSource = xr.GetData();
            okr.ItemsSource = statys.GetData();
            okr.DisplayMemberPath = "цвет";
        }

        private void vid_Click(object sender, RoutedEventArgs e)
        {
           ok b = new ok();
            b.Show();
            this.Close();
        }
        string r = @"[0-9]";
        string v = @"[0-9]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (rost.Text != "" && ves.Text != "" && old.Text != "" && okr.Text !="" && Regex.IsMatch(rost.Text, r, RegexOptions.IgnoreCase) && Regex.IsMatch(ves.Text, r, RegexOptions.IgnoreCase) && Regex.IsMatch(old.Text, v, RegexOptions.IgnoreCase))
            {
                object st = (okr.SelectedItem as DataRowView).Row[0];
                xr.InsertQuery(rost.Text, ves.Text, old.Text, Convert.ToInt32(st));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = xr.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (spisok.SelectedItem as DataRowView).Row[0];
            xr.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = xr.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (rost.Text != "" && ves.Text != "" && old.Text != "" && okr.Text != "")
            {
                object st = (okr.SelectedItem as DataRowView).Row[0];
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                xr.UpdateQuery(rost.Text, ves.Text, old.Text, Convert.ToInt32(st),Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = xr.GetData();
        }

        private void Vernutsa_Click(object sender, RoutedEventArgs e)
        {
            animals w = new animals();
            w.Show();
            this.Close();
        }
    }
}
