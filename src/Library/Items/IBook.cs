namespace Ucu.Poo.RoleplayGame;
//Establece las firmas que necesita cumplir cada libro para funcionar correctamente
public interface IBook
{
    List<String> Spells { get; }
    void AddSpell(String name);
    
    int GetAttack();
    int GetDefense();
    int GetHealth();
    string GetName();
}