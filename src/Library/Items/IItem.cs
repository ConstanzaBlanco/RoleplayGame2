namespace Ucu.Poo.RoleplayGame;

public interface IItem
{
    string Name { get; }
    int DefenseLevel { get; }
    int AttackLevel { get; }
    int HealthLevel { get; }
    bool IsMagic { get; }

    void AddSpell(string name);
}