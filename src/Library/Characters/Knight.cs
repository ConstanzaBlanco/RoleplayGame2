using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;

public class Knight : ICharacter
{
    public string name { get; set; }

    public int HealthLevel { get; set; }

    public int AttackLevel { get; set; }

    public int DefenseLevel { get; set; }

    public bool IsAlive { get; set; }

    public List<IItem> Inventory { get; set; }

    public Knight(string name)
    {
        this.name = name;
        this.HealthLevel = 90;
        this.DefenseLevel = 5;
        this.AttackLevel = 15;
        this.IsAlive = true;
        this.Inventory = new List<IItem>();
    }

    public void AddItem(IItem item)
    {
        if (!item.IsMagic)
        {
            Inventory.Add(item);
        }
    }

    public void RemoveItem(IItem item)
    {
        if (Inventory.Contains(item))
        {
            Inventory.Remove(item);
        }
    }

    public void Attack(IItem item, ICharacter defender)
    {
        int ActualAttack = item.AttackLevel;
        if (ActualAttack == 0)
        {
            ActualAttack = AttackLevel;
        }

        if (this == defender)
        {
            Console.WriteLine($"No es posible que {name} se ataque a si mismo");
        }
        else
        {
            if (Inventory.Contains(item))
            {
                if (defender.DefenseLevel + defender.HealthLevel <= ActualAttack)
                {
                    defender.DefenseLevel = 0;
                    defender.HealthLevel = 0;
                    defender.IsAlive = false;
                    Console.WriteLine(
                        $"{defender.name} ha sido atacado por {name} con su {item.Name}"); // aca falta sacar el nombre
                    Console.WriteLine($"{defender.name} ha muerto por {name}");
                }
                else if (defender.DefenseLevel <= ActualAttack)
                {
                    defender.HealthLevel -= ActualAttack - defender.DefenseLevel;
                    defender.DefenseLevel = 0;
                    Console.WriteLine(
                        $"{defender.name} ha sido atacado por {name} con su {item.Name}, perdiendo totalmente su defensa");
                }
                else if (defender.DefenseLevel > ActualAttack)
                {
                    defender.DefenseLevel -= AttackLevel;
                    Console.WriteLine(
                        $"{defender.name} ha sido atacado por {name} con su {item.Name},pero su defensa no se ha roto");
                }
            }
            else
            {
                Console.WriteLine($"{name} no tiene el item {item.Name}, pero golpea con su punio");
            }
        }
    }

    public void Defense(IItem item)
    {
        if (Inventory.Contains(item))
        {
            int ActualDefense = 0;
            ActualDefense += item.DefenseLevel;
            DefenseLevel = ActualDefense;
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
        Console.WriteLine($"Tiene actualmente {HealthLevel} de vida");
        Console.WriteLine($"Tiene actualmente {AttackLevel} de daño físico base");
        Console.WriteLine($"Tiene actualmente {DefenseLevel} de defensa");
        foreach (IItem item in Inventory)
        {
            Console.WriteLine($"Tiene a su disposición el item: {item.Name}");
        }

        Console.WriteLine("");
    }
    public void Heal (IItem item)
    {
        throw new NotImplementedException();
    }
}