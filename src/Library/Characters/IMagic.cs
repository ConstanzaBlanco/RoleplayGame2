using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;

public interface IMagic
{
    void Heal(IItem item);
    void Attack(IBook item, ICharacter defender);
    void Defense(IBook item);
    void Heal(IBook item);
}