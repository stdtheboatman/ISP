using System;

namespace Sixth
{
    public interface IBackpackItem : IComparable
    {
        public int Weight();

        public string Name();
        public string ToString();
    }
}