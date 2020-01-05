using System;
using System.Windows;
using System.Windows.Controls;
using Wpf.CartesianChart.PointShapeLine;

namespace DrillCalc
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonCloseMenu.Visibility = Visibility.Visible;
			ButtonOpenMenu.Visibility = Visibility.Collapsed;
		}

		private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
		{
			ButtonCloseMenu.Visibility = Visibility.Collapsed;
			ButtonOpenMenu.Visibility = Visibility.Visible;
		}

		private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			GridMain.Children.Clear();

			UserControl usc;
			switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
			{
				case "ItemHome":
					usc = new RubiModel();
					GridMain.Children.Add(usc);
					break;
				case "ItemCreate":
					usc = new HopkinModel();
					GridMain.Children.Add(usc);
					break;
				case "ItemPlot":
					usc = new PointShapeLineExample();
					GridMain.Children.Add(usc);
					break;
				default:
					break;
			}
		}
	}
}
