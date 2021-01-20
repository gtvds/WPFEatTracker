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
    public class MainWindowVM
    {
        string _textDinner;
        public string TextDinner { get { return _textDinner; } set { _textDinner = value; } }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM mainWindowVM;
        public MainWindow()
        {
            InitializeComponent();
            mainWindowVM = new MainWindowVM();
            textboxdinner.Text = mainWindowVM.TextDinner;
        }

        public MainWindow(string namebr, string namelh, string namedr, string nameotr)
        {
            InitializeComponent();
            textboxbreakfast.Text += namebr;
            textboxdinner.Text += namelh;
            textboxlunch.Text += namedr;
            textboxothereat.Text += nameotr;
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
            //как вариант, создать класс, в котором должны храниться нужные значения и передавать его по ссылке в другие формы.
            //ща опробум
        }

        private void DinnerWindow(object sender, RoutedEventArgs e)
        {
            Dinner dr = new Dinner(mainWindowVM,this);
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

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
           
        }
        
    }
}
