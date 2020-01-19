using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DrillCalc
{
	/// <summary>
	/// Interaction logic for GraphTable.xaml
	/// </summary>
	public partial class GraphTable : Window
	{
		internal IntPtr Handle;

		public GraphTable()
		{
			InitializeComponent();
		}
		/*
		class HomeTable
		{
			public static implicit operator UserControl(GraphTable v)
		{
			NewMethod();
		}

		private static GraphTable NewMethod()
		{
			return new GraphTable;
		}
			
		}
		*/

		public class Customer
		{
			
			//public Double Vmin { get; set; }

			public String FirstName { get; set; }
			public String LastName { get; set; }
			public String Address { get; set; }
			public Boolean IsNew { get; set; }

			/*public Value(Double vmin)
			{
				this.Vmin = vmin;
			}
			public static List<Value> Values()
			{ 
				return new List<Value>(new Value[4]
				{ new Value(10),
						new Value(20),
						new Value(30),
						new Value(40)
				});
			}*/
			public Customer(String firstName, String lastName, String address, Boolean isNew)
			{
				this.FirstName = firstName;
				this.LastName = lastName;
				this.Address = address;
				this.IsNew = isNew;
			}

			
			public static List<Customer> Customers()
			{
				return new List<Customer>(new Customer[4]
					{
						new Customer("A." , "Zero", "12 Street, Apt 45", false),
						new Customer("A." , "Zero", "34 Street, Apt 50", false),
						new Customer("A." , "Zero", "56 Street, Apt 60", true),
						new Customer("A." , "Zero", "78 Street, Apt 70", true)
					});
			}


			///double[] v;
			//v = VArray;
			//datagrid datagrid = new datagrid;
			//dataGrid.ItemsSource = VArray;
			// v

		}

		
		//public double[] VArray { get; set; }

	}
}
