namespace Ucu.Poo.RoleplayGame;

public class Sword:Items
{
    public string Name { get; }
    public int Defenselevel { get; }

    public int AttackLevel
    {
        get
        {
            return 25;
        }
    }

    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public Sword(string name)
    {
        this.Name = name;
        this.Defenselevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}