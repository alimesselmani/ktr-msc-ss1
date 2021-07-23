using System;

namespace Epitech.exceptions
{
    public abstract class Character : IMovable
    {
        protected string Name { get; set; }
        protected int Life { get; set; }
        protected int Agility { get; set; }
        protected int Strength { get; set; }
        protected int Wit { get; set; }
        protected string RpgClass { get; }

        protected Character(
            string name,
            string rpgClass = nameof(Character),
            int life = 50, 
            int agility = 2, 
            int strength = 2, 
            int wit = 2)
        {
            Name = name;
            Life = life;
            Agility = agility;
            Strength = strength;
            Wit = wit;
            RpgClass = rpgClass;
        }

        public virtual void Attack(string weapon)
        {
            Console.WriteLine($"{Name}: Rrrrrrrrr....");
        }

        public void TryToAttack(string weapon)
        {
            try
            {
                Attack(weapon);
            }
            catch (WeaponException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string GetName() => Name;
        public int GetLife() => Life;
        public int GetWit() => Wit;
        public int GetAgility() => Agility;
        public int GetStrength() => Strength;
        public string GetRpgClass() => RpgClass;

        public virtual void MoveRight()
        {
            Console.WriteLine($"{Name}: moves right");
        }

        public virtual void MoveLeft()
        {
            Console.WriteLine($"{Name}: moves left");
        }

        public virtual void MoveBack()
        {
            Console.WriteLine($"{Name}: moves back");
        }

        public virtual void MoveForward()
        {
            Console.WriteLine($"{Name}: moves forward");
        }

        public void Unsheathe()
        {
            Console.WriteLine($"{Name}: unsheathes his weapon.");
        }
    }
}
