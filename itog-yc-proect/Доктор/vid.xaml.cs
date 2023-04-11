using itog_yc_proect.itDataSetTableAdapters;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
    /// Логика взаимодействия для vid.xaml
    /// </summary>
    internal class vids
    {
        public string Продолжительность_жизни { get; set; }
        public string Порода { get; set; }
        public string Происхождение { get; set; }
    }
        
    
    public partial class vid : Window
    {
        public static T Dessir<T>()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                string json = File.ReadAllText(dialog.FileName);
                T obj = JsonConvert.DeserializeObject<T>(json);
                return obj;
            }
            else
            {
                return default(T);
            }
        }
        видTableAdapter v = new видTableAdapter();
        public vid()
        {
            InitializeComponent();
            spisok.ItemsSource = v.GetData();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            animals k = new animals();
            k.Show();
            this.Close();
        }
        string ints = "[0-9]";
        string str = @"[А-я]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (poroda.Text != "" && prod.Text != "" && proishog.Text != "" && Regex.IsMatch(poroda.Text, str, RegexOptions.IgnoreCase) && Regex.IsMatch(proishog.Text, str, RegexOptions.IgnoreCase) && Regex.IsMatch(prod.Text, ints, RegexOptions.IgnoreCase))
            {
                v.InsertQuery(prod.Text, poroda.Text, proishog.Text);

            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = v.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (spisok.SelectedItem as DataRowView).Row[0];
                v.DeleteQuery(Convert.ToInt32(id));
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (poroda.Text != "" && prod.Text != "" && proishog.Text != "" && Regex.IsMatch(poroda.Text, str, RegexOptions.IgnoreCase) && Regex.IsMatch(proishog.Text, str, RegexOptions.IgnoreCase) && Regex.IsMatch(prod.Text, ints, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                v.UpdateQuery(prod.Text, poroda.Text, proishog.Text, Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = v.GetData();
        }

        private void import_Click(object sender, RoutedEventArgs e)
        {
            List<vids> forImport = Dessir<List<vids>>();
            foreach (var item in forImport)
            {
                v.InsertQuery(item.Продолжительность_жизни,item.Порода,item.Происхождение);
            }
            spisok.ItemsSource = null;
            spisok.ItemsSource = v.GetData();
        }
    }
}
