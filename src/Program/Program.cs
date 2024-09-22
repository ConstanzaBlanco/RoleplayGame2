using RoleplayGame2;
using Ucu.Poo.RoleplayGame;

Book LibritoDeSabiduria = new Book("Todo lo sabe");
LibritoDeSabiduria.AddSpell("Adaba cadabra");

Wizard gandalf = new Wizard("Gandalf");
//gandalf.Staff = new Staff();
gandalf.AddItem(LibritoDeSabiduria);

Dwarf gimli = new Dwarf("Gimli");
gimli.Axe = new Axe();
gimli.Helmet = new Helmet();

gimli.Shield = new Shield("escudo");

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

