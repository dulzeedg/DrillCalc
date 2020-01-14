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

			double HBPs, HBPm, HBPv, HBYp, HBQ, HBDh,
					HBDp, HBDcut, HBRop, HBCconc;

			double BVa, BD, BP, BVsv, BU,
					Bfmw, Vs, c, g, D1, D2, V2, ang;



			//int ang;
			HBPs = Convert.ToDouble(inputData0);
			HBPm = Convert.ToDouble(inputData1);
			HBPv = Convert.ToDouble(inputData2);
			HBYp = Convert.ToDouble(inputData3);
			HBQ = Convert.ToDouble(inputData4);
			HBDh = Convert.ToDouble(inputData5);
			HBDp = Convert.ToDouble(inputData6);
			HBDcut = Convert.ToDouble(inputData7);
			HBRop = Convert.ToDouble(inputData8);
			HBCconc = Convert.ToDouble(inputData6);

			// Ambiguity


			// Hopkins's Calc.
			BVa = (24.5 * HBQ) / (Math.Pow(HBDh, 2) - Math.Pow(HBDp, 2));
			BD = HBDh - HBDp;
			BU = HBPv + (5 * HBYp * (BD / BVa));
			BP = HBPs - HBPm;
			BVsv = ((Math.Pow(BP, 0.667) * 175 * HBDcut) / (Math.Pow(HBPm, 0.333) * Math.Pow(BU, 0.333)));
			Bfmw = 2.117 - 0.1648 * HBPm + 0.003681 * Math.Pow(HBPm, 2);
			Vs = BVsv * Bfmw;
			c = 40;
			g = 32.3;
			D1 = BD / 12;
			D2 = ((HBPs - HBPm) / HBPm) * Math.Pow(g, 3) * (Math.Pow(D1, 3));
			V2 = c * Math.Pow(D2, 0.1667);
			for (ang = 0; ang < 91; ang = +1)
			{
				double vmin, qmin;
				double angle1 = Math.Cos(ang);
				double angle2 = Math.Sin(ang);
				vmin = Math.Abs((Vs * angle1) + (V2 * angle2));
				qmin = (0.04079 * Math.Pow(HBDh, 2) - Math.Pow(HBDp, 2)) * vmin;
			}
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

			double HHPs, HHPm, HHn, HHk, HHQ, HHDh,
					HHDp, HHDcut, HHRop, HHCconc;

			HHPs = Convert.ToDouble(inputData10);
			HHPm = Convert.ToDouble(inputData11);
			HHn = Convert.ToDouble(inputData12);
			HHk = Convert.ToDouble(inputData13);
			HHQ = Convert.ToDouble(inputData14);
			HHDh = Convert.ToDouble(inputData15);
			HHDp = Convert.ToDouble(inputData16);
			HHDcut = Convert.ToDouble(inputData17);
			HHRop = Convert.ToDouble(inputData18);
			HHCconc = Convert.ToDouble(inputData19);


			// Var
			double HVa, HD, Nn, HU, HP, HVsv,
					HFmw, vs, c, g, D1, D2, V2, ang;

			HVa = (24.5 * HHQ) / (Math.Pow(HHDh, 2) - Math.Pow(HHDp, 2));
			HD = HHDh - HHDp;
			Nn = 1 - HHn;
			HU = ((HHk * (Math.Pow(HD, Nn))) / (144 * (Math.Pow(HVa, Nn)))) * ((2 * (1 / HHn)) / 0.0208);
			HP = HHPs - HHPm;
			HVsv = (Math.Pow(HP, 0.667) * 175 * HHDcut) / (Math.Pow(HHPm, 0.333) * Math.Pow(HU, 0.333));
			HFmw = 2.117 - 0.1648 * HHPm + 0.003681 * Math.Pow(HHPm, 2);
			vs = HVsv * HFmw;
			c = 40;
			g = 32.3;
			D1 = HD / 12;
			D2 = ((HHPs - HHPm) / HHPm) * Math.Pow(g, 3) * (Math.Pow(D1, 3));
			V2 = c * Math.Pow(D2, 0.1667);
			for (ang = 0; ang < 91; ang = +1)
			{
				double vmin, qmin;
				double angle1 = Math.Cos(ang);
				double angle2 = Math.Sin(ang);
				vmin = Math.Abs((vs * angle1) + (V2 * angle2));
				qmin = (0.04079 * Math.Pow(HHDh, 2) - Math.Pow(HHDp, 2)) * vmin;
			}

		}
	}
}
