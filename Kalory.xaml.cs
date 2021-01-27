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
    /// Логика взаимодействия для Kalory.xaml
    /// </summary>
    public partial class Kalory : Window
    {
        public Kalory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person.kkal = Convert.ToInt32(textboxkkal.Text);
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
            
        }
    }
}
