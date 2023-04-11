using itog_yc_proect.itDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

namespace itog_yc_proect.Доктор
{
    /// <summary>
    /// Логика взаимодействия для animals.xaml
    /// </summary>
    public partial class animals : Window
    {
        животныеTableAdapter an = new животныеTableAdapter();
        ХозяинTableAdapter x = new ХозяинTableAdapter();
        ХарактеристикаTableAdapter r = new ХарактеристикаTableAdapter();
        видTableAdapter okras = new видTableAdapter();
        public animals()
        {
            InitializeComponent();
            spisok.ItemsSource = an.GetData();
            x_id.ItemsSource = x.GetData();
            x_id.DisplayMemberPath = "имя";
            xar_id.ItemsSource = r.GetData();
            xar_id.DisplayMemberPath = "Характеристика_id";
            clas_id.ItemsSource = okras.GetData();
            clas_id.DisplayMemberPath = "Порода";
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            object x = (x_id.SelectedItem as DataRowView).Row[0];
            object xar = (xar_id.SelectedItem as DataRowView).Row[0];
            object c = (clas_id.SelectedItem as DataRowView).Row[0];
            an.InsertQuery(ima.Text, Convert.ToInt32(x),Convert.ToInt32(xar),Convert.ToInt32(c));
            spisok.ItemsSource = an.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object st = (spisok.SelectedItem as DataRowView).Row[0];
            an.DeleteQuery(Convert.ToInt32(st));
            spisok.ItemsSource = an.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            object st = (spisok.SelectedItem as DataRowView).Row[0];
            object x = (x_id.SelectedItem as DataRowView).Row[0];
            object xar = (xar_id.SelectedItem as DataRowView).Row[0];
            object c = (clas_id.SelectedItem as DataRowView).Row[0];
            an.UpdateQuery(ima.Text, Convert.ToInt32(x), Convert.ToInt32(xar), Convert.ToInt32(c), Convert.ToInt32(st));
            spisok.ItemsSource = an.GetData();
        }

        private void xaract_Click(object sender, RoutedEventArgs e)
        {
            klassif k = new klassif();
            k.Show();
            this.Close();
        }

        private void classific_Click(object sender, RoutedEventArgs e)
        {
            vid kl = new vid();
            kl.Show();
            this.Close();
        }

        private void xozain_Click(object sender, RoutedEventArgs e)
        {
            xoz xa = new xoz();
            xa.Show();
            this.Close();
        }

        private void Vernutsa_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }
    }
}
