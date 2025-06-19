using Microsoft.Extensions.DependencyInjection;
using Services.Pokemons;

namespace Client.Code;

public static class ServiceCollectionExtensions
{
    public static void AddOWServices(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IPokemonOverviewService, PokemonOverviewService>();
        services.AddScoped<IPokemonDetailService, PokemonDetailService>();
    }
}
