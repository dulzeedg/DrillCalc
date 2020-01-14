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

			var mapper1 = new CartesianMapper<double>()
			.X((value, index) => index)
			.Y((value, index) => value);

			// setting maxRange
			// obj ref is required for non-static 
			//CartesianChart.AxisX.Clear();
			//CartesianChart.AxisX.Add(
				//new Axis { MaxRange = 90 });
			SeriesCollection seriesCollection = SeriesCollection = new SeriesCollection(mapper1)
			{
						
						new LineSeries
						{
							Title = "Series 30",
							// ChartValues<>{} Insert Values below
							Values = new ChartValues<double> { 1.278272, 1.301002, 1.312367, 1.323732, 1.335097, 1.346462, 1.357828, 1.369193, 1.380558, 1.380558, 1.380558, 1.380558, 1.380558 , 1.380558, 1.380558, 1.380558, 1.380558 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true
						},
						new LineSeries
						{
							Title = "Series 60",
							Values = new ChartValues<double> { 1.678973, 1.704566, 1.717362, 1.730158, 1.742955, 1.755751, 1.768547, 1.781344, 1.79414, 1.79414, 1.79414, 1.79414, 1.79414, 1.79414, 1.79414, 1.79414, 1.79414 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true,
							//LabelPoint = point => point.Y + point.X
						},
						new LineSeries
						{
							Title = "Series 80",
							Values = new ChartValues<double> { 1.82266, 1.849177, 1.8622435, 1.875694, 1.888952, 1.902211, 1.915496, 1.915469, 1.928727, 1.941986, 1.941986, 1.941986, 1.941986, 1.941986, 1.941986, 1.941986, 1.941986 },
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true
						}
					
			};

			/*Labels = new[]
			{
				10, 20, 30, 40, 50
			};*/
			YFormatter = value => value;

			DataContext = this; 
		}
		


		public SeriesCollection SeriesCollection { get; set; }
		
		//public int[] Labels { get; set; }
		public Func<double, double> YFormatter { get; set; }
		public double HVMin { get; set; }

		internal void Show()
		{
			throw new NotImplementedException();
		}
	}
}