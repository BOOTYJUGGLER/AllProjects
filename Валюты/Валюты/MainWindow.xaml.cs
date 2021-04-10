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

namespace Валюты
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (start_val.Text == "RUB" && end_val.Text == "USD" )
            {
                Count.Content = Convert.ToDouble(summa.Text) / 75.45;

            }
            else if (start_val.Text == "RUB" && end_val.Text == "EUR")
            {
                Count.Content = Convert.ToDouble(summa.Text) / 81.97;
            }
            else if (start_val.Text == "RUB" && end_val.Text == "RUB")
            {
                Count.Content = Convert.ToDouble(summa.Text);
            }
            else if (start_val.Text == "USD" && end_val.Text == "RUB")
            {
                Count.Content = Convert.ToDouble(summa.Text) * 75.45;
            }
            else if (start_val.Text == "USD" && end_val.Text == "EUR")
            {
                Count.Content = Convert.ToDouble(summa.Text) * 0.92;
            }
            else if (start_val.Text == "USD" && end_val.Text == "USD")
            {
                Count.Content = Convert.ToDouble(summa.Text);
            }
            else if (start_val.Text == "EUR" && end_val.Text == "RUB")
            {
                Count.Content = Convert.ToDouble(summa.Text) * 82.18;
            }
            else if (start_val.Text == "EUR" && end_val.Text == "USD")
            {
                Count.Content = Convert.ToDouble(summa.Text) * 1.09;
            }
            else if (start_val.Text == "EUR" && end_val.Text == "EUR")
            {
                Count.Content = Convert.ToDouble(summa.Text);
            }
        }
    }
}
