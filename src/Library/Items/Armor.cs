using RoleplayGame2;

namespace Ucu.Poo.RoleplayGame;

public class armor: IItem
{
    public string Name { get; }
    private int usos;
    private int proteccion;
    public int DefenseLevel
    {
        get
        {
            return 60;
        }
    }

    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public armor(string name)
    {
        this.Name = name;
        this.AttackLevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }

    public void AddSpell(string missing_name)
    {
        throw new NotImplementedException();
    }
    
    public int GetDefensa(ICharacter name)
    {
        if (this.usos <= 2)
        {
            this.proteccion -= 20;
            this.usos += 1;
        }

        if (this.proteccion <= 0)
        {
            Console.WriteLine($"A {this.Name} se le ha roto la Armadura");
            this.proteccion = 0;
        }
        return this.proteccion;
    }
}