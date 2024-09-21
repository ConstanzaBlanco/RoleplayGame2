namespace Ucu.Poo.RoleplayGame;

public interface Items
{
    string Name { get; }
    int Defenselevel { get; }
    int AttackLevel { get; }
    int HealthLevel { get; }
    bool IsMagic { get; }

}