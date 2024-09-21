namespace Ucu.Poo.RoleplayGame;

public class Book
{
    public string Name { get; }
    public int Defenselevel { get; set; }
    public int AttackLevel { get; set; }
    public int HealthLevel { get; }
    public bool IsMagic { get; }
    
    private List<string> Spells = new List<string>();
    
    public Book(string name)
    {
        this.Name = name;
        this.IsMagic = true;
        this.Defenselevel = 5;
        this.HealthLevel = 0;
        this.AttackLevel = 15;
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
        this.Defenselevel += cant_spells;
        return this.Defenselevel;
    }

    public void AgregarHechizos(string hechizo)
    {
        Spells.Add(hechizo);
    }
}