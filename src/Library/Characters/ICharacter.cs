using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;
//Esta interfaz estable que comportamiento debe tener cada personaje creado

public interface ICharacter
{ 
    string GetName();
    int GetHealth();
    void SetHealth(int value);
    int GetAttack();
    int GetDefense();
    void SetDefense(int value);
    bool GetIsAlive();
    void SetIsAlive(bool value);
    List<IItem> GetInventory();
    
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    void Attack(IItem item, ICharacter defender);
    void Defense(IItem item);
    void PrintStatus();
}