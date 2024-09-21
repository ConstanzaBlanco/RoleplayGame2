namespace Ucu.Poo.RoleplayGame;

public class Staff
{
    public string Name { get; }
    public int Defenselevel { get; }
    public int AttackLevel { get; set; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    public Staff(string name)
    {
        this.Name = name;
        this.IsMagic = true;
        this.Defenselevel = 0;
        this.HealthLevel = 0;
        this.AttackLevel = 15;
    }
    public int Danio
    {
        get {return this.AttackLevel; }
    }    
    public int GetAtaque()
    {
        if (this.AttackLevel<30)
        {
            this.AttackLevel += 5;
        }

        return this.AttackLevel;
    }
}