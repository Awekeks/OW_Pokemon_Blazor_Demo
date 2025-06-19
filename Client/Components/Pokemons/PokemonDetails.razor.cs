using Microsoft.AspNetCore.Components;
using Models.Pokemons;
using MudBlazor;

namespace Client.Components;

public partial class PokemonDetails
{

    [Parameter]
    public PokemonListDto? PokemonList { get; set; }

    private readonly CancellationTokenSource _cancellationTokenSource = new();

    private PokemonDetailsDto? _pokemonDetails;
    private bool _isLoading;

    protected override async Task OnParametersSetAsync()
    {
        if (PokemonList != null)
        {
            _isLoading = true;
            try
            {
                _pokemonDetails = await pokemonDetailService.GetPokemonDetailAsync(PokemonList.Url, _cancellationTokenSource.Token);
            }
            catch (HttpRequestException)
            {
                snackbar.Add($"Failed to load {PokemonList.Name} details. Please try again later.", Severity.Error);
            }
            finally
            {
                _isLoading = false;
            }
        }
    }
}
