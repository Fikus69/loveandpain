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
using System.Windows.Navigation;
using loveandpain.charpgs;

namespace loveandpain
{
    /// <summary>
    /// Логика взаимодействия для CharMenu.xaml
    /// </summary>
    public partial class CharMenu : Window
    {
        public CharMenu()
        {
            InitializeComponent();
        }

        private void ButtI_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Izaopg();
        }

        private void ButtY_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Yukiropg();
        }

        private void ButtA_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Akirapg();
        }

        private void ButtS_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Ioripg();
        }

        private void ButtMSH_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Misashipg();
        }

        private void ButtMSK_win(object sender, RoutedEventArgs e)
        {
            CharPg.Content = new Misakipg();
        }
    }
}
