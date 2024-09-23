namespace Ucu.Poo.RoleplayGame;

public class Bow:IItem
{
    private string name { get; }
    public int DefenseLevel { get; set; }
    private int flechas;
    private int danio;
    private int AttackLevel { get; set; }
    private int HealthLevel { get; set; }
    private bool IsMagic { get; }
    public int GetAttack()
    {
        if (this.flechas>0)
        {
            this.flechas -= 1;
            Console.WriteLine($"Le quedan {this.flechas} flechas");
        }
        if(this.flechas<=0)
        {
            this.danio = 0;
            Console.WriteLine($"Ya no le quedan flechas, utiliza unicamente su Arco");
        }
        
        return this.danio;
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
        return this.name;
    }
    
    public bool GetIsMagic()
    {
        return this.IsMagic;
    }

    public Bow(string name)
    {
        this.name = name;
        this.DefenseLevel = 0;
        this.HealthLevel = 0;
        this.AttackLevel = 30;
        this.danio = 30;
        this.flechas = 3;
        this.IsMagic = false;
    }

}