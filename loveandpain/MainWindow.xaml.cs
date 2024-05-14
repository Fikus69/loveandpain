using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace loveandpain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Char_win(object sender, RoutedEventArgs e)
        {
            CharMenu charMenu = new CharMenu();
            charMenu.Show();
        }

        private void Fact_win(object sender, RoutedEventArgs e)
        {
            FactMenu factMenu = new FactMenu();
            factMenu.Show();
        }

        private void Roots_win(object sender, RoutedEventArgs e)
        {
            RootMenu rootMenu = new RootMenu();
            rootMenu.Show();
        }

        private void Create_win(object sender, RoutedEventArgs e)
        {
            Creators.Content = new Creatorpg();
        }

        private void Svaz_click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = "Если у вас возникли проблемы с игрой или вы хотите предложить идею, напишите на почту: \n kharuno06@bk.ru (вам не ответят)";
            MessageBox.Show(messageBoxText);
        }

    }
}