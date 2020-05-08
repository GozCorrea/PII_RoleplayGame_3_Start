using System.Collections.Generic;
namespace RoleplayGame
{
    public class Hero : Character
    {
        public Hero(string name) : base(name)
        {
        }

        public override int AttackValue => base.AttackValue;

        public override int DefenseValue => base.DefenseValue;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
