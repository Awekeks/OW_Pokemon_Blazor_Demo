using Services.Constants;

namespace Services.Pokemons;

public class PokemonBaseService : BaseService
{
    public PokemonBaseService() : base(RouteCatalog.PokeApiBaseUrl)
    {
    }
}
