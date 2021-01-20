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
    /// Логика взаимодействия для Dinner.xaml
    /// </summary>
    public partial class Dinner : Window
    {
        MainWindowVM mainVM;
        MainWindow parentWindow;
        public Dinner()
        {
            InitializeComponent();
        }
        public Dinner(MainWindowVM refObj, MainWindow parent) {
            InitializeComponent();
            mainVM = refObj;
            parentWindow = parent;
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mwdr = new MainWindow(Name, Name, Name, Name);
            this.Visibility = Visibility.Hidden;
            mwdr.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Dinner dinr = new Dinner();
            mainVM.TextDinner = textboxdr.Text; // получаем имя из текстового поля
            this.Visibility = Visibility.Hidden;
            parentWindow.Visibility = Visibility.Visible;
            //new MainWindow(name, Name, Name, Name).ShowDialog(); // вызываем окно, передавая данные
        }
    }
}
