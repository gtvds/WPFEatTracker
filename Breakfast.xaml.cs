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

namespace WPFEatTracker
{
    /// <summary>
    /// Логика взаимодействия для Breakfast.xaml
    /// </summary>
    public partial class Breakfast : Window
    {
        public Breakfast()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(Name, Name, Name, Name);
            this.Visibility = Visibility.Hidden;
            mw.Show();
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Breakfast brfst = new Breakfast();
            string namebr = textboxbr.Text; // получаем имя из текстового поля
            this.Visibility = Visibility.Hidden;
            new MainWindow(namebr, Name, Name, Name).ShowDialog(); // вызываем окно, передавая данные
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
