using System;
using System.Collections.Generic;
using System.Text;

namespace backpack
{
    class BackpackLogic
    {
        private Backpack backpack;
        string path;

        public BackpackLogic()
        {

        }

        public BackpackLogic(Backpack backpack)
        {
            this.backpack = backpack;
        }

        public override string ToString()
        {
            return path;
        }

        private void ReduceDp(int itemsCount, int volume, int[,] dp, int[,] from)
        {
            for(int i = 0; i < itemsCount; i++)
            {
                for(int j = 0; j <= volume; j++)
                {
                    dp[i, j] = 0;
                    from[i, j] = -1;
                }
            }

            for (int index = 0; index < itemsCount; index++)
            {
                IBackpackItem item = backpack.GetItem(index);

                int efficiency = item.ItemEfficiency;
                int weight = item.ItemWeight;

               
                for (int curWeight = volume - weight; curWeight > -1; curWeight--)
                {
                    if (dp[index + 1, curWeight] + efficiency > dp[index, curWeight + weight])
                    {
                        dp[index + 1, curWeight + weight] = dp[index, curWeight] + efficiency;
                        from[index + 1, curWeight + weight] = index;
                    }
                }

   
                
                for(int curWeight = 0; curWeight <= volume; curWeight++)
                {
                    if (dp[index, curWeight] >= dp[index + 1, curWeight])
                    {
                        dp[index + 1, curWeight] = dp[index, curWeight];
                        from[index + 1, curWeight] = -1;
                    }
                }
                
            }
        }

        private void ReducePath(int itemsCount, int volume, int[,] dp, int[,] from, List<int> path)
        {
            int index = itemsCount;
            int curWeight = 0;
            for (int i = 1; i <= volume; i++)
            {
                if (dp[index, i] > dp[index, curWeight])
                {
                    curWeight = i;
                }
            }

            while (curWeight != 0)
            {
                int ind = from[index, curWeight];

                if (ind != -1)
                {
                    path.Add(ind);
                    curWeight -= backpack.GetItem(ind).ItemWeight;
                }
                
                index--;
            }
        }

        private string PathToString(List<int> path)
        {
            int sumEfficiency = 0;
            foreach (int index in path)
            {
                sumEfficiency += backpack.GetItem(index).ItemEfficiency;
            }

            string result = "Total efficiency: " + sumEfficiency + "\n" + "Optimal path is: \n";
            foreach (int index in path)
            {
                result += backpack.GetItem(index) + "\n";
            }

            return result;
        }

        public void SolveBackpack(int volume)
        {
            int itemsCount = backpack.GetSize();
            int[,] dp = new int[itemsCount + 1, volume + 1];
            int[,] from = new int[itemsCount + 1, volume + 1];

            List<int> path = new List<int>();

            ReduceDp(itemsCount, volume, dp, from);
            ReducePath(itemsCount, volume, dp, from, path);

            this.path = PathToString(path);
        }
    }
}
