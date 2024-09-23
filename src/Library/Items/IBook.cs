namespace Ucu.Poo.RoleplayGame;

public interface IBook
{
    string Name { get; }
    int DefenseLevel { get; set; }
    int AttackLevel { get; set; }
    int HealthLevel { get; }
    bool IsMagic { get; }
    
    List<String> Spells { get; }
    void AddSpell(String name);
}