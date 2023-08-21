using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Counter2
{	
	public partial class ResultsPage : ContentPage
	{	
		private readonly Container container;

		public ResultsPage (Container container)
		{
			InitializeComponent ();
			this.container = container;

			CounterLabel.Text = container.Counter.ToString();
		}

		private void Reset(object sender, EventArgs e)
		{
			container.Counter = 0;
			CounterLabel.Text = this.container.Counter.ToString();
		}
	}
}

