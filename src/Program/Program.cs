using RoleplayGame2;
using Ucu.Poo.RoleplayGame;

IBook LibritoDeSabiduria = new Book("Todo lo sabe");
LibritoDeSabiduria.AddSpell("Adaba cadabra");

Wizard gandalf = new Wizard("Gandalf");
IItem baston = new Staff("Bastón de chocolate");
gandalf.AddBook(LibritoDeSabiduria);
gandalf.AddItem(baston);
gandalf.PrintStatus();

Dwarf gimli = new Dwarf("Gimli");
IItem EscudoDeHierro = new Shield("Hierro");
gimli.AddItem(EscudoDeHierro);
gimli.PrintStatus();

Console.WriteLine("-----------------------------");

gandalf.Attack(LibritoDeSabiduria, gimli);
gimli.PrintStatus();


