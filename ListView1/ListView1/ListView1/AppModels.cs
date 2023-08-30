using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListView1
{

	public class AppModels
	{

        public ObservableCollection<Pokemon> Pokemons { get; } = new ObservableCollection<Pokemon>
		{
			new Pokemon
			{ Name = "Bulbasaur", Pokedex="001", Description="There is a plant seed on its back right from the day this Pokémon is born.", ImageSource="https://assets.pokemon.com/assets/cms2/img/pokedex/detail/001.png" },
			new Pokemon
			{ Name = "Wobbuffet", Pokedex="201", Description="It hates light and shock. If attacked, it inflates its body to pump up its counterstrike.", ImageSource="https://assets.pokemon.com/assets/cms2/img/pokedex/full/202.png" },
			new Pokemon
			{ Name = "Sableye", Pokedex="302", Description="It dwells in the darkness of caves. It uses its sharp claws to dig up gems to nourish itself.", ImageSource="https://assets.pokemon.com/assets/cms2/img/pokedex/full/302.png"}
		};

        public void ReleasePokemon(Pokemon pokemon)
        {
            Pokemons.Remove(pokemon);
        }


        public void CatchPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

    }
}

