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
    /// Логика взаимодействия для Vopr2.xaml
    /// </summary>
    public partial class Vopr2 : Window
    {
        public Vopr2()
        {
            InitializeComponent();
        }

        private void _otv_D_Click(object sender, RoutedEventArgs e)
        {
            Vopros5 vopros5 = new Vopros5();
            this.Hide();
            vopros5.ShowDialog();
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

        private void _otv_B_Click(object sender, RoutedEventArgs e)
        {
            var otv = MessageBox.Show("Вы ответили неправильно, Игра окончена.", "Подтверждение", MessageBoxButton.OK);
            if (otv == MessageBoxResult.OK)
            {
                this.Hide();
            }
        }
    }
}
