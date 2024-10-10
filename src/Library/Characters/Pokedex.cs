using Library.Tipos;
using Ucu.Poo.Pokemon;

namespace DefaultNamespace;

public class Pokedex
{
    private List<Tipo> listatiposdisponibles = new List<Tipo>();
    private List<Pokemon> pokemonsdisponibles = new List<Pokemon>();
    private List<IMovimiento> listaMovimientos = new List<IMovimiento>();

    public void MostrarCatalogo()
    {
        foreach (Pokemon pokemon in pokemonsdisponibles)
        {
            Console.WriteLine(pokemon);
        }
    }
}

