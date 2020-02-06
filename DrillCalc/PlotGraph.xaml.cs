using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Windows.Controls;


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
			
			//CartesianChart.AxisX.Clear();
			//CartesianChart.AxisX.Add(
			//new Axis { MaxRange = 90 });
			
   
			double[] _value = new double[91];
			ValuesArray values = new ValuesArray();
			Array.Copy(values.value, 0, _value, 0, values.value.Length);
			SeriesCollection = new SeriesCollection()
			{
				new LineSeries
						{
							Title = "Series 30",
							Values = new ChartValues<double> (_value),
							PointGeometry = DefaultGeometries.Circle,
							PointGeometrySize = 5,
							LineSmoothness = 0,
							DataLabels = true
						}
						
			};
			Labels = new[] { "0°", "10°", "20°", "30°", "40°", "50°", "60°", "70°", "80°" };
			// Label Formatter for X Axis
			Formatter = value => value + "°";
			DataContext = this; 
		}
		public SeriesCollection SeriesCollection { get; set; }
		public Func<double, string> Formatter { get; set; }
		public string[] Labels { get; set; }
	}
}