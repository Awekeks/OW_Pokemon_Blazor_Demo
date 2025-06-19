namespace Models.Pokemons;

public class PokemonDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BaseExperience { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Sprites Sprites { get; set; }
    public Cries Cries { get; set; }
}

public class Sprites
{
    public string Front_Default { get; set; }
}

public class Cries
{
    public string Latest { get; set; }
    public string Legacy { get; set; }
}