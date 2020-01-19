using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;
using System.Windows.Media;


namespace DrillCalc
{
	public partial class PlotGraph : UserControl
	{

		public PlotGraph()
		{
			InitializeComponent();

			// Result

			// index configuration

			//var mapper1 = new CartesianMapper<double>()
			//.X((value, index) => index)
			//.Y((value, index) => value);

			// setting maxRange
			// obj ref is required for non-static 
			//CartesianChart.AxisX.Clear();
			//CartesianChart.AxisX.Add(
				//new Axis { MaxRange = 90 });
			SeriesCollection seriesCollection = SeriesCollection = new SeriesCollection()
			{
						
						new LineSeries
						{
							Title = "Series 30",
							// ChartValues<>{} Insert Values below
							Values = new ChartValues<double> { 1.49, 1.61, 1.73, 1.85, 1.96, 2.02, 2.02, 2.02, 2.02, 2.02 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true
						},
						new LineSeries
						{
							Title = "Series 60",
							Values = new ChartValues<double> { 1.56, 1.71, 1.85, 2.00, 2.15, 2.22, 2.22, 2.22, 2.22, 2.22 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true,
							//LabelPoint = point => point.Y + point.X
						},
						/*new LineSeries
						{
							Title = "Series 80",
							Values = new ChartValues<double> { 5.2, 25.8, 45.6, 64.0, 80.5, 94.6, 105.7, 113.7, 118.2, 119.1 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true
						}*/
					
			};


			// 
			//SeriesCollection[1].Values.Add(5d);

			Labels = new[] { "0", "", "20", "", "40", "", "60",  "", "80", "", "50", "", "60", "", "70", "c", "80", "c", "90" };
			Formatter = value =>value.ToString("N");
			DataContext = this; 
		}
		


		public SeriesCollection SeriesCollection { get; set; }
		
		public string[] Labels { get; set; }
		public Func<double, string> Formatter { get; set; }
		//public double HVMin { get; set; }

		internal void Show()
		{
			throw new NotImplementedException();
		}
	}
}