using System.Linq;
using System;
using System.Linq.Expressions;

class Program
{

    static void Main()
    {
        Knight soulKnight = new Knight(100, 20, 20);
        Barbarian barbarian = new Barbarian(100, 10, 20, 2);

        soulKnight.TakeDamage(150);
        barbarian.TakeDamage(160);

        Console.Write("Здоров'я лицаря: ");
        soulKnight.ShowHealthInfo();

        Console.Write("Здоров'я варвара: ");
        barbarian.ShowHealthInfo();
    }
}

class Warrior
{
    public int Health;
    public int Armor;
    public int Damage;

    public Warrior(int health, int armor, int damage)
    {
        Health = health;
        Armor = armor;
        Damage = damage;


    }
    public void TakeDamage(int damage)
    {
        Health -= damage - Armor;
    }
    public void ShowHealthInfo()
    {
        Console.WriteLine(Health);
    }
}
class Knight : Warrior
{
    public Knight(int health, int damage, int armor) : base(health, armor, damage) { }
    public void Pray()
    {
        Armor += 4;
        
    }

}
class Barbarian : Warrior
{
    public Barbarian(int health, int damage, int armor, int attackSpeed) : base(health, damage * attackSpeed, armor) { }
    public void Shout()
    {
        Armor -= 2;
        Health += 8;
            
    }
}





