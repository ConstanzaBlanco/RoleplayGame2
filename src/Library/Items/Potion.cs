namespace Ucu.Poo.RoleplayGame;

public class Potion: IItem
{
    public string Name { get; }
    public int DefenseLevel { get; }
    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    public Potion(string name)
    {
        this.Name = name;
        this.IsMagic = true;
        this.DefenseLevel = 0;
        this.HealthLevel = 30;
        this.AttackLevel = 0;
    }
}