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
using System.Threading;

namespace Millioners
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
        private void _rules_Click(object sender, RoutedEventArgs e)
        {
            _mainmenu.Content = "Правила игры практически не отличаются от правил известного телешоу «Кто хочет стать миллионером».\nЗадаётся вопрос и выдаётся 4 варианта ответов, где только 1 из них является верным.\nОтвечая на заданные вопросы, игрок зарабатывает определённую сумму денег,\nкоторая возрастает от вопроса к вопросу.";
            _mainmenu.FontSize = 25;
            _mainmenu.VerticalContentAlignment = VerticalAlignment.Center;

        }

        private void _escape_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void _about_Click(object sender, RoutedEventArgs e)
        {
            _mainmenu.Content = "Впервые на телеэкраны игра «Кто хочет стать миллионером» вышала на какнале НТВ в 1999 году под названием «О, Счастливчик»,\nее первым ведущим был Димтрий Дибров.\n После первых же выпусков игра стала пользоваться огромной популярностью и \nпривлела к телевизионным экранам большую аудиторию. \nВ 2001 г. было изменено название игры, ведущим стал Максим Галкин, ее начали транслировать на первом канале.\n В 2005 году изменились размеры призов, главный приз был увеличен до трех миллионов рублей!\n В 2009 году ведущим телепередачи стал первый ведущий Дмитрий Дибров в связи с уходом с первого канала Максима Галкина.\nЗа всю историю игры главный приз выиграли 4 участника - двое по 1 млн. руб. и двое 3 млн. руб.";
            _mainmenu.FontSize = 20;
            _mainmenu.VerticalContentAlignment = VerticalAlignment.Center;
        }

        private void _play_Click(object sender, RoutedEventArgs e)
        {            
                Igra igra2 = new Igra();
                this.Hide();
                igra2.ShowDialog();            
        }
        
    }
}
