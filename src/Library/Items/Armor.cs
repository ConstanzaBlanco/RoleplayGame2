namespace Ucu.Poo.RoleplayGame;

public class armor: IItem
{
    private string Name { get; }
    private int usos;
    private int DefenseLevel { get; set; }
    private int AttackLevel { get; set; }
    private int HealthLevel { get; set; }
    private bool IsMagic { get; }
    
    public int GetAttack()
    {
        return this.AttackLevel;
    }

    public int GetHealth()
    {
        return this.HealthLevel;
    }

    public string GetName()
    {
        return this.Name;
    }

    public int GetDefense()
    {
        if (this.usos <= 2)
        {
            this.DefenseLevel -= 20;
            this.usos += 1;
        }
        
        if (this.DefenseLevel <= 0)
        {
            Console.WriteLine($"Se le ha roto la Armadura");
            this.DefenseLevel = 0;
        }
        return this.DefenseLevel;
        
    }

    public bool GetIsMagic()
    {
        return this.IsMagic;
    }
    
    public armor(string name)
    {
        this.Name = name;
        this.AttackLevel = 0;
        this.HealthLevel = 0;
        this.DefenseLevel = 60;
        this.usos = 0;
        this.IsMagic =false;
    }
}