using Models.Pokemons;

namespace Services.Pokemons;

public interface IPokemonListService
{
    public Task<IEnumerable<PokemonListDto>> GetPokemonOverviewsAsync(int limit = 20, int offset = 0, CancellationToken cancellationToken = default);
}
