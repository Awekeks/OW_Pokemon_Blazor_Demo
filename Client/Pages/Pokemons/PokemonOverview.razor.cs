using Models.Pokemons;

namespace Client.Pages.Pokemons;

public partial class PokemonOverview
{
    private PokemonListDto? _selectedPokemon;

    private void OnPokemonSelected(PokemonListDto? pokemon)
    {
        _selectedPokemon = pokemon;
    }
}
