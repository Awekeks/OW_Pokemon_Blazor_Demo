using Models.Pokemons;
using MudBlazor;

namespace Client.Pages.Pokemons;

public partial class PokemonOverview
{
    private IEnumerable<PokemonOverviewDto> _pokemons;
    private PokemonOverviewDto? _selectedPokemon;
    private bool _isLoading;
    private CancellationTokenSource _cancellationTokenSource = new();

    private string searchPokemon = string.Empty;

    override protected async Task OnInitializedAsync()
    {
        _isLoading = true;
        try
        {
            searchPokemon = await localStorage.GetItemAsync<string>(nameof(searchPokemon));
            _pokemons = await pokemonOverviewService.GetPokemonOverviewsAsync(20, 0, _cancellationTokenSource.Token);
        }
        catch (HttpRequestException)
        {
            // Handle cancellation if needed
        }
        finally
        {
            _isLoading = false;
        }
    }

    private void OnPokemonSelected(TableRowClickEventArgs<PokemonOverviewDto> tableRowClickEventArgs)
    {
        _selectedPokemon = tableRowClickEventArgs.Item;
    }

    private bool FilterPokemon(PokemonOverviewDto pokemon) => FilterPokemonByString(pokemon, searchPokemon);

    private bool FilterPokemonByString(PokemonOverviewDto pokemon, string searchPokemon)
    {
        localStorage.SetItemAsync(nameof(searchPokemon), searchPokemon);

        if (string.IsNullOrWhiteSpace(searchPokemon))
            return true;
        if (pokemon.Name.Contains(searchPokemon, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }
}
