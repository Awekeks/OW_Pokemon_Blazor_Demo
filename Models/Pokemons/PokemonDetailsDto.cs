namespace Models.Pokemons;

public class PokemonDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BaseExperience { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Sprites Sprites { get; set; }
    public string LocationAreaEncounters { get; set; }
}

public class Sprites
{
    public string FrontDefault { get; set; }
}