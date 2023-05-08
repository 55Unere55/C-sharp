using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Call_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've encountered Gozhi the Briggard and he launches a surprise Attack.");
            Console.WriteLine("Input your Defense stat:");
            int defense = Convert.ToInt32(Console.ReadLine());
            int enemy_damage = MathMethods_1.Defense(defense);
            Console.WriteLine("You have taken" + enemy_damage + "HP of damage.");
            Console.WriteLine("You're Healer, Sierra is near by. She heals you with her staff.");
            Console.WriteLine("input your Healers stat:");
            int magic = Convert.ToInt32(Console.ReadLine());
            int hitpoints = MathMethods_1.Heal(magic);
            Console.WriteLine("You have been healed for " + hitpoints + "HP.");
            Console.WriteLine("Mow it's your turn to attack.");
            Console.WriteLine("Give in you're sterength stat:");
            int strength = Convert.ToInt32(Console.ReadLine());
            int damage = MathMethods_1.attack(strength);
            Console.WriteLine("You have landed acritical Attack and dealt " + damage + "HP worth of damage.");
            Console.ReadLine();
        }
    }
}


        

    