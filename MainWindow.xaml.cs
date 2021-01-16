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

namespace WPFEatTracker
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void WindowsFormsHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Breakfast br = new Breakfast();
            this.Visibility = Visibility.Hidden;
            br.Show();
        }

        private void DinnerWindow(object sender, RoutedEventArgs e)
        {
            Dinner dr = new Dinner();
            this.Visibility = Visibility.Hidden;
            dr.Show();
        }

        private void LunchWindow(object sender, RoutedEventArgs e)
        {
            Lunch lch = new Lunch();
            this.Visibility = Visibility.Hidden;
            lch.Show();
        }

        private void OtherEatWindow(object sender, RoutedEventArgs e)
        {
            OtherEat oe = new OtherEat();
            this.Visibility = Visibility.Hidden;
            oe.Show();
        }
    }
}
