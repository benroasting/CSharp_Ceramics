using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Counter1
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

