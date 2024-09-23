namespace Ucu.Poo.RoleplayGame;

public interface IItem
{
    string name { get; }
    int defenseLevel { get; }
    int attackLevel { get; }
    int healthLevel { get; }
    bool isMagic { get; }
}