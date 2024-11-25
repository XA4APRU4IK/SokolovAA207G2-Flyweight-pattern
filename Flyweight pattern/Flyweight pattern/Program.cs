using System;
using System.Collections.Generic;
using Flyweight_pattern;

public class Program
{
    public static void Main(string[] args)
    {
        Character hero1 = CharacterFactory.GetCharacter("Hero", "Warrior", "warrior.png");
        Character hero2 = CharacterFactory.GetCharacter("Hero", "Warrior", "warrior.png");

        Console.WriteLine(hero1 == hero2);//true т.к. оба ссылаются на один объект

        hero1.GainExperience(100);
        hero1.LevelUp();

        Console.WriteLine(hero1.Level); // 2
        Console.WriteLine(hero1.Experience); // 100
        Console.WriteLine(hero2.Level); // 2, так как это тот же объект
    }
}
