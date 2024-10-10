using DefaultNamespace;

namespace Library.Combate;

public class Jugador
{
    private string name;
    private List<Pokemon> lista_pokemons;
    private Pokemon pokemonEnTurno;
    private int turnosjugados;
    private bool esMiTurno;
    private bool teamIsAlive;

    private Jugador(string name)
    {
        this.name = name;
        this.lista_pokemons = new List<Pokemon>();
        this.turnosjugados = 0;
        this.esMiTurno = false;
        this.teamIsAlive = true;
    }
    
    public void CambiarPokemonEnTurno(int numeropokemon)
    {
        //Este metodo permite cambiar el pokemon que el jugador esta utilizando actualmente por otro dentro de los de su propio equipo (siempre y cuando el otro pokemon se encuentre con vida)
        //al hacer este cambio el jugador pierde su turno.
    }

    public void AgregarAlEquipo(string nombrepokemon)
    {
    }
}