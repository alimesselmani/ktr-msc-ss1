using System;

namespace epitech.exceptions
{
    public class Warrior : Character
    {
        public Warrior(string name,
            string rpgClass = nameof(Warrior),
            int life = 100,
            int agility = 8,
            int strength = 10,
            int wit = 3) : base(name,
            rpgClass,
            life,
            agility,
            strength,
            wit)
        {
            Console.WriteLine($"{name}: My name will go down in history!");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrWhiteSpace(weapon))
                throw new WeaponException($"{Name}: I refuse to fight with my bare hands.");

            if (string.Equals(weapon, "hammer", StringComparison.InvariantCultureIgnoreCase) ||
                string.Equals(weapon, "sword", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"{Name}: Rrrrrrrrr...."); 
                Console.WriteLine($"{Name}: I'll crush you with my {weapon}!"); 
            }
            else
            {
                throw new WeaponException($"{Name}: A {weapon}?? What should I do with this ?!");
            }
        }

        public override void MoveRight()
        {
            Console.WriteLine($"{Name}: moves right like a bad boy .");
        }

        public override void MoveLeft()
        {
            Console.WriteLine($"{Name}: moves left like a bad boy .");
        }

        public override void MoveBack()
        {
            Console.WriteLine($"{Name}: moves back like a bad boy .");
        }

        public override void MoveForward()
        {
            Console.WriteLine($"{Name}: moves forward like a bad boy .");
        }
    }
}