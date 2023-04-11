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
    /// Логика взаимодействия для ok.xaml
    /// </summary>
    public partial class ok : Window
    {
        окрасTableAdapter o = new окрасTableAdapter();
        public ok()
        {
            InitializeComponent();
            spisok.ItemsSource = o.GetData();
        }
        string oks = @"[А-я]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (color.Text != "" && nazv.Text != "" && Regex.IsMatch(color.Text, oks, RegexOptions.IgnoreCase) && Regex.IsMatch(nazv.Text, oks, RegexOptions.IgnoreCase))
            {
                o.InsertQuery(nazv.Text,color.Text );
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = o.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                o.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = o.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (color.Text != "" && nazv.Text != "" && Regex.IsMatch(color.Text, oks, RegexOptions.IgnoreCase) && Regex.IsMatch(nazv.Text, oks, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object id1 = (spisok.SelectedItem as DataRowView).Row[1];
                object id2 = (spisok.SelectedItem as DataRowView).Row[2];
                o.UpdateQuery(nazv.Text,color.Text,Convert.ToInt32(id));
                spisok.ItemsSource = o.GetData();
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            klassif k = new klassif();
            k.Show();
            this.Close();
        }
    }
}
