using System;
using System.Windows;
using System.Windows.Controls;

namespace DrillCalc
{
	public partial class RubiModel : UserControl
	{
		public RubiModel()
		{
			InitializeComponent();
		}

		// Declaring Variables for Bingham
		string inputData00 = string.Empty;
		string inputData01 = string.Empty;
		string inputData02 = string.Empty;
		string inputData03 = string.Empty;
		string inputData04 = string.Empty;
		string inputData10 = string.Empty;
		string inputData11 = string.Empty;
		string inputData12 = string.Empty;
		string inputData13 = string.Empty;
		string inputData14 = string.Empty;

		// Declaring Variables for Herschel
		string inputData20 = string.Empty;
		string inputData21 = string.Empty;
		string inputData22 = string.Empty;
		string inputData23 = string.Empty;
		string inputData24 = string.Empty;
		string inputData30 = string.Empty;
		string inputData31 = string.Empty;
		string inputData32 = string.Empty;
		string inputData33 = string.Empty;
		string inputData34 = string.Empty;
		string inputData35 = string.Empty;



		public double BVMinArray { get; set; }
		public double HVMinArray { get; set; }

		private void Bingham_Button_Click_Calc(object sender, RoutedEventArgs e)
		{

			// add user input from textbox to var input
			inputData00 += BtextBoxPv.Text;
			inputData01 += BtextBoxYp.Text;
			inputData02 += BtextBoxPm.Text;
			inputData03 += BtextBoxDh.Text;
			inputData04 += BtextBoxDp.Text;
			inputData10 += BtextBoxPs.Text;
			inputData11 += BtextBoxDc.Text;
			inputData12 += BtextBoxRop.Text;
			inputData13 += BtextBoxRpm.Text;
			inputData14 += BtextBoxCconc.Text;


			// Calculating Output
			//  Main i/p Variables, B is added to all var for proper ref
			double BPv, BYp, BPm, BDh, BDp,
					BPs, BDc, BRop, BRpm, BCconc;
			double BDT, BDTSqrd, BVcut, BVs1,
					BVmin, BD1, BUa, BRe,
						BF, BVslip, BVMin;
			int i;
			BPv = Convert.ToDouble(inputData00);
			BYp = Convert.ToDouble(inputData01);
			BPm = Convert.ToDouble(inputData02);
			BDh = Convert.ToDouble(inputData03);
			BDp = Convert.ToDouble(inputData04);
			BPs = Convert.ToDouble(inputData10);
			BDc = Convert.ToDouble(inputData11);
			BRop = Convert.ToDouble(inputData12);
			BRpm = Convert.ToDouble(inputData13);
			BCconc = Convert.ToDouble(inputData14);

			// Calculations
			BDT = BDp / BDh;
			BDTSqrd = 1 - Math.Pow(BDT, 2);
			BVcut = BRop / (36 * BDTSqrd * BCconc);
			BVs1 = 3.14;
			BVmin = BVcut + BVs1;
			BD1 = BDh - BDp;
			BUa = BPv + (5 * BYp * BD1 / BVmin);
			BRe = (928 * BPm * BDc * BVs1) / BUa;
			BF = 0;
			{
				if (BRe <= 3)
				{
					BF = 40 / BRe;
				}

				else if (BRe >= 300)
				{
					BF = 1.54;
				}

				else if (BRe > 3 && BRe < 300)
				{
					BF = 22 / Math.Sqrt(BRe);
				}
			}

			BVslip = 1.89 * Math.Sqrt(Math.Abs((((BDc / BF) * ((BPs - BPm) / BPm)))));

			for (i = 0; i < 91; i++)
			{

				if (i < 45)
				{
					// There's a bug
					//BVMin = BVcut + ((1 + (2 * i / 45)) * (1 - (BRpm / 600)) * ((3 + BPm) / 15) * BVslip);
					//double[] BVMinArray = BVMin.Select(pkg => pkg.hasValue).ToArray();

				}
				else if (i > 45)
				{
					//BVMin = BVcut + (3 * (3 + (BPm / 15)) * (1 - (BRpm / 600)) * BVslip)
					//.where(d => d.hasValue)
					//.Cast<double>()
					//.ToArray();
				}


			}

			// send to plot
			PlotGraph PlotGraph1 = new PlotGraph();
			PlotGraph1.Show();
			Close();



			// Clear Input
			//BtextBox0.Text = "";

		}



