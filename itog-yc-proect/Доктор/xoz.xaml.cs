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
    /// Логика взаимодействия для xoz.xaml
    /// </summary>
    internal class x
    {
        public string имя { get; set; }
        public string Телефон { get; set; }
        public string Возраст { get; set; }
    }
    public partial class xoz : Window
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
        ХозяинTableAdapter xozain = new ХозяинTableAdapter();
        public xoz()
        {
            InitializeComponent();
            spisok.ItemsSource = xozain.GetData();
        }

        private void spisok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        string n = @"^[A-ЯЁ][а-яё]+\s^[A-ЯЁ][а-яё]+\s^[A-ЯЁ][а-яё]+$$";
        string p = @"[0-9]{3}-[0-9]{3}-[0-9]{4}";
        string str = @"[0-9]";
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            if (telefon.Text != "" && ima.Text != "" && old.Text != "" && old.Text != "" && Regex.IsMatch(telefon.Text, p, RegexOptions.IgnoreCase) && old.Text != "" && Regex.IsMatch(ima.Text, n, RegexOptions.IgnoreCase) && old.Text != "" && Regex.IsMatch(old.Text, str, RegexOptions.IgnoreCase))
            {
                xozain.InsertQuery(ima.Text, telefon.Text, old.Text);
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = xozain.GetData();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (spisok.SelectedItem as DataRowView).Row[0];
            xozain.DeleteQuery(Convert.ToInt32(id));
            spisok.ItemsSource = xozain.GetData();
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (telefon.Text != "" && ima.Text != "" && old.Text != "" && old.Text != "" && Regex.IsMatch(telefon.Text, p, RegexOptions.IgnoreCase) && old.Text != "" && Regex.IsMatch(ima.Text, n, RegexOptions.IgnoreCase) && old.Text != "" && Regex.IsMatch(old.Text, str, RegexOptions.IgnoreCase))
            {
                object id = (spisok.SelectedItem as DataRowView).Row[0];
                xozain.UpdateQuery(ima.Text, telefon.Text, old.Text, Convert.ToInt32(id));
            }
            else
            {
                Error er = new Error();
                er.Show();
            }
            spisok.ItemsSource = xozain.GetData();
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            animals an = new animals();
            an.Show();
            this.Close();
        }

        private void import_Click(object sender, RoutedEventArgs e)
        {
            List<x> forImport = Dessir<List<x>>();
            foreach (var item in forImport)
            {
                xozain.InsertQuery(item.имя, item.Телефон, item.Возраст);
            }
            spisok.ItemsSource = null;
            spisok.ItemsSource = xozain.GetData();
        }
    }
}
