using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Counter1
{	
	public partial class ResultsPage : ContentPage
	{
		private int counter;

		public ResultsPage (int counter)
		{
			InitializeComponent ();
			this.counter = counter;
			this.CounterLabel.Text = counter.ToString();
		}

        private void Reset(object sender, EventArgs e)
        {
            this.counter = 0;
            this.CounterLabel.Text = this.counter.ToString();
        }
    }
}

