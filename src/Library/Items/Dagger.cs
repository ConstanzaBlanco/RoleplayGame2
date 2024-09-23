
namespace Ucu.Poo.RoleplayGame;

public class Dagger :IItem
{
    private string name { get; }
    private int DefenseLevel { get; set; }

    private int AttackLevel;
    public int HealthLevel { get; }
    private bool IsMagic { get; }

    public Dagger(string name)
    {
        this.name = name;
        this.DefenseLevel = 0;
        this.HealthLevel = 0;
        this.AttackLevel = 20;
        this.IsMagic = false;
    }
    public int GetAttack()
    {
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
        return this.name;
    }
}