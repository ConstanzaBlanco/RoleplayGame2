﻿namespace Ucu.Poo.RoleplayGame;

public class Potion : IItem
{
    private string name;
    private int DefenseLevel { get; set; }
    private int AttackLevel { get; set; }
    private int HealthLevel { get; set; }
    private bool IsMagic { get; }

    public Potion(string name)
    {
        this.name = name;
        this.IsMagic = true;
        this.DefenseLevel = 0;
        this.HealthLevel = 30;
        this.AttackLevel = 0;
    }

    public int GetAttack()
    {
        return this.AttackLevel;
    }

    public int GetDefense()
    {
        return this.DefenseLevel;
    }

    public string GetName()
    {
        return this.name;
    }

    public int GetHealth()
    {
        return this.HealthLevel;
    }
    
    public bool GetIsMagic()
    {
        return this.IsMagic;
    }
}