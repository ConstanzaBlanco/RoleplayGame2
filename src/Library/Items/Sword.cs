namespace Ucu.Poo.RoleplayGame;

public class Sword:IItem
{
    public string Name { get; }
    public int DefenseLevel { get; }

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
        this.DefenseLevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}