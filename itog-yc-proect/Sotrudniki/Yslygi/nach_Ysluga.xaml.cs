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

namespace itog_yc_proect.Sotrudniki.Yslygi
{
    /// <summary>
    /// Логика взаимодействия для nach_Ysluga.xaml
    /// </summary>
    public partial class nach_Ysluga : Window
    {
        УслугаTableAdapter ysl = new УслугаTableAdapter();
        СотрудникTableAdapter sot = new СотрудникTableAdapter();

        public nach_Ysluga()
        {
            InitializeComponent();
            spisok.ItemsSource = ysl.GetData();
            sotrudnik.ItemsSource = sot.GetData();
            sotrudnik.DisplayMemberPath = "ФИО";
        }
        string ch = @"[0-9]";
        string ys =@"[А-я]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (yslugi.Text != "" && chena.Text != "" && sotrudnik.Text != "" && Regex.IsMatch(chena.Text, ch, RegexOptions.IgnoreCase)  && Regex.IsMatch(yslugi.Text, ys, RegexOptions.IgnoreCase))
            {
                object st = (sotrudnik.SelectedItem as DataRowView).Row[0];
                ysl.InsertQuery(Convert.ToInt32(st), yslugi.Text, chena.Text);
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = ysl.GetData();

        }

        private void del_Click_1(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                ysl.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = ysl.GetData();

        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (yslugi.Text != "" && chena.Text != "" && sotrudnik.Text != "" && Regex.IsMatch(chena.Text, ch, RegexOptions.IgnoreCase) && Regex.IsMatch(yslugi.Text, ys, RegexOptions.IgnoreCase))
            {
                object combo = (sotrudnik.SelectedItem as DataRowView).Row[0];
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object id1 = (spisok.SelectedItem as DataRowView).Row[1];
                object id2 = (spisok.SelectedItem as DataRowView).Row[2];
                object id3 = (spisok.SelectedItem as DataRowView).Row[3];
                ysl.UpdateQuery(Convert.ToInt32(combo), yslugi.Text, chena.Text, Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = ysl.GetData();

        }

        private void Vernutsa_Click(object sender, RoutedEventArgs e)
        {
            Window1 cotrydniki = new Window1();
            cotrydniki.Show();
            this.Close();

        }
    }
}
