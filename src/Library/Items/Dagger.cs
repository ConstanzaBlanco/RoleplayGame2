namespace Ucu.Poo.RoleplayGame;

public class Dagger:Items
{
    public string Name { get; }
    public int Defenselevel { get; }

    public int AttackLevel
    {
        get
        {
            return 20;
        }
    }

    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public Dagger(string name)
    {
        this.Name = name;
        this.Defenselevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}