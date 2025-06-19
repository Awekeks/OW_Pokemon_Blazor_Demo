using Models.Pokemons;
using MudBlazor;

namespace Client.Pages.Pokemons;

public partial class PokemonOverview
{
    private IEnumerable<PokemonOverviewDto> _pokemons;
    private PokemonOverviewDto? _selectedPokemon;
    private CancellationTokenSource _cancellationTokenSource = new();

    override protected async Task OnInitializedAsync()
    {
        _pokemons = await pokemonOverviewService.GetPokemonOverviewsAsync(20, 0, _cancellationTokenSource.Token);
    }

    private void OnPokemonSelected(TableRowClickEventArgs<PokemonOverviewDto> tableRowClickEventArgs)
    {
        _selectedPokemon = tableRowClickEventArgs.Item;
    }
}
