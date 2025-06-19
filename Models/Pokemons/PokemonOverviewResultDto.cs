namespace Models.Pokemons;

public class PokemonOverviewResultDto
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public IEnumerable<PokemonOverviewDto> Results { get; set; }
}