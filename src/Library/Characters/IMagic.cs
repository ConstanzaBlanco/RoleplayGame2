using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;
//Interface destinada tener las firmas neceserias que tiene que cumplir cada personaje mágico
//Este tipo de personajes puede curarse con un items 
//Además pueden usar un libro mágico tanto para atacar, defender como curarse
public interface IMagic
{
    void Heal(IItem item);
    void Attack(IBook item, ICharacter defender);
    void Defense(IBook item);
    void Heal(IBook item);
}