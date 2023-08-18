using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Counter1
{
    public partial class MainPage : ContentPage
    {
        private int counter;

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddToCounter(object sender, EventArgs e)
        {
            this.counter++;
        }

        private void SeeResult(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ResultsPage(this.counter));
        }
    }
}

