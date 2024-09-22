using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;


public interface ICharacter
{
    public string name { get; set; }
    public int HealthLevel { get; set; }
    public int AttackLevel { get; set; }
    public int DefenseLevel { get; set; }
    public bool IsAlive { get; set; }
    public List<IItem> Inventory { get; set; }

    public void AddItem(IItem item);
    public void RemoveItem(IItem item);
    public void Attack(IItem item, ICharacter defender);
    public void Defense(IItem item);
    public void Heal(IItem item);
    public void PrintStatus();
}