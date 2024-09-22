namespace Ucu.Poo.RoleplayGame;

public class armor: IItem
{
    public string Name { get; }

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
}