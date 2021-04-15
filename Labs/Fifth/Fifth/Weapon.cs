using System;

namespace Fifth
{
    enum BlacksmithLevel
    {
        Beginner = 25,
        Adept = 50,
        Expert = 75,
        Master = 100
    }

    public class Weapon : Item
    {
        public Weapon(string name, string description, int weight, int damage, string type) : base(name,
            description, weight)
        {
            this.damage = damage;
            this.type = type;
            this.damageBySharp = 0;
        }

        private int _damage;
        public int damage
        {
            get
            {
                return _damage + damageBySharp;
            }
            set
            {
                _damage = value;
            }
        }

        public int damageBySharp { get; private set; }
        public string type { get; }


        public void Sharpen(int skillLevel)
        {
            damageBySharp = _damage * skillLevel / 100;
        }

        public override string ToString()
        {
            return $"----Weapon----\n" +
                   CommonInfoToString() +
                   $"Damage: {damage}\n" +
                   $"Type: {type}\n" +
                   "---------------\n";
        }
    }
}