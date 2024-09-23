using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;

public class Dwarf : ICharacter
{
    public string name { get; set; }
    
    public int healthLevel { get; set; }
    
    public int attackLevel { get; set; }
    
    public int defenseLevel { get; set; }
    
    public bool isAlive { get; set; }
    
    public List<IItem> inventory { get; set; }

    public Dwarf(string name)
    {
        this.name = name;
        this.healthLevel = 120;
        this.defenseLevel = 10;
        this.attackLevel = 15;
        this.isAlive = true;
        this.inventory = new List<IItem>();
    }
    

    public void AddItem(IItem item)
    {
        if (!item.isMagic)
        {
            inventory.Add(item);
        }
    }
    
    public void RemoveItem(IItem item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
        }
    }

    public void Attack(IItem item, ICharacter defender)
    {
        int ActualAttack = item.attackLevel;
        if (ActualAttack == 0)
        {
            ActualAttack = attackLevel;
        }
        if (this == defender)
        {
            Console.WriteLine($"No es posible que {name} se ataque a si mismo");
        }
        else
        {
            if (inventory.Contains(item))
            {
                if (defender.defenseLevel + defender.healthLevel <= ActualAttack)
                {
                    defender.defenseLevel = 0;
                    defender.healthLevel = 0;
                    defender.isAlive = false;
                    Console.WriteLine($"{defender.name} ha sido atacado por {name} con su {item.name}"); // aca falta sacar el nombre
                    Console.WriteLine($"{defender.name} ha muerto por {name}");
                }
                else if (defender.defenseLevel <= ActualAttack)
                {
                    defender.healthLevel -= ActualAttack - defender.defenseLevel;
                    defender.defenseLevel = 0;
                    Console.WriteLine($"{defender.name} ha sido atacado por {name} con su {item.name}, perdiendo totalmente su defensa"); 
                }
                else if (defender.defenseLevel > ActualAttack)
                {
                    defender.defenseLevel -= attackLevel;
                    Console.WriteLine($"{defender.name} ha sido atacado por {name} con su {item.name},pero su defensa no se ha roto");
                }
            }
            else
            {
                Console.WriteLine($"{name} no tiene el item {item.name}, pero golpea con su punio");
            }
        }
    }

    public void Defense(IItem item)
    {
        if (inventory.Contains(item))
        {
            int ActualDefense = 0;
            ActualDefense += item.defenseLevel;
            defenseLevel = ActualDefense;
            Console.WriteLine($"{name} ha activado su defensa");
        }
        else
        {
            Console.WriteLine($"{name} no tiene este item");
        }
    }
    

    public void PrintStatus()
    {
        Console.WriteLine($"El personaje {name} tiene las siguientes caracteristicas:");
        Console.WriteLine($"Es de tipo: {this.GetType().Name}");
        Console.WriteLine($"Tiene actualmente {healthLevel} de vida");
        Console.WriteLine($"Tiene actualmente {attackLevel} de daño físico base");
        Console.WriteLine($"Tiene actualmente {defenseLevel} de defensa");
        foreach (IItem item in inventory)
        {
            Console.WriteLine($"Tiene a su disposición el item: {item.name}");
        }
        Console.WriteLine("");
    }
}