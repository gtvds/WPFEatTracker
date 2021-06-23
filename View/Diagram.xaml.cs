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
using LiveCharts;
using LiveCharts.Wpf;

namespace WPFEatTracker.View
{
    /// <summary>
    /// Interaction logic for Diagram.xaml
    /// </summary>
    public partial class Diagram : Page
    {
        public Diagram()
        {
            InitializeComponent();

            PointLabel = chartPoint =>
               string.Format("{0}\r\n{1} Ккал", chartPoint.SeriesView.Title.ToString(), chartPoint.Y);

            DataContext = this;
        }

        public Diagram(int breakfast, int other, int lunch, int dinner)
        {
            BreakfastPieSeries.Values = new ChartValues<int> { breakfast };
            OtherPieSeries.Values = new ChartValues<int> { other };
            LunchPieSeries.Values = new ChartValues<int> { lunch };
            DinnerPieSeries.Values = new ChartValues<int> { dinner };
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

    }
}