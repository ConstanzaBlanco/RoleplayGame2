using RoleplayGame2;
using Ucu.Poo.RoleplayGame;

IItem LibritoDeSabiduria = new Book("Todo lo sabe");
LibritoDeSabiduria.AddSpell("Adaba cadabra");

Wizard gandalf = new Wizard("Gandalf");
//gandalf.Staff = new Staff();
gandalf.AddItem(LibritoDeSabiduria);
gandalf.PrintStatus();

Dwarf gimli = new Dwarf("Gimli");
gimli.AddItem(LibritoDeSabiduria);
IItem EscudoDeHierro = new Shield("Hierro");
gimli.AddItem(EscudoDeHierro);
gimli.PrintStatus();

Console.WriteLine("-----------------------------");

gandalf.Attack(LibritoDeSabiduria, gimli);
gimli.PrintStatus();


