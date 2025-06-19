using Microsoft.AspNetCore.Components;
using Models.Pokemons;
using MudBlazor;

namespace Client.Components;

public partial class PokemonList
{
    [Parameter]
    public EventCallback<PokemonListDto?> OnPokemonSelected { get; set; }

    private readonly CancellationTokenSource _cancellationTokenSource = new();

    private IEnumerable<PokemonListDto>? _pokemons;
    private PokemonListDto? _selectedPokemon;
    private bool _isLoading;
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
            snackbar.Add("Failed to load Pokémon data. Please try again later.", Severity.Error);
        }
        finally
        {
            _isLoading = false;
        }
    }

    private void PokemonSelected(TableRowClickEventArgs<PokemonListDto> tableRowClickEventArgs)
    {
        _selectedPokemon = tableRowClickEventArgs.Item;
        OnPokemonSelected.InvokeAsync(_selectedPokemon);
    }

    private bool FilterPokemon(PokemonListDto pokemon) => FilterPokemonByString(pokemon, searchPokemon);

    private bool FilterPokemonByString(PokemonListDto pokemon, string searchPokemon)
    {
        SaveSearchPokemon(searchPokemon);

        if (string.IsNullOrWhiteSpace(searchPokemon))
            return true;
        if (pokemon.Name.Contains(searchPokemon, StringComparison.OrdinalIgnoreCase))
            return true;

        return false;
    }

    private void SaveSearchPokemon(string searchPokemon)
    {
        Task.Run(async () => await localStorage.SetItemAsync(nameof(searchPokemon), searchPokemon));
    }
}
