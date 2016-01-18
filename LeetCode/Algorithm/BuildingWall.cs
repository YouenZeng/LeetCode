using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Leets;

namespace LeetCode.Algorithm
{
    class BuildingWall : ISolution
    {
        public int Calc(int width, int height)
        {
            int[] blocks = { 2, 3 };

            int[] walls = new int[height];

            int solutionsCount = 0;

            while (true)
            {

                for (int i = 0; i < walls.Length - 1; i++)
                {
                    if ((walls[i] += blocks[0]) != walls[i - 1] && (walls[i] += blocks[0]) != walls[i + 1])
                        walls[i] += blocks[0];
                    else
                        walls[i] += blocks[1];

                }
            }

            throw new NotImplementedException();
        }

        private bool Available(int[] walls, int width)
        {
            for (int i = 1; i < walls.Length - 1; i++)
            {
                if (walls[i] == walls[i - 1]) { return false; }
                if (walls[i] == walls[i + 1]) { return false; }
            }
            return true;
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
