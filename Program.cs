using System;

namespace epitech.exceptions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example 1:");

            Example1();

            Console.WriteLine("\nExample 2:");
            
            Example2();

            Console.WriteLine("\nExample 3:");

            Example3();
            
            Console.WriteLine("\nExample 4:");

            Example4();

            Console.WriteLine("\nExample 5:");

            Example5();
        }

        public static void Example1()
        {
            var perso = new TestCharacter("Jean-Luc");

            Console.WriteLine(perso.GetName());
            Console.WriteLine(perso.GetLife());
            Console.WriteLine(perso.GetAgility());
            Console.WriteLine(perso.GetStrength());
            Console.WriteLine(perso.GetWit());
            Console.WriteLine(perso.GetRpgClass());
            perso.Attack("my weapon");
        }

        public static void Example2()
        {
            var warrior = new Warrior("Jean-Luc");
            var mage = new Mage("Robert");

            warrior.Attack("Hammer");
            mage.Attack("MAGIC");
        }

        public static void Example3()
        {
            var warrior = new Warrior("Jean-Luc");
            var mage = new Mage("Robert");

            warrior.MoveRight();
            warrior.MoveLeft();
            warrior.MoveBack();
            warrior.MoveForward();

            mage.MoveRight();
            mage.MoveLeft();
            mage.MoveBack();
            mage.MoveForward();
        }

        public static void Example4()
        {
            var warrior = new Warrior("Jean-Luc");
            var mage = new Mage("Robert");

            warrior.Unsheathe();
            mage.Unsheathe();
        }

        public static void Example5()
        {
            var warrior = new Warrior("Jean-Luc");
            var mage = new Mage("Robert");

            warrior.TryToAttack("screwdriver");
            mage.TryToAttack("hammer");
            warrior.TryToAttack("hammer");

            try
            {
                mage.Attack(string.Empty);
            }
            catch (WeaponException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}