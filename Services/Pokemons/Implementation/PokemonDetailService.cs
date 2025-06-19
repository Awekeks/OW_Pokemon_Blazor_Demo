using Models.Pokemons;

namespace Services.Pokemons;

public class PokemonDetailService : PokemonBaseService, IPokemonDetailService
{
    public async Task<PokemonDetailsDto?> GetPokemonDetailAsync(string url, CancellationToken cancellationToken = default)
    {
        return await GetAsync<PokemonDetailsDto?>(url, cancellationToken: cancellationToken);
    }
}
