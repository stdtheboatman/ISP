using Microsoft.CSharp.RuntimeBinder;

namespace Fifth
{
    public class Potion : Item
    {
        public Potion(string name, string description,  int weight, string type) : base(name, description, weight)
        {
            this.type = type; 
        }
        
        public string type { get; }

        public override string ToString()
        {
            return $"----Potion----\n" +
                   CommonInfoToString() +
                   $"Type: {type}\n" +
                   "---------------\n";
        }
    }
}