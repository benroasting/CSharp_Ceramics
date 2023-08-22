using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace ListView1
{
	public class AppModels
	{
		public ObservableCollection<Pokemon> Species { get; } = new ObservableCollection<Pokemon>
		{
			new Pokemon
			{ Name = "Bulbasaur", Description = "", ImageSource = "" },
			new Pokemon
			{ Name = "Wobbuffet", Description = "", ImageSource = "" },

		};

		public void ReleasePokemon(Pokemon pokemon)
		{
			this.Species.Remove(pokemon);
		}

		public void CatchPokemon(Pokemon pokemon)
		{

		}

    }
}

