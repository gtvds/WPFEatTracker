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
        Person person = new Person();
        public Autentification()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kalory kalor = new Kalory(person);
            kalor.Show();
            this.Close();
            //if (textbox2.Text != "")
            //{
            //    Person.Size = Convert.ToInt32(textbox2.Text);
            //}
            //else
            //{
            //    Person.Size = 0;
            //} соответствует предложению  !=""?:0
            person.Name = textbox1.Text;
            person.Size = textbox2.Text;
            person.Age = textbox3.Text;
            person.Weight = textbox4.Text;
        }


    }
}
