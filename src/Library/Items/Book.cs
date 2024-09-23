namespace Ucu.Poo.RoleplayGame;

public class Book : IItem, IBook
{
    public string Name { get; }
    public int DefenseLevel 
    { get; set; }
    public int AttackLevel { get; set; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    public List<String> Spells { get; }
    
    public Book(string name)
    {
        this.Name = name;
        this.IsMagic = true;
        this.DefenseLevel = 5;
        this.HealthLevel = 0;
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
}