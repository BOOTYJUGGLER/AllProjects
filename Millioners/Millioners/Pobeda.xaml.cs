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

namespace Millioners
{
    /// <summary>
    /// Логика взаимодействия для Pobeda.xaml
    /// </summary>
    public partial class Pobeda : Window
    {
        public Pobeda()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void _vopros_Loaded(object sender, RoutedEventArgs e)
        {
            _vopros.Content = "Поздравляю, вы стали миллионером!!!";
            _vopros.Foreground = Brushes.White;
        }
    }
}
