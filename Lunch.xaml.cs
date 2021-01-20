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
    /// Логика взаимодействия для Lunch.xaml
    /// </summary>
    public partial class Lunch : Window
    {
        public Lunch()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwlch = new MainWindow(Name, Name, Name, Name);
            this.Visibility = Visibility.Hidden;
            mwlch.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Lunch lnch = new Lunch();
            string name = textboxlh.Text; // получаем имя из текстового поля
            this.Visibility = Visibility.Hidden;
            new MainWindow(name, Name, Name, Name).ShowDialog(); // вызываем окно, передавая данные
        }
    }
}
