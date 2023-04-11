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

namespace itog_yc_proect.Properties
{
    /// <summary>
    /// Логика взаимодействия для ACCAUNT.xaml
    /// </summary>
    public partial class ACCAUNT : Window
    {
        АккаунтTableAdapter ac = new АккаунтTableAdapter();
        статусTableAdapter status = new статусTableAdapter();
        // Text="Binding Path=SelectedItem.Логин, ElementName=spisok}"
        public class PersonModel
        {
            public string login { get; set; }
            public int Age { get; set; }
            public string Position { get; set; }
        }PersonModel Tom;
        public ACCAUNT()
        {
            InitializeComponent();
                Tom = new PersonModel();
                this.DataContext = Tom;
            
            spisok.ItemsSource = ac.GetData();
            statys.ItemsSource = status.GetData();
            statys.DisplayMemberPath = "Роль";
        }
        string pattern = @"^[a-zA-Z][a-zA-Z0-9-_\.]{1,20}$";
            string pattern1 = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && paroli.Text != "" && statys.Text != "" && Regex.IsMatch(login.Text, pattern, RegexOptions.IgnoreCase) && Regex.IsMatch(paroli.Text, pattern1, RegexOptions.IgnoreCase))
            {
                object st = (statys.SelectedItem as DataRowView).Row[0];
                ac.InsertQuery(login.Text, paroli.Text, Convert.ToInt32(st));
            }
            else
            {
                Error er = new Error();
                er.Show();
            } 
            spisok.ItemsSource = ac.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                ac.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = ac.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && paroli.Text != "" && statys.Text != "" && Regex.IsMatch(login.Text, pattern, RegexOptions.IgnoreCase) && Regex.IsMatch(paroli.Text, pattern1, RegexOptions.IgnoreCase))
            {
                object combo = (statys.SelectedItem as DataRowView).Row[0];
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                object id1 = (spisok.SelectedItem as DataRowView).Row[1];
                object id2 = (spisok.SelectedItem as DataRowView).Row[2];
                object id3 = (spisok.SelectedItem as DataRowView).Row[3];
                ac.UpdateQuery(login.Text, paroli.Text, Convert.ToInt32(combo), Convert.ToInt32(id));
           
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = ac.GetData();
        }
        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Cotrydniki cotrydniki = new Cotrydniki();
            cotrydniki.Show();
            this.Close();
        }
    }
}
