using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;


public interface ICharacter
{
    string name { get; set; }
    int HealthLevel { get; set; }
    int AttackLevel { get; set; }
    int DefenseLevel { get; set; }
    bool IsAlive { get; set; }
    List<IItem> Inventory { get; set; }
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    void Attack(IItem item, ICharacter defender);
    void Defense(IItem item);
    void PrintStatus();
}