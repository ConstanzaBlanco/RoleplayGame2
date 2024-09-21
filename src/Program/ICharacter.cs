namespace RoleplayGame2;

public interface ICharacter
{
    public string name { get; set; }
    public int HealthLevel { get; set; }
    public int AttackLevel { get; set; }
    public int DefenseLevel { get; set; }
    public bool IsAlive { get; set; }
    public List<IItems> Inventory { get; set; }

    public void AddItem(IItem item);
    public void RemoveItem(IItem item);
    public void Attack(IItem item, ICharacter personaje1);
    public void Defense(IItem item);
    public void PrintStatus();
}