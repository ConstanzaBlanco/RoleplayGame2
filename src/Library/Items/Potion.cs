namespace Ucu.Poo.RoleplayGame;

public class Potion
{
    public string Name { get; }
    public int Defenselevel { get; }
    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    public Potion(string name)
    {
        this.Name = name;
        this.IsMagic = true;
        this.Defenselevel = 0;
        this.HealthLevel = 30;
        this.AttackLevel = 0;
    }
}