		private void Herschel_Button_Click_Calc(object sender, RoutedEventArgs e)
		{
			// add user input from textbox to var input
			inputData20 += HtextBoxFb.Text;
			inputData21 += HtextBoxK.Text;
			inputData22 += HtextBoxPm.Text;
			inputData23 += HtextBoxDh.Text;
			inputData24 += HtextBoxDp.Text;
			inputData30 += HtextBoxPs.Text;
			inputData31 += HtextBoxCd.Text;
			inputData32 += HtextBoxRop.Text;
			inputData33 += HtextBoxRpm.Text;
			inputData34 += HtextBoxCcon.Text;
			inputData35 += HtextBoxFr.Text;

			// Calculating Output

			// Variables
			double HFb, Hk, HPm, HDh, HDp,
					HPs, HCd, HRop, HRpm,
						HCcon, HFr;

			double HDT, HDTSqrd, HVcut, HVs1,
					 HD, Hn, HUa, HRe,
						Hf, HVslip, HVMin;
			int i;

			HFb = Convert.ToDouble(inputData20);
			Hk = Convert.ToDouble(inputData21);
			HPm = Convert.ToDouble(inputData22);
			HDh = Convert.ToDouble(inputData23);
			HDp = Convert.ToDouble(inputData24);
			HPs = Convert.ToDouble(inputData30);
			HCd = Convert.ToDouble(inputData31);
			HRop = Convert.ToDouble(inputData32);
			HRpm = Convert.ToDouble(inputData33);
			HCcon = Convert.ToDouble(inputData34);
			HFr = Convert.ToDouble(inputData35);


			// Calculations
			HDT = HDp / HDh;
			HDTSqrd = 1 - Math.Pow(HDT, 2);
			HVcut = HRop / (36 * HDTSqrd * HCcon);
			HVs1 = 0.1;
			//HVmin = HVcut + HVs1;
			HD = HDh - HDp;
			Hn = 1 - HFb;
			HUa = ((((Hk * Math.Pow(HD, Hn))) / (144 * Math.Pow(HFr, Hn)))) * (Math.Pow(((2 + (1 / Hn)) / 0.0208), HFb));
			HRe = (928 * HPm * HCd * HVs1) / HUa;
			Hf = 0;
			if (HRe <= 3)
			{
				Hf = 40 / HRe;
			}

			else if (HRe >= 300)
			{
				Hf = 1.54;
			}

			else if (HRe > 3 && HRe < 300)
			{
				Hf = 22 / Math.Sqrt(HRe);
			}

			HVslip = 1.89 * (Math.Sqrt(Math.Abs((((HCd / Hf) * ((HPs - HPm) / HPm))))));

			for (i = 0; i < 91; i++)
			{

				if (i < 45)
				{
					//double[] = new double[90];
					HVMin = HVcut + ((1 + ((2 * i) / 45)) * (1 - (HRpm / 600)) * ((3 + HPm) / 15) * HVslip);
				}
				else if (i > 45)
				{
					HVMin = HVcut + (((3 * 3) + (HPm / 15)) * (1 - HRpm / 600) * HVslip);
				}

			}

			// send to plot

			DrillCalc.PlotGraph PlotGraph2 = new DrillCalc.PlotGraph();
			PlotGraph2.Show();
			RubiModel.Close();

			// Clear Input
			//HtextBox0.Text = "";


		}

		private static void Close()
		{
			throw new NotImplementedException();
		}
	}
}
