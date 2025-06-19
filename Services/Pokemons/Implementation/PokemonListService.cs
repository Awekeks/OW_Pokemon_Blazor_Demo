using Models.Pokemons;
using System.Web;

namespace Services.Pokemons;

public class PokemonListService : PokemonBaseService, IPokemonListService
{
    private const string methodName = "pokemon";

    public async Task<IEnumerable<PokemonListDto>> GetPokemonOverviewsAsync(int limit = 20, int offset = 0, CancellationToken cancellationToken = default)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        query[nameof(limit)] = limit.ToString();
        query[nameof(offset)] = offset.ToString();
        string queryString = query.ToString();

        var pokemonOverviewResult = await GetAsync<PokemonListResultDto>($"{methodName}?{queryString}", cancellationToken: cancellationToken);
        return pokemonOverviewResult?.Results ?? [];
    }
}
