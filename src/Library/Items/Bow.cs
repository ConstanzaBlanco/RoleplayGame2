namespace Ucu.Poo.RoleplayGame;

public class Bow:IItem
{
    private string Name { get; }
    public int DefenseLevel { get; set; }
    private int Arrows;
    private int AttackLevelWithArrow;
    private int AttackLevel { get; set; }
    private int HealthLevel { get; set; }
    private bool IsMagic { get; }
    public int GetAttack()
    {
        if (this.Arrows>0)
        {
            this.Arrows -= 1;
            Console.WriteLine($"Le quedan {this.Arrows} flechas");
            return this.AttackLevelWithArrow;
        }
        Console.WriteLine($"Ya no le quedan flechas, utiliza unicamente su Arco");
        return this.AttackLevel;
    }
    public int GetDefense()
    {
        return this.DefenseLevel;
    }

    public int GetHealth()
    {
        return this.HealthLevel;
    }

    public string GetName()
    {
        return this.Name;
    }
    
    public bool GetIsMagic()
    {
        return this.IsMagic;
    }

    public Bow(string name)
    {
        this.Name = name;
        this.DefenseLevel = 0;
        this.HealthLevel = 0;
        this.AttackLevel = 20;
        this.AttackLevelWithArrow = 30;
        this.Arrows = 3;
        this.IsMagic = false;
    }

}