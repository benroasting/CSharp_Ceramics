using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Counter3
{	
	public partial class ResultPage : ContentPage
	{
        private readonly Container container;

        public ResultPage (Container container)
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

