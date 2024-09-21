namespace Ucu.Poo.RoleplayGame;

public class armor
{
    public string Name { get; }
    public int Defenselevel { get; }
    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public armor(string name)
    {
        this.Name = name;
        this.Defenselevel = 60;
        this.AttackLevel = 0;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}