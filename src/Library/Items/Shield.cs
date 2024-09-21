namespace Ucu.Poo.RoleplayGame;

public class Shield
{
    public string Name { get; }

    public int Defenselevel
    {
        get
        {
            return 30;
        }
    }

    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public Shield(string name)
    {
        this.Name = name;
        this.AttackLevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}