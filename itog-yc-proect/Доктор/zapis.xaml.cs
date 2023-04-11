using itog_yc_proect.itDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace itog_yc_proect.Доктор
{
    /// <summary>
    /// Логика взаимодействия для zapis.xaml
    /// </summary>
    public partial class zapis : Window
    {
        записьTableAdapter z = new записьTableAdapter();
        животныеTableAdapter g = new животныеTableAdapter();
        Дата_ПриёмаTableAdapter d = new Дата_ПриёмаTableAdapter();
        УслугаTableAdapter y = new УслугаTableAdapter();
        public zapis()
        {
            InitializeComponent();
            spisok.ItemsSource = z.GetData();
            pet.ItemsSource = g.GetData();
            pet.DisplayMemberPath = "имя";
            date.ItemsSource = d.GetData();
            date.DisplayMemberPath = "Дата";
            ysl.ItemsSource = y.GetData();
            ysl.DisplayMemberPath = "Наименование_услуги";
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (spisok.SelectedItem as DataRowView).Row[0];
            z.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = z.GetData();
        }

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            object st = (pet.SelectedItem as DataRowView).Row[0];
            object st1 = (date.SelectedItem as DataRowView).Row[0];
            object st2 = (ysl.SelectedItem as DataRowView).Row[0];
            z.InsertQuery(Convert.ToInt32(st),Convert.ToInt32(st1),Convert.ToInt32(st2));
            spisok.ItemsSource = z.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            object id = (spisok.SelectedItem as DataRowView).Row[0];
            object st = (pet.SelectedItem as DataRowView).Row[0];
            object st1 = (date.SelectedItem as DataRowView).Row[0];
            object st2 = (ysl.SelectedItem as DataRowView).Row[0];
            z.UpdateQuery(Convert.ToInt32(st), Convert.ToInt32(st1), Convert.ToInt32(st2), Convert.ToInt32(id));
            spisok.ItemsSource = z.GetData();
        }

        private void Vernutsa_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }
    }
}
