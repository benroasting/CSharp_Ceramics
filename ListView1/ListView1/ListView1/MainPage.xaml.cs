using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView1
{
    public partial class MainPage : ContentPage
    {
        private readonly AppModels model;

        public MainPage()
        {
            InitializeComponent();
            model = new AppModels();
            BindingContext = model;
        }

        private void ReleasePokemon(object sender, SelectedItemChangedEventArgs e)
        {
            model.ReleasePokemon(e.SelectedItem as Pokemon);
        }

        private void CatchPokemon(object sender, EventArgs e)
        {
            model.CatchPokemon(
                new Pokemon
                { Name = "Sableye", Pokedex = "302", Description = "It dwells in the darkness of caves. It uses its sharp claws to dig up gems to nourish itself.", ImageSource = "https://assets.pokemon.com/assets/cms2/img/pokedex/full/302.png" });
        }

    }
}

