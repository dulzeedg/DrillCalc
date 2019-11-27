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

namespace DrillCalc
{
    public partial class PlotGraph : UserControl
    {
        public class Chart
        {
            public int vmin { get; set; }
            public int Angle { get; set; }
        }
        public PlotGraph()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadChartContents();
        }
        private void LoadChartContents()
        {
            List<Chart> lstSource = new List<Chart>();
            lstSource.Add(new Chart() { vmin = 10, Angle = 5 });
            lstSource.Add(new Chart() { vmin = 20, Angle = 10 });
            lstSource.Add(new Chart() { vmin = 30, Angle = 15 });
            //(ColumnChart.Series[0] as ColumnSeries).ItemsSource = lstSource;
            //(LineChart.Series[0] as LineSeries).ItemsSource = lstSource;
            //(BarChart.Series[0] as BarSeries).ItemsSource = lstSource;
            //(PieChart.Series[0] as PieSeries).ItemsSource = lstSource;
        }
    }
}
