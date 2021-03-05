using System;

namespace backpack
{
    class Pizza : IBackpackItem
    {
        public int Cost { get; }
        public int Weight { get; }
        public string Name { get; }
        public string MainComponent { get; }

        public override string ToString()
        {
            return "Name: " + Name + " Cost: " + Cost + " Weight: " + Weight;
        }

        public Pizza()
        {
        }

        public Pizza(int Cost, int Weight, string Name, string MainComponent = "ZXC")
        {
            this.Cost = Cost;
            this.Weight = Weight;
            this.Name = Name;
            this.MainComponent = MainComponent;
        }

        public int ItemEfficiency
        {
            get
            {
                return Weight;
            }
        }

        public int ItemWeight
        {
            get
            {
                return Cost;
            }
        }

        public string ItemName
        {
            get
            {
                return Name;
            }
        }

    }
}
