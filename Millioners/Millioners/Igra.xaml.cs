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
    /// Логика взаимодействия для Igra.xaml
    /// </summary>
    public partial class Igra : Window
    {
        public Igra()
        {
            InitializeComponent();
        }

        

        private void _otv_B_Click(object sender, RoutedEventArgs e)
        {
            Vopros2 vopros2 = new Vopros2();
            this.Hide();
            vopros2.ShowDialog();
        }

        private void _otv_A_Click(object sender, RoutedEventArgs e)
        {
            var otv = MessageBox.Show("Вы ответили неправильно, Игра окончена.", "Подтверждение", MessageBoxButton.OK);
            if (otv == MessageBoxResult.OK)
            {               
                this.Hide();              
            }
        }

        private void _otv_C_Click(object sender, RoutedEventArgs e)
        {
            var otv = MessageBox.Show("Вы ответили неправильно, Игра окончена.", "Подтверждение", MessageBoxButton.OK);
            if (otv == MessageBoxResult.OK)
            {
                this.Hide();
            }
        }

        private void _otv_D_Click(object sender, RoutedEventArgs e)
        {
            var otv = MessageBox.Show("Вы ответили неправильно, Игра окончена.", "Подтверждение", MessageBoxButton.OK);
            if (otv == MessageBoxResult.OK)
            {
                this.Hide();
            }
        }
    }
}
