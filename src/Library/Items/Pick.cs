namespace Ucu.Poo.RoleplayGame;

public class Pick:Items
{
    public string Name { get; }
    public int Defenselevel { get; }
    public int AttackLevel { get; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    public Pick(string name)
    {
        this.Name = name;
        this.IsMagic = false;
        this.Defenselevel = 0;
        this.HealthLevel = 0;
        this.AttackLevel = 40;
    }
}