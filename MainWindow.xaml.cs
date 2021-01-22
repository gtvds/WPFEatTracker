using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WPFEatTracker.Models;
using WPFEatTracker.View;
using WPFEatTracker.ViewModel;

namespace WPFEatTracker
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private int _needKKal;
        public int NeedKKal
        {
            get => _needKKal;
            set => this.MutateVerbose(ref _needKKal, value, RaisePropertyChanged());
        }

        private string? _nameBreakfast;
        public string? NameBreakfast
        {
            get => _nameBreakfast;
            set => this.MutateVerbose(ref _nameBreakfast, value, RaisePropertyChanged());
        }

        private int _kkal;
        public int KKal
        {
            get => _kkal;
            set => this.MutateVerbose(ref _kkal, value, RaisePropertyChanged()); 
        }

        private int _ostatok;
        public int Ostatok
        {
            get => _ostatok;
            set => this.MutateVerbose(ref _ostatok, value, RaisePropertyChanged());
        }

        public ICommand RunDialogCommand => new AnotherCommandImplementation(ExecuteRunDialog);

        private async void ExecuteRunDialog(object parameter)
        {
            switch (parameter.ToString())
            {
                case "Breakfast" :
                    var view = new Breakfast { DataContext = new BreakfastVM() };
                    var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
                    if ((bool)result)
                    {
                        NameBreakfast = ((BreakfastVM)view.DataContext).Name;
                        KKal += ((BreakfastVM)view.DataContext).KKal.Value;
                        Ostatok = NeedKKal - KKal;
                    }
                    break;
                case "Dinner" :
                    break;
                case "Lunch" :
                    break;
                default:
                    break;
            }
        }

        private void ClosingEventHandler(object sender, DialogClosingEventArgs eventArgs) { }

        
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Action<PropertyChangedEventArgs> RaisePropertyChanged() => args => PropertyChanged?.Invoke(this, args);
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM() { NeedKKal=1650 };
        }

        public MainWindow(string namebr, string namelh, string namedr, string nameotr)
        {
            InitializeComponent();
            textboxbreakfast.Text += namebr;
            textboxdinner.Text += namelh;
            textboxlunch.Text += namedr;
            textboxothereat.Text += nameotr;
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            //Breakfast br = new Breakfast();
            //this.Visibility = Visibility.Hidden;
            //br.Show();
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

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
        
    }
}
