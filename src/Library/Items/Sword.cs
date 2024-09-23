namespace Ucu.Poo.RoleplayGame;

public class Sword : IItem
{
    private string Name;
    private int DefenseLevel { get; set; }
    private int AttackLevel { get; set; }
    private int HealthLevel { get; set; }
    private bool IsMagic { get; }

    public Sword(string name)
    {
        this.Name = name;
        this.IsMagic = false;
        this.DefenseLevel = 15;
        this.HealthLevel = 0;
        this.AttackLevel = 25;
    }

    public int GetAttack()
    {
        return this.AttackLevel;
    }

    public int GetDefense()
    {
        return this.DefenseLevel;
    }

    public string GetName()
    {
        return this.Name;
    }

    public int GetHealth()
    {
        return this.HealthLevel;
    }
    
    public bool GetIsMagic()
    {
        return this.IsMagic;
    }
}