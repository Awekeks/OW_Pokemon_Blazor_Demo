using Models.Pokemons;

namespace Services.Pokemons;

public interface IPokemonDetailService
{
    public Task<PokemonDetailsDto?> GetPokemonDetailAsync(string url, CancellationToken cancellationToken = default);
}
