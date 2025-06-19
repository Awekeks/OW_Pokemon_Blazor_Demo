using Models.Pokemons;
using Services.Constants;
using System.Net.Http.Json;
using System.Web;

namespace Services.Pokemons;

public class PokemonOverviewService : IPokemonOverviewService
{
    private readonly HttpClient _httpClient;

    public PokemonOverviewService()
    {
        _httpClient = new HttpClient() { BaseAddress = new Uri(RouteCatalog.PokeApiBaseUrl) };
    }

    public async Task<IEnumerable<PokemonOverviewDto>> GetPokemonOverviewsAsync(int limit = 20, int offset = 0, CancellationToken cancellationToken = default)
    {
        var query = HttpUtility.ParseQueryString(string.Empty);
        query[nameof(limit)] = limit.ToString();
        query[nameof(offset)] = offset.ToString();
        string queryString = query.ToString();

        var response = await _httpClient.GetAsync("pokemon?" + queryString);
        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<PokemonOverviewResultDto>(cancellationToken);

        return result?.Results ?? Enumerable.Empty<PokemonOverviewDto>();
    }
}
