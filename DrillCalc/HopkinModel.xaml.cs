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


		// Declaring Variables for Bingham
		string inputData0 = string.Empty;
		string inputData1 = string.Empty;
		string inputData2 = string.Empty;
		string inputData3 = string.Empty;
		string inputData4 = string.Empty;
		string inputData5 = string.Empty;
		string inputData6 = string.Empty;
		string inputData7 = string.Empty;
		string inputData8 = string.Empty;
		string inputData9 = string.Empty;

		// Declaring Variables for Herschel
		string inputData10 = string.Empty;
		string inputData11 = string.Empty;
		string inputData12 = string.Empty;
		string inputData13 = string.Empty;
		string inputData14 = string.Empty;
		string inputData15 = string.Empty;
		string inputData16 = string.Empty;
		string inputData17 = string.Empty;
		string inputData18 = string.Empty;
		string inputData19 = string.Empty;

		private void HopkinBingham_Button_Click_Calc(object sender, RoutedEventArgs e)
		{
			// add user input from textbox to var input

			inputData0 += HBtextBoxPs.Text;
			inputData1 += HBtextBoxPf.Text;
			inputData2 += HBtextBoxPv.Text;
			inputData3 += HBtextBoxYp.Text;
			inputData4 += HBtextBoxQ.Text;
			inputData5 += HBtextBoxDh.Text;
			inputData6 += HBtextBoxDp.Text;
			inputData7 += HBtextBoxDcut.Text;
			inputData8 += HBtextBoxRop.Text;
			inputData9 += HBtextBoxCconc.Text;

			double HBPs, HBPf, HBPv, HBYp, HBQ, HBDh,
					HBDp, HBDcut, HBRop, HBCconc;

			//double Va;



			//int ang;
			HBPs = Convert.ToDouble(inputData0);
			HBPf = Convert.ToDouble(inputData1);
			HBPv = Convert.ToDouble(inputData2);
			HBYp = Convert.ToDouble(inputData3);
			HBQ = Convert.ToDouble(inputData4);
			HBDh = Convert.ToDouble(inputData5);
			HBDp = Convert.ToDouble(inputData6);
			HBDcut = Convert.ToDouble(inputData7);
			HBRop = Convert.ToDouble(inputData8);
			HBCconc = Convert.ToDouble(inputData6);

			// Ambiguity
			/*

			// Hopkins's Calc.

			RPM = RPM600 / RPM300;
			n = 3.32 * Math.Log10(RPM);
			k = RPM300 / Math.Pow(511, n);
			q = (4 * Math.Pow(Dh, 2) + (5 * Dh));
			
			Va = (24.5 * HBQ) / (Math.Pow(HBDh, 2) - Math.Pow(HBDp, 2));
			
			D = Math.Pow(HBDh, 2) - Math.Pow(HBDp, 2);
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
			*/

		}

		private void HopkinHerschel_Button_Click_Calc(object sender, RoutedEventArgs e)
		{
			inputData10 += HHtextBoxPs.Text;
			inputData11 += HHtextBoxPf.Text;
			inputData12 += HHtextBoxn.Text;
			inputData13 += HHtextBoxk.Text;
			inputData14 += HHtextBoxQ.Text;
			inputData15 += HHtextBoxDh.Text;
			inputData16 += HHtextBoxDp.Text;
			inputData17 += HHtextBoxDcut.Text;
			inputData18 += HHtextBoxRop.Text;
			inputData19 += HHtextBoxCcon.Text;

			double HHPs, HHPf, HHn, HHk, HHQ, HHDh,
					HHDp, HHDcut, HHRop, HHCconc;

			HHPs = Convert.ToDouble(inputData10);
			HHPf = Convert.ToDouble(inputData11);
			HHn = Convert.ToDouble(inputData12);
			HHk = Convert.ToDouble(inputData13);
			HHQ = Convert.ToDouble(inputData14);
			HHDh = Convert.ToDouble(inputData15);
			HHDp = Convert.ToDouble(inputData16);
			HHDcut = Convert.ToDouble(inputData17);
			HHRop = Convert.ToDouble(inputData18);
			HHCconc = Convert.ToDouble(inputData19);


			// Var
			//double Va, Q;


			// Calc  Not Done because of ambiguity
			//Va = 24.5 * Q;
		}
	}
}
