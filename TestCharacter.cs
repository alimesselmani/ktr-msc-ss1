namespace epitech.exceptions
{
    public class TestCharacter : Character
    {
        public TestCharacter(string name,
            string rpgClass = nameof(Character),
            int life = 50,
            int agility = 2,
            int strength = 2,
            int wit = 2) : base(name,
            rpgClass,
            life,
            agility,
            strength,
            wit)
        {
        }
    }
}
