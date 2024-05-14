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
using loveandpain.rootspgs;

namespace loveandpain
{
    /// <summary>
    /// Логика взаимодействия для RootMenu.xaml
    /// </summary>
    public partial class RootMenu : Window
    {
        public RootMenu()
        {
            InitializeComponent();
        }

        private void Iroot(object sender, RoutedEventArgs e)
        {
            RootWin.Content = new Irootpg();
        }

        private void Yroot(object sender, RoutedEventArgs e)
        {
            RootWin.Content = new Yrootpg();
        }

        private void Mroot(object sender, RoutedEventArgs e)
        {
            RootWin.Content = new Mrootpg();
        }

        private void Proot(object sender, RoutedEventArgs e)
        {
            RootWin.Content = new Prootpg();
        }
    }
}
