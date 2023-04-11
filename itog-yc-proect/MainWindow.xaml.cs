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
using System.Windows.Navigation;
using System.Windows.Shapes;
using itog_yc_proect.itDataSetTableAdapters;
namespace itog_yc_proect
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        АккаунтTableAdapter accaunt = new АккаунтTableAdapter();
       
        public class logpar
        {
            public string logs { get; set; }
            public int par { get; set; }
        }
        logpar Tom;
        public MainWindow()
        {
            InitializeComponent();
            Tom = new logpar();
            this.DataContext = Tom;
        }
        private void avtr_Click(object sender, RoutedEventArgs e)
        {var alllogins = accaunt.GetData().Rows;
            for (int i = 0;i<alllogins.Count;i++)
            {
                if (alllogins[i][1].ToString() == log.Text && alllogins[i][2].ToString() == par.Password)
                {
                    int roleid = (int)alllogins[i][3];
                    switch (roleid)
                    {
                        case 1:
                            
                            Window1 window1 = new Window1();
                            window1.Show();
                            this.Close();
                            break;
                        case 2:
                            
                            Window2 window2 = new Window2();
                            window2.Show();
                            this.Close();
                            break;
                    }
                }            
            }
        }
    }
}
