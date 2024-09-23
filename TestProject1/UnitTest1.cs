using NUnit.Framework;
using RoleplayGame2;
using Ucu.Poo.RoleplayGame;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void AtacarTest()
        {
            // Inicialización de personajes
            ICharacter caballero1 = new Knight("PrincipeEncantador");  // Vida inicial: 90
            ICharacter mago1 = new Wizard("Voldemort"); // Vida inicial: 80
            IItem escudo = new Shield("escudocap"); 
            IItem pocion = new Potion("Curativa"); 
            IItem baston = new Staff("Báculo");
            mago1.AddItem(pocion);
            mago1.AddItem(baston);
            caballero1.AddItem(escudo);

            // Simula un ataque
            mago1.Attack(baston, caballero1);
            int vidaEsperada = 80; 
            int vidaReal = caballero1.HealthLevel;
            Assert.AreEqual(vidaEsperada, vidaReal);
        }

        [Test]
        public void Defender()
        {
            ICharacter arquero1 = new Archer("Hawkeye");  // Vida inicial: 110
            ICharacter mago1 = new Wizard("Voldemort"); // Vida inicial: 80
            IItem escudo = new Shield("escudocap"); 
            IItem pocion = new Potion("Curativa"); 
            IItem baston = new Staff("Báculo");
            mago1.AddItem(pocion);
            mago1.AddItem(baston);
            arquero1.AddItem(escudo);

            // Simula una defensa
            arquero1.Defense(escudo);
            mago1.Attack(baston, arquero1);
            int vidaEsperada = 110; //Tiene la misma vida puesto que su defensa es mayor al ataque recibido 
            int vidaReal = arquero1.HealthLevel;
            Assert.AreEqual(vidaEsperada, vidaReal);
        }
        [Test]
        public void CurarTest()
        {
            // Inicialización de personajes
            ICharacter elfo1 = new Dwarf("Zelda"); // Vida inicial: 120
            Wizard mago1 = new Wizard("Voldemort"); // Vida inicial: 80
            IItem espada = new Sword("Zenith"); 
            IItem pocion = new Potion("Curativa"); 
            IItem baston = new Staff("Báculo");
            mago1.AddItem(pocion);
            mago1.AddItem(baston);
            elfo1.AddItem(espada);
            
            // Simula una curación
            elfo1.Attack(espada,mago1); //Hace 15 de daño al mago, por lo que este quedaría con 70 de vida
            mago1.Heal(pocion);
            int VidaEsperada = 95; //Se cura 30 puntos, quedando con 95
            int VidaReal = mago1.HealthLevel;
            Assert.AreEqual(VidaEsperada,VidaReal);
        }

        [Test]
        public void CurarMaximoTest()
        {
            Wizard mago1 = new Wizard("Voldemort"); // Vida inicial: 80
            Potion pocion = new Potion("Curativa"); 
            mago1.AddItem(pocion);

            //Este test sirve para ver si se cumple con que el maximo de vida sea 120
            mago1.Heal(pocion); //pasaría a tener 110 de vida
            mago1.Heal(pocion);
            int VidaEsperada = 120;
            int VidaReal = mago1.HealthLevel;
            Assert.AreEqual(VidaEsperada,VidaReal);

        }
    }
    
}