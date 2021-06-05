using System;

namespace Eighth
{
    public interface IBackpackItem : IComparable
    {
        public int Weight();

        public string Name();
        public string ToString();
    }
}