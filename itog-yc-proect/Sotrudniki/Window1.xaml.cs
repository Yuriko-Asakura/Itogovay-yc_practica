using itog_yc_proect.Sotrudniki.Yslygi;
using itog_yc_proect.Sotrudniki.Запись;
using System;
using System.Collections.Generic;
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

namespace itog_yc_proect
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cotrydniki cot = new Cotrydniki();
            cot.Show();
            this.Close();
        }

        private void Priem_Click(object sender, RoutedEventArgs e)
        {
            data data = new data();
            data.Show();
            this.Close();
        }

        private void Yslugi_Click(object sender, RoutedEventArgs e)
        {
            nach_Ysluga ysl = new nach_Ysluga();
            ysl.Show();
            this.Close();
        }

        private void Excit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
