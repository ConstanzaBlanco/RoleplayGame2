namespace Ucu.Poo.RoleplayGame;
//Establece que comportamiento debe tener cada item
public interface IItem
{
    int GetAttack();
    int GetDefense();
    int GetHealth();
    string GetName();
    bool GetIsMagic();
}