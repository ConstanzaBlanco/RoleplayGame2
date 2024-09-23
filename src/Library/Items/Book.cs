namespace Ucu.Poo.RoleplayGame;
//El libro implementa ambas interfeces para poder tener las caracteristicas de un libro y de un item
public class Book : IItem, IBook
{
    private string name;
    private int DefenseLevel { get; set; }
    public int AttackLevel { get; set; }
    public int HealthLevel { get; set; }
    public bool IsMagic { get; }
    
    public List<String> Spells { get; }
    
    public Book(string name)
    {
        this.name = name;
        this.IsMagic = true;
        this.DefenseLevel = 5;
        this.HealthLevel = 5;
        this.AttackLevel = 15;
        this.Spells = new List<string>();

    }

    public int GetAttack()
    {
        int cant_spells = Spells.Count;
        this.AttackLevel += cant_spells;
        return this.AttackLevel;
    }
    public int GetDefense()
    {
        int cant_spells = Spells.Count;
        this.DefenseLevel += cant_spells;
        return this.DefenseLevel;
    }

    public void AddSpell(string hechizo)
    {
        Spells.Add(hechizo);
    }
    public string GetName()
    {
        return this.name;
    }

    public int GetHealth()
    {
        int cant_spells = Spells.Count;
        this.HealthLevel += cant_spells;
        return this.HealthLevel;
    }
    
    public bool GetIsMagic()
    {
        
        return this.IsMagic;
    }
}