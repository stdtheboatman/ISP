using System;

namespace Fifth
{
    public class OtherItem : Item
    {
        public OtherItem(string name, string description, int weight) : base(name, description, weight)
        {
            //^_^
        }

        public override string ToString()
        {
            return "----Other item----\n" +
                   base.CommonInfoToString() +
                   "------------------";
        }
    }
}