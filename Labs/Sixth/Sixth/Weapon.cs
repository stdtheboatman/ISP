using System;
using System.Runtime.Remoting;

namespace Sixth
{
    internal enum BlacksmithLevel
    {
        Beginner = 25,
        Adept = 50,
        Expert = 75,
        Master = 100
    }

    public class Weapon : Item, IBackpackItem
    {
        public Weapon(string name, string description, int weight, int damage, string type) : base(name,
            description, weight)
        {
            this.Damage = damage;
            this.Type = type;
            this._damageBySharp = 0;
        }

        private readonly int _damage;

        private int Damage
        {
            get => _damage + _damageBySharp;
            init => _damage = value;
        }

        private int _damageBySharp;
        private string Type { get; }


        public void Sharpen(int skillLevel)
        {
            _damageBySharp = _damage * skillLevel / 100;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is IBackpackItem == false)
            {
                throw new Exception("Object is not IBackpackItem");
            }

            var other = (IBackpackItem) obj;

            return String.CompareOrdinal(this.Name(), other.Name());
        }

        public new int Weight()
        {
            return base.Weight;
        }

        public new string Name()
        {
            return base.Name;
        }

        public override string ToString()
        {
            return $"----Weapon----\n" +
                   base.ToString() +
                   $"Damage: {Damage}\n" +
                   $"Type: {Type}\n" +
                   "---------------\n";
        }
    }
}