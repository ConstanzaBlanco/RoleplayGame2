namespace Ucu.Poo.Pokemon;
public class MovimientoDefensivo : IMovimiento_Defensa
    {
        public int defensa { get; set; }  // El setter es privado

        public MovimientoDefensivo()
        {
            this.defensa = defensa;  // Solo se puede establecer dentro de la clase
        }
    }