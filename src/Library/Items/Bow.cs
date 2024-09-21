namespace Ucu.Poo.RoleplayGame;

public class Bow:Items
{
    public string Name { get; }
    public int Defenselevel { get; }
    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }

    public Bow(string name)
    {
        this.Name = name;
        this.Defenselevel = 0;
        this.AttackLevel = 30;
        this.HealthLevel = 0;
        this.IsMagic = false;
    }
}