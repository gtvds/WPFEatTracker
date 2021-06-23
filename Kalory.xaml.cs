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

        public Kalory(Person per) : this()
        {
            person = per;
        }

        Person person;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Kalory = textboxkkal.Text;
            try
            {
                using (EatTrackerEntities DbContext = new EatTrackerEntities())
                {
                    DbContext.Person.Add(person);
                    DbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
            MainWindow mw = new MainWindow(person);
            mw.Show();
            this.Hide();
            
        }
    }
}
