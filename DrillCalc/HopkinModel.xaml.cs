using System;
using System.Windows;
using System.Windows.Controls;

namespace DrillCalc
{
	public partial class HopkinModel : UserControl
	{
		public HopkinModel()
		{
			InitializeComponent();
		}


		string inputData1 = string.Empty;
		string inputData2 = string.Empty;
		string inputData3 = string.Empty;
		string inputData4 = string.Empty;
		string inputData5 = string.Empty;
		string inputData6 = string.Empty;
		string inputData7 = string.Empty;
		string inputData8 = string.Empty;
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			// add user input from textbox to var input

			inputData1 += textBox11.Text;
			inputData2 += textBox21.Text;
			inputData3 += textBox31.Text;
			inputData4 += textBox41.Text;
			inputData5 += textBox51.Text;
			inputData6 += textBox61.Text;
			inputData7 += textBox71.Text;
			inputData8 += textBox81.Text;

			double n, RPM600, RPM300, RPM, k, q, Dh, Dp, D, v, u, nn, v1, P, pm, ps, vsv, ds0, fmw, vs, v2, c, cn, D1, D2;
			int ang;
			Dp = Convert.ToDouble(inputData4);
			Dh = Convert.ToDouble(inputData3);
			RPM600 = Convert.ToDouble(inputData1);
			RPM300 = Convert.ToDouble(inputData2);
			ds0 = Convert.ToDouble(inputData6);
			pm = Convert.ToDouble(inputData5);
			ps = Convert.ToDouble(inputData7);
			ang = Convert.ToInt32(inputData8);


			RPM = RPM600 / RPM300;
			n = 3.32 * Math.Log10(RPM);
			k = RPM300 / Math.Pow(511, n);
			q = (4 * Math.Pow(Dh, 2) + (5 * Dh));
			v = (24.5 * q) / (Math.Pow(Dh, 2) - Math.Pow(Dp, 2));
			D = Math.Pow(Dh, 2) - Math.Pow(Dp, 2);
			P = ps - pm;
			nn = 1 - n;
			v1 = 144 * v;
			u = (k * Math.Pow(D, nn) / (Math.Pow(v1, nn))) * ((2 * (1 / n)) / 0.0208);
			vsv = (Math.Pow(P, 0.667) * 175 * ds0) / (Math.Pow(pm, 0.333) * Math.Pow(u, 0.333));
			fmw = 2.117 - 0.1648 * pm + 0.003681 * Math.Pow(pm, 2);
			vs = vsv * fmw;
			c = 40;
			cn = 32.3;
			D1 = D / 12;
			D2 = ((22 - pm) / pm) * Math.Pow(cn, 3) * (Math.Pow(D1, 3));
			v2 = c * Math.Pow(D2, 0.1667);
			double vmin, qmin;
			double angle1 = Math.Cos(ang);
			double angle2 = Math.Sin(ang);
			vmin = (vs * angle1) + (vs * angle2);
			qmin = (0.04079 * Math.Pow(Dh, 2)) - Math.Pow(Dp, 2) * vmin;

		}
	}
}
