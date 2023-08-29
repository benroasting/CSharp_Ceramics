using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView1
{
    public partial class MainPage : ContentPage
    {
        private readonly AppModels model;

        public MainPage()
        {
            this.InitializeComponent();
            this.model = App.AppModels;
            this.BindingContext = this.model;

        }

        private void ReleasePokemon(object sender, SelectedItemChangedEventArgs e)
        {
            this.model.ReleasePokemon(e.SelectedItem as Pokemon);
        }

        private void CatchPokemon(object sender, EventArgs e)
        {
            this.model.CatchPokemon(
                new Pokemon
                { Name = "Sableye", Pokedex = "302", Description = "It dwells in the darkness of caves. It uses its sharp claws to dig up gems to nourish itself.", ImageSource = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/302.png" });
        }
    }
}

