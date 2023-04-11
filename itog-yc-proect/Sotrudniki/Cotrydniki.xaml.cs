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
using itog_yc_proect.itDataSetTableAdapters;
using itog_yc_proect.Properties;
using System.Text.RegularExpressions;
using System.IO;

namespace itog_yc_proect
{
    /// <summary>
    /// Логика взаимодействия для Cotrydniki.xaml
    /// </summary>
    public partial class Cotrydniki : Window
    {
        СотрудникTableAdapter sotrudniks = new СотрудникTableAdapter();
        АккаунтTableAdapter ac = new АккаунтTableAdapter();
        public Cotrydniki()
        {
            InitializeComponent();
            spisok.ItemsSource = sotrudniks.GetData();
            spi.ItemsSource = ac.GetData();
            spi.DisplayMemberPath = "Логин";
        }
        string n = @"^[A-Я]";
        string p = @"[0-9]{3}-[0-9]{3}-[0-9]{4}";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (FIO.Text !="" && Telefon.Text !="" && spi.Text !="" && Regex.IsMatch(FIO.Text, p, RegexOptions.IgnoreCase) && Regex.IsMatch(Telefon.Text, n, RegexOptions.IgnoreCase))
            {
                    object st = (spi.SelectedItem as DataRowView).Row[0];
                    sotrudniks.InsertQuery(FIO.Text, Telefon.Text, Convert.ToInt32(st));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            
            spisok.ItemsSource = sotrudniks.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
            sotrudniks.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = sotrudniks.GetData();
        }

        private void accauunt_Click(object sender, RoutedEventArgs e)
        {
            ACCAUNT ac = new ACCAUNT();
            ac.Show();
            this.Close();

        }
        private void Status_Click(object sender, RoutedEventArgs e)
        {
            Status st = new Status();
            st.Show();
            this.Close();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (FIO.Text != "" && Telefon.Text != "" && spi.Text != "" && Regex.IsMatch(FIO.Text, p, RegexOptions.IgnoreCase) && Regex.IsMatch(Telefon.Text, n, RegexOptions.IgnoreCase))
            {
                object combo = (spi.SelectedItem as DataRowView).Row[0];
            object id = (spisok.SelectedItem as DataRowView).Row[0];
            sotrudniks.UpdateQuery(FIO.Text, Telefon.Text, Convert.ToInt32(combo), Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = sotrudniks.GetData();
        }

        private void Vernutsa_Click(object sender, RoutedEventArgs e)
        {
            Window1 cotrydniki = new Window1();
            cotrydniki.Show();
            this.Close();
        }
    }
}
