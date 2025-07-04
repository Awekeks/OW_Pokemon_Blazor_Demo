﻿namespace Models.Pokemons;

public class PokemonListResultDto
{
    public int Count { get; set; }
    public string Next { get; set; }
    public string Previous { get; set; }
    public IEnumerable<PokemonListDto> Results { get; set; }
}