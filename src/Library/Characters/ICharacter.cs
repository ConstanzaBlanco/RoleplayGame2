using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;


public interface ICharacter
{
    string name { get; set; }
    int healthLevel { get; set; }
    int attackLevel { get; set; }
    int defenseLevel { get; set; }
    bool isAlive { get; set; }
    List<IItem> inventory { get; set; }
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    void Attack(IItem item, ICharacter defender);
    void Defense(IItem item);
    void PrintStatus();
}