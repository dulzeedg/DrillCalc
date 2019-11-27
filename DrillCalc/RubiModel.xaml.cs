﻿using System;
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
    public partial class RubiModel : UserControl
    {
        public RubiModel()
        {
            InitializeComponent();
        }

        // Declaring Variables
        string inputData1 = string.Empty;
        string inputData2 = string.Empty;
        string inputData3 = string.Empty;
        string inputData4 = string.Empty;
        string inputData5 = string.Empty;
        string inputData6 = string.Empty;
        string inputData7 = string.Empty;
        string inputData8 = string.Empty;
        string inputData9 = string.Empty;
        string inputData10 = string.Empty;

        private void button_Click_Calc(object sender, RoutedEventArgs e)
        {

            // add user input from textbox to var input
            inputData1 += textBox0.Text;
            inputData2 += textBox1.Text;
            inputData3 += textBox2.Text;
            inputData4 += textBox3.Text;
            inputData5 += textBox4.Text;
            inputData6 += textBox5.Text;
            inputData7 += textBox6.Text;
            inputData8 += textBox7.Text;
            inputData9 += textBox8.Text;
            inputData10 += textBox9.Text;

            // Calculating Output

            // Variables
            double Dpipe, Dhole, ROP, Dtot, a, Cconc, Vs1, Vmin, D1, Pv, YP, Ua, Re, D50, Pm, f, Vslip, Ps;
            double Vcut, abs, absV, RPM;
            int i;
            Dpipe = Convert.ToDouble(inputData5);
            Dhole = Convert.ToDouble(inputData4);
            ROP = Convert.ToDouble(inputData8);
            Cconc = Convert.ToDouble(inputData4);
            Pv = Convert.ToDouble(inputData1);
            YP = Convert.ToDouble(inputData2);
            D50 = Convert.ToDouble(inputData7);
            Pm = Convert.ToDouble(inputData3);
            Ps = Convert.ToDouble(inputData6);
            RPM = Convert.ToDouble(inputData9);
            Cconc = Convert.ToDouble(inputData10);

            // Calculations
            Dtot = Dpipe / Dhole;
            a = 1 - Math.Pow(Dtot, 2);
            Vcut = ROP / 36 * a * Cconc;
            Vs1 = 0.1;
            Vmin = Vcut + Vs1;
            D1 = Dhole - Dpipe;
            Ua = Pv + ((5 * YP * D1) / Vmin);
            Re = (928 * Pm * D50 * Vs1) / Ua;
            f = 0;
            if (Re < 3)
            {
                f = 40 / Re;
            }
            else if (Re > 300)
            {
                f = 1.54;
            }
            else if (Re > 3 && Re < 300)
            {
                f = 22 / Math.Sqrt(Re);
            }
            Vslip = 1.89 * (Math.Sqrt((D50 / f) * ((Ps - Pm) / Pm)));
            abs = Vslip - Vs1;
            absV = Math.Abs(abs);
            if (absV < 0.001)
            {
                for (i = 0; i < 100; i = +5)
                {
                    if (i < 45)
                    {
                        i = +5;
                        Vmin = Vcut + Vslip * (1 + ((i * (600 - RPM) * (3 + Pm)) / 202500));
                    }
                    else if (i > 45)
                    {
                        i = +5;
                        Vmin = Vcut + Vslip * (1 + ((i * (600 - RPM) * (3 + Pm)) / 4500));
                    }
                }
            }
            else if (absV > 0.001)
            {
                Vs1 = (Vslip + Vs1) / 2;
            }


            // Clear Input
            textBox0.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

        }
    }
}
