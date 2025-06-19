using Models.Pokemons;

namespace Services.Pokemons;

public interface IPokemonOverviewService
{
    public Task<IEnumerable<PokemonOverviewDto>> GetPokemonOverviewsAsync(int limit = 20, int offset = 0, CancellationToken cancellationToken = default);
}
