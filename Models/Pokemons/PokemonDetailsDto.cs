namespace Models.Pokemons;

public class PokemonDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Sprites Sprites { get; set; }
    public Cries Cries { get; set; }
    public List<AbilitySlot> Abilities { get; set; }
    public List<TypeSlot> Types { get; set; }
}

#region SubClasses
public class Sprites
{
    public string Front_Default { get; set; }
}

public class Cries
{
    public string Latest { get; set; }
    public string Legacy { get; set; }
}

public class TypeSlot
{
    public int Slot { get; set; }
    public TypeInfo Type { get; set; }
}

public class TypeInfo
{
    public string Name { get; set; }
    public string Url { get; set; }
}

public class AbilitySlot
{
    public AbilityInfo Ability { get; set; }
    public bool Is_Hidden { get; set; }
    public int Slot { get; set; }
}

public class AbilityInfo
{
    public string Name { get; set; }
    public string Url { get; set; }
}
#endregion