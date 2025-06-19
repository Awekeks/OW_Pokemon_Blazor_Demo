using Models.Pokemons;
using Services.Constants;
using System.Net.Http.Json;

namespace Services.Pokemons;

public class PokemonDetailService : IPokemonDetailService
{
    private readonly HttpClient _httpClient;

    public PokemonDetailService()
    {
        _httpClient = new HttpClient() { BaseAddress = new Uri(RouteCatalog.PokeApiBaseUrl) };
    }

    public async Task<PokemonDetailsDto?> GetPokemonDetailAsync(string url, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<PokemonDetailsDto?>(cancellationToken: cancellationToken);
    }
}
