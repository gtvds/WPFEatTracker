using MaterialDesignThemes.Wpf;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WPFEatTracker.Models;
using WPFEatTracker.View;
using WPFEatTracker.ViewModel;

namespace WPFEatTracker
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private int _needKKal;
        private int _kkal;
        private int _ostatok;
        private string? _nameBreakfast;
        private string? _nameLunch;
        private string? _nameDinner;
        private string? _nameOther;
        string connectionString;
        Person currentPerson;

        public MainWindowVM()
        {
            currentPerson = StaticPerson.person;
            NeedKKal = Int32.Parse(StaticPerson.person.Kalory);
            NameBreakfast = StaticPerson.person.Breakfast.FirstOrDefault().eat_breakfast != String.Empty ? StaticPerson.person.Breakfast.FirstOrDefault().eat_breakfast : String.Empty;
            NameLunch = StaticPerson.person.Lunch.FirstOrDefault().eat_lunch != String.Empty ? StaticPerson.person.Lunch.FirstOrDefault().eat_lunch : String.Empty;
            NameDinner = StaticPerson.person.Dinner.FirstOrDefault().eat_dinner != String.Empty ? StaticPerson.person.Dinner.FirstOrDefault().eat_dinner : String.Empty;
            NameOther = StaticPerson.person.OtherEat.FirstOrDefault().eat_other != String.Empty ? StaticPerson.person.OtherEat.FirstOrDefault().eat_other : String.Empty;

        }

        public int NeedKKal
        {
            get => _needKKal;
            set => this.MutateVerbose(ref _needKKal, value, RaisePropertyChanged());
        }
        public string? NameBreakfast
        {
            get => _nameBreakfast;
            set => this.MutateVerbose(ref _nameBreakfast, value, RaisePropertyChanged());
        }
        public string? NameLunch
        {
            get => _nameLunch;
            set => this.MutateVerbose(ref _nameLunch, value, RaisePropertyChanged());
        }
        public string? NameDinner
        {
            get => _nameDinner;
            set => this.MutateVerbose(ref _nameDinner, value, RaisePropertyChanged());
        }
        public string? NameOther
        {
            get => _nameOther;
            set => this.MutateVerbose(ref _nameOther, value, RaisePropertyChanged());
        }
        public int KKal
        {
            get => _kkal;
            set => this.MutateVerbose(ref _kkal, value, RaisePropertyChanged());
        }
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
                case "Breakfast":
                    var viewbt = new View.Breakfast { DataContext = new BreakfastVM() };
                    var resultbfst = await DialogHost.Show(viewbt, "RootDialog", ClosingEventHandler);
                    if ((bool)resultbfst)
                    {
                        NameBreakfast = ((BreakfastVM)viewbt.DataContext).NameBreakfast;
                        KKal += ((BreakfastVM)viewbt.DataContext).KKal.Value;
                        Ostatok = NeedKKal - KKal;
                        try
                        {
                            using(EatTrackerEntities DbContext = new EatTrackerEntities())
                            {
                                DbContext.Breakfast.Add(new Breakfast() { eat_breakfast = NameBreakfast, kalory_breakfast = ((BreakfastVM)viewbt.DataContext).KKal.Value.ToString(), id_person = currentPerson.id_person, Person = currentPerson });
                                DbContext.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка при сохранении данных");
                        }
                        var view = new Motvation1 { DataContext = new MotivationVM() };
                        var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
                    }
                    break;
                case "Dinner":
                    var viewdr = new View.Dinner { DataContext = new DinnerVM() };
                    var resultdr = await DialogHost.Show(viewdr, "RootDialog", ClosingEventHandler);
                    if ((bool)resultdr)
                    {
                        NameDinner = ((DinnerVM)viewdr.DataContext).NameDinner;
                        KKal += ((DinnerVM)viewdr.DataContext).KKal.Value;
                        Ostatok = NeedKKal - KKal;
                        try
                        {
                            using (EatTrackerEntities DbContext = new EatTrackerEntities())
                            {
                                DbContext.Dinner.Add(new Dinner() { eat_dinner = NameDinner, kalory_din = ((DinnerVM)viewdr.DataContext).KKal.Value.ToString(), id_person = currentPerson.id_person, Person = currentPerson });
                                DbContext.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка при сохранении данных");
                        }
                        var view = new Motvation2 { DataContext = new MotivationVM() };
                        var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
                    }
                    break;
                case "Lunch":
                    var viewlh = new View.Lunch { DataContext = new LunchVM() };
                    var resultlh = await DialogHost.Show(viewlh, "RootDialog", ClosingEventHandler);
                    if ((bool)resultlh)
                    {
                        NameLunch = ((LunchVM)viewlh.DataContext).NameLunch;
                        KKal += ((LunchVM)viewlh.DataContext).KKal.Value;
                        Ostatok = NeedKKal - KKal;
                        try
                        {
                            using (EatTrackerEntities DbContext = new EatTrackerEntities())
                            {
                                DbContext.Lunch.Add(new Lunch() { eat_lunch = NameBreakfast, kalory_lunch = ((LunchVM)viewlh.DataContext).KKal.Value.ToString(), id_person = currentPerson.id_person, Person = currentPerson });
                                DbContext.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка при сохранении данных");
                        }
                        var view = new Motvation3 { DataContext = new MotivationVM() };
                        var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
                    }
                    break;
                case "Other":
                    var viewor = new Other { DataContext = new OtherVM() };
                    var resultor = await DialogHost.Show(viewor, "RootDialog", ClosingEventHandler);
                    if ((bool)resultor)
                    {
                        NameOther = ((OtherVM)viewor.DataContext).NameOther;
                        KKal += ((OtherVM)viewor.DataContext).KKal.Value;
                        Ostatok = NeedKKal - KKal;
                        try
                        {
                            using (EatTrackerEntities DbContext = new EatTrackerEntities())
                            {
                                DbContext.OtherEat.Add(new OtherEat() { eat_other = NameBreakfast, kalory_other = ((OtherVM)viewor.DataContext).KKal.Value.ToString(), id_person = currentPerson.id_person, Person = currentPerson });
                                DbContext.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка при сохранении данных");
                        }
                        var view = new Motvation4 { DataContext = new MotivationVM() };
                        var result = await DialogHost.Show(view, "RootDialog", ClosingEventHandler);
                    }
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
    
        public MainWindow(Person person)
        {
            InitializeComponent();
            this.DataContext = new MainWindowVM();
        }

        private void OpenPage(object sender, RoutedEventArgs e)
        {
            switch (((Button)e.OriginalSource).Name)
            {
                case "GoHome":
                    Conten.Navigate(new View.Home());
                    break;
                case "GoRecommendations":
                    Conten.Navigate(new View.Recommendations());
                    break;
                case "GoDiagram":
                    Conten.Navigate(new Diagram(
                        Int32.Parse(StaticPerson.person.Breakfast.FirstOrDefault().kalory_breakfast),
                        Int32.Parse(StaticPerson.person.OtherEat.FirstOrDefault().kalory_other),
                        Int32.Parse(StaticPerson.person.Lunch.FirstOrDefault().kalory_lunch),
                        Int32.Parse(StaticPerson.person.Dinner.FirstOrDefault().kalory_din)));
                    break;
                default:
                    return;
            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kalory k = new Kalory();            
            k.Show();
            this.Close();
            
        }

        private void Conten_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
