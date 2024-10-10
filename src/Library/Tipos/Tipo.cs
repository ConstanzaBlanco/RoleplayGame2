using System.Reflection;

namespace Library.Tipos;
//ACA FALTA IMPLEMENTAR LA LÓGICA DE UN DICCIONARIO (TODO ESTÁ COMO LISTA AHORA)
public class Tipo
{
    private string name;
    private List<Tipo> listaSuperEfectivos = new List<Tipo>();
    private List<Tipo> listaNeutros = new List<Tipo>();
    private List<Tipo> listaDebiles = new List<Tipo>();
    
    public double DarEfectividad(Tipo tipo)
    {
        if (listaDebiles.Contains(tipo))
        {
            return 0.5;
        }
        else if (listaSuperEfectivos.Contains(tipo))
        {
            return 2.0;
        }
        else if (listaNeutros.Contains(tipo))
        {
            return 1.0;
        }
        else
        {
            return 0;
        }
    }

    public Tipo(string name)
    {
        this.name = name;
    }
}