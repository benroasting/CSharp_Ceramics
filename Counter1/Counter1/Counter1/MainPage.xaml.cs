﻿using System;
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
        private readonly Container container = new Container();

        public MainPage()
        {
            InitializeComponent();
        }

        private void AddToCounter(object sender, EventArgs e)
        {
            container.Counter++;
        }

        private void SeeResult(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultsPage(this.container));
        }
    }
}

