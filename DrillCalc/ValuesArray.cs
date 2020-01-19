using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillCalc
{
	class ValuesArray
	{
		public ValuesArray()
		{

		}
		public double[] Values { get; set; }

		/*public double[] GetValues((double[] value)
		{	
			return Values;
		}*/

		public void SetValues(double[] value)
		{
			Values = value;
		}

		/*public StoreValues(values)
		{
			RubiModel rubiModel = new RubiModel();
			double[] v = rubiModel.HVMinArray;
			
		}*/
		

		
	}


	
}	
