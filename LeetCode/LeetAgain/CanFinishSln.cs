using System.Collections.Generic;

namespace LeetCode.LeetAgain
{
    class CanFinishSln : ISolution
    {
        bool hasCycle = false;
        private Stack<int> stack = new Stack<int>();

        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var visisted = new bool[numCourses];
            var discovered = new bool[numCourses];


            Dictionary<int, HashSet<int>> vetex = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (!vetex.ContainsKey(prerequisites[i][1]))
                {
                    vetex[prerequisites[i][1]] = new HashSet<int>() { prerequisites[i][0] };
                }
                else
                {
                    vetex[prerequisites[i][1]].Add(prerequisites[i][0]);
                }
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (vetex.ContainsKey(i) == false)
                {
                    vetex[i] = new HashSet<int>();
                }
            }

            Dfs(visisted, discovered, vetex);


            if (hasCycle)
            {
                return new int[0];
            }
            else
            {
                return new List<int>(stack).ToArray();
            }
        }


        private void Dfs(bool[] visited, bool[] discovered, Dictionary<int, HashSet<int>> prerequisites)
        {
            foreach (var item in prerequisites)
            {
                if (!visited[item.Key] && !discovered[item.Key])
                {
                    DfsVisit(visited, discovered, item.Key, prerequisites);
                }
            }
        }

        private void DfsVisit(bool[] visited, bool[] discovered, int node, Dictionary<int, HashSet<int>> prerequisites)
        {
            if (visited[node])
            {
                return;
            }
            if (discovered[node])
            {
                hasCycle = true;
                return;
            }
            //time++;
            discovered[node] = true;
            //u.d = time;
            //u.color = GRAY;
            if (prerequisites.ContainsKey(node))
            {
                foreach (var item in prerequisites[node])
                {
                    DfsVisit(visited, discovered, item, prerequisites);
                }
            }


            visited[node] = true;
            stack.Push(node);
            //time = time+1
            //u.f = time
        }

        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var visisted = new bool[numCourses];
            var discovered = new bool[numCourses];


            Dictionary<int, HashSet<int>> vetex = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (!vetex.ContainsKey(prerequisites[i][1]))
                {
                    vetex[prerequisites[i][1]] = new HashSet<int>() { prerequisites[i][0] };
                }
                else
                {
                    vetex[prerequisites[i][1]].Add(prerequisites[i][0]);
                }
            }
            Dfs(visisted, discovered, vetex);

            return !hasCycle;
        }


        public void Execute()
        {
            int[][] pre = new int[1][];
            pre[0] = new int[] { 1, 0 };
            //pre[1] = new int[] { 2, 1 };
            //pre[1] = new int[] { 2, 3 };
            //pre[2] = new int[] { 3, 4 };
            //pre[3] = new int[] { 4, 1 };

            var bb = FindOrder(3, pre);
        }
    }
}
