using Library.Tipos;
using Ucu.Poo.Pokemon;

namespace DefaultNamespace;

public class Pokemon
{
    private string name;
    private List<IMovimiento> lista_movimientos = new List<IMovimiento>();
    private List<Tipo> lista_tipos = new List<Tipo>();
    private int vidaactual;
    private int vidatotal;
    private int defensa;
    private bool is_alive;

    public Pokemon(string nombre, List<IMovimiento> movimientos, List<Tipo> tipos, int vida, int defensa)
    {
        name = nombre;
        lista_movimientos = movimientos;
        lista_tipos = tipos;
        vidaactual = vida;
        vidatotal = vida;
        is_alive = true;
        this.defensa = defensa;
    }
}