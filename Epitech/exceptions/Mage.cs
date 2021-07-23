using System;

namespace Epitech.exceptions
{
    public class Mage : Character
    {
        public Mage(string name,
            string rpgClass = nameof(Mage),
            int life = 70,
            int agility = 10,
            int strength = 3,
            int wit = 10) : base(name,
            rpgClass,
            life,
            agility,
            strength,
            wit)
        {
            Console.WriteLine($"{name}: May the gods be with me!");
        }

        public override void Attack(string weapon)
        {
            if (string.IsNullOrWhiteSpace(weapon))
                throw new WeaponException($"{Name}: I refuse to fight with my bare hands.");

            if (string.Equals(weapon, "magic", StringComparison.InvariantCultureIgnoreCase) ||
                string.Equals(weapon, "wand", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"{Name}: Rrrrrrrrr....");
                Console.WriteLine($"{Name}: Feel the power of my {weapon}!");
            }
            else
            {
                throw new WeaponException($"{Name}: I don't need this stupid {weapon}! Don't misjudge my powers!");
            }
        }

        public override void MoveRight()
        {
            Console.WriteLine($"{Name}: moves right furtively .");
        }

        public override void MoveLeft()
        {
            Console.WriteLine($"{Name}: moves left furtively .");
        }

        public override void MoveBack()
        {
            Console.WriteLine($"{Name}: moves back furtively .");
        }

        public override void MoveForward()
        {
            Console.WriteLine($"{Name}: moves forward furtively .");
        }
    }
}