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
    /// Логика взаимодействия для Autentification.xaml
    /// </summary>
    public partial class Autentification : Window
    {
        public Autentification()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kalory kalor = new Kalory();
            kalor.Show();
            this.Close();
            //if (textbox2.Text != "")
            //{
            //    Person.Size = Convert.ToInt32(textbox2.Text);
            //}
            //else
            //{
            //    Person.Size = 0;
            //}
            Person.Name = textbox1.Text;
            Person.Size = textbox2.Text!=""?Convert.ToInt32(textbox2.Text):0;
            Person.Age = textbox3.Text!=""?Convert.ToInt32(textbox3.Text):0;
            Person.Weight = textbox4.Text!=""?Convert.ToDecimal(textbox4.Text):0;
        }


    }
}
