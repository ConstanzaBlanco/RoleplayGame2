using Ucu.Poo.RoleplayGame;

namespace RoleplayGame2;

public class Knight : ICharacter
{
    private string Name { get; }

    private int HealthLevel { get; set; }

    private int AttackLevel { get; }

    private int DefenseLevel { get; set; }

    private bool IsAlive { get; set; }

    private List<IItem> Inventory { get; }

    public string GetName()
    {
        return this.Name;
    }

    public int GetHealth()
    {
        return this.HealthLevel;
    }

    public void SetHealth(int value)
    {
        this.HealthLevel = value;
    }

    public int GetAttack()
    {
        return this.AttackLevel;
    }

    public int GetDefense()
    {
        return this.DefenseLevel;
    }
    public void SetDefense(int value)
    {
        this.DefenseLevel = value;
    }

    public bool GetIsAlive()
    {
        return this.IsAlive;
    }
    public void SetIsAlive(bool value)
    {
        this.IsAlive = value;
    }

    public List<IItem> GetInventory()
    {
        return this.Inventory;
    }

    public Knight(string name)
    {
        this.Name = name;
        this.HealthLevel = 90;
        this.DefenseLevel = 5;
        this.AttackLevel = 15;
        this.IsAlive = true;
        this.Inventory = new List<IItem>();
    }

    public void AddItem(IItem item)
    {
        if (!item.GetIsMagic())
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
        int ActualAttack = item.GetAttack();
        if (ActualAttack == 0)
        {
            ActualAttack = AttackLevel;
        }

        if (this == defender)
        {
            Console.WriteLine($"No es posible que {Name} se ataque a si mismo");
        }
        else
        {
            if (Inventory.Contains(item))
            {
                if (defender.GetDefense() + defender.GetHealth() <= ActualAttack)
                {
                    defender.SetDefense(0);
                    defender.SetHealth(0);
                    defender.SetIsAlive(false);
                    Console.WriteLine(
                        $"{defender.GetName} ha sido atacado por {Name} con su {item.GetName()}"); // aca falta sacar el nombre
                    Console.WriteLine($"{defender.GetName} ha muerto por {Name}");
                }
                else if (defender.GetDefense() <= ActualAttack)
                {
                    int health = defender.GetHealth() - (ActualAttack - defender.GetDefense());
                    defender.SetHealth(health);
                    defender.SetDefense(0);
                    Console.WriteLine(
                        $"{defender.GetName} ha sido atacado por {Name} con su {item.GetName()}, perdiendo totalmente su defensa");
                }
                else if (defender.GetDefense() > ActualAttack)
                {
                    int defense = defender.GetDefense() - AttackLevel;
                    defender.SetDefense(defense);
                    Console.WriteLine($"{defender.GetName} ha sido atacado por {Name} con su {item.GetName()},pero su defensa no se ha roto");
                }
            }
            else
            {
                Console.WriteLine($"{Name} no tiene el item {item.GetName()}, pero golpea con su punio");
            }
        }
    }

    public void Defense(IItem item)
    {
        if (Inventory.Contains(item))
        {
            int ActualDefense = 0;
            ActualDefense += item.GetDefense();
            DefenseLevel = ActualDefense;
            Console.WriteLine($"{Name} ha activado su defensa");
        }
        else
        {
            Console.WriteLine($"{Name} no tiene este item");
        }
    }


    public void PrintStatus()
    {
        Console.WriteLine($"El personaje {Name} tiene las siguientes caracteristicas:");
        Console.WriteLine($"Es de tipo: {this.GetType().Name}");
        Console.WriteLine($"Tiene actualmente {HealthLevel} de vida");
        Console.WriteLine($"Tiene actualmente {AttackLevel} de daño físico base");
        Console.WriteLine($"Tiene actualmente {DefenseLevel} de defensa");
        foreach (IItem item in Inventory)
        {
            Console.WriteLine($"Tiene a su disposición el item: {item.GetName()}");
        }

        Console.WriteLine("");
    }
}