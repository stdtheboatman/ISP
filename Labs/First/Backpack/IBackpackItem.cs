namespace backpack
{
    interface IBackpackItem
    {
        int ItemEfficiency { get; }
        int ItemWeight { get; }

        string ItemName { get; }

        string ToString();
    }
}
