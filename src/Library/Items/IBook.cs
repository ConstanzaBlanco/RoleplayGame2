namespace Ucu.Poo.RoleplayGame;

public interface IBook
{
    List<String> Spells { get; }
    void AddSpell(String name);
    
    int GetAttack();
    int GetDefense();
    int GetHealth();
    string GetName();
}