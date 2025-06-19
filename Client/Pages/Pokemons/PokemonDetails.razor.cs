using Microsoft.AspNetCore.Components;
using Models.Pokemons;

namespace Client.Pages.Pokemons;

public partial class PokemonDetails
{

    [Parameter]
    public PokemonOverviewDto? PokemonOverview { get; set; }

    private PokemonDetailsDto? _pokemonDetails;
    private CancellationTokenSource _cancellationTokenSource = new();

    protected override async Task OnParametersSetAsync()
    {
        if (PokemonOverview != null)
        {
            _pokemonDetails = await pokemonDetailService.GetPokemonDetailAsync(PokemonOverview.Url, _cancellationTokenSource.Token);
        }
    }
}
