using System;
using System.Collections.Generic;
using System.IO;
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

namespace DataGridWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> People = new List<User>();
        DataGridTextColumn cF = new DataGridTextColumn();
        DataGridTextColumn cI = new DataGridTextColumn();
        DataGridTextColumn cO = new DataGridTextColumn();
        DataGridTextColumn cG = new DataGridTextColumn();
        DataGridTextColumn cD = new DataGridTextColumn();

        public MainWindow()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("users.csv"))
            {
                while (sr.EndOfStream!=true)
                {
                    string[] Arr = sr.ReadLine().Split(';');
                    People.Add(new User() { f = Arr[0], i = Arr[1], o = Arr[2], g = Arr[3], d = Arr[4] });
                }
            }
            DGUsers.ItemsSource = People;
            cF.Header = "Фамилия";
            cI.Header = "Имя";
            cO.Header = "Отчетсво";
            cG.Header = "Пол";
            cD.Header = "Дата рождения";
            cF.Binding = new Binding("f");
            cI.Binding = new Binding("i");
            cO.Binding = new Binding("o");
            cG.Binding = new Binding("g");
            cD.Binding = new Binding("d");
            DGUsers.Columns.Add(cF);
            DGUsers.Columns.Add(cI);
            DGUsers.Columns.Add(cO);
            DGUsers.Columns.Add(cG);
            DGUsers.Columns.Add(cD);

        }

        private void Cbf_Checked(object sender, RoutedEventArgs e)
        {
            DGUsers.Visibility = Visibility.Visible;
            cF.Visibility = Visibility.Visible;
        }

        private void Cbi_Checked(object sender, RoutedEventArgs e)
        {
            DGUsers.Visibility = Visibility.Visible;
            cI.Visibility = Visibility.Visible;
        }

        private void Cbo_Checked(object sender, RoutedEventArgs e)
        {
            DGUsers.Visibility = Visibility.Visible;
            cO.Visibility = Visibility.Visible;
        }

        private void Cbg_Checked(object sender, RoutedEventArgs e)
        {
            DGUsers.Visibility = Visibility.Visible;
            cG.Visibility = Visibility.Visible;
        }

        private void Cbd_Checked(object sender, RoutedEventArgs e)
        {
            DGUsers.Visibility = Visibility.Visible;
            cD.Visibility = Visibility.Visible;
        }

        private void Cbf_Unchecked(object sender, RoutedEventArgs e)
        {
            cF.Visibility = Visibility.Hidden;
            if (Cbi.IsChecked==false && Cbo.IsChecked == false && Cbg.IsChecked == false && Cbd.IsChecked == false)
            {
                DGUsers.Visibility = Visibility.Hidden;
            }
        }

        private void Cbi_Unchecked(object sender, RoutedEventArgs e)
        {
            cI.Visibility = Visibility.Hidden;
            if (Cbf.IsChecked == false && Cbo.IsChecked == false && Cbg.IsChecked == false && Cbd.IsChecked == false)
            {
                DGUsers.Visibility = Visibility.Hidden;
            }
        }

        private void Cbo_Unchecked(object sender, RoutedEventArgs e)
        {
            cO.Visibility = Visibility.Hidden;
            if (Cbi.IsChecked == false && Cbf.IsChecked == false && Cbg.IsChecked == false && Cbd.IsChecked == false)
            {
                DGUsers.Visibility = Visibility.Hidden;
            }
        }

        private void Cbg_Unchecked(object sender, RoutedEventArgs e)
        {
            cG.Visibility = Visibility.Hidden;
            if (Cbi.IsChecked == false && Cbo.IsChecked == false && Cbf.IsChecked == false && Cbd.IsChecked == false)
            {
                DGUsers.Visibility = Visibility.Hidden;
            }
        }

        private void Cbd_Unchecked(object sender, RoutedEventArgs e)
        {
            cD.Visibility = Visibility.Hidden;
            if (Cbi.IsChecked == false && Cbo.IsChecked == false && Cbg.IsChecked == false && Cbf.IsChecked == false)
            {
                DGUsers.Visibility = Visibility.Hidden;
            }
        }
    }
}
