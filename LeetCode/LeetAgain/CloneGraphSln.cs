using System.Collections.Generic;
using System.Linq;

namespace LeetCode.LeetAgain.Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    public class CloneGraphSln : ISolution
    {
        ///// <summary>
        ///// BFS
        ///// </summary>
        ///// <param name="node"></param>
        ///// <returns></returns>
        //public Node CloneGraph(Node node)
        //{
        //    if (node == null)
        //        return null;
        //    Queue<Node> queue = new Queue<Node>();
        //    Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        //    var result = new Node(node.val);
        //    queue.Enqueue(node);
        //    dict[node] = result;
        //    while (queue.Count > 0)
        //    {
        //        var q = queue.Dequeue();

        //        for (int i = 0; i < q.neighbors.Count; i++)
        //        {
        //            if (dict.ContainsKey(q.neighbors[i]))
        //            {
        //                dict[q].neighbors.Add(dict[q.neighbors[i]]);
        //            }
        //            else
        //            {
        //                var nc = new Node(q.neighbors[i].val);
        //                dict[q.neighbors[i]] = nc;
        //                dict[q].neighbors.Add(nc);
        //                queue.Enqueue(q.neighbors[i]);
        //            }
        //        }
        //    }

        //    return dict[node];
        //}


        //public HashMap<Integer, UndirectedGraphNode> map = new HashMap();
        //public UndirectedGraphNode cloneGraph(UndirectedGraphNode node)
        //{
        //    if (node == null) return null;
        //    if (map.containsKey(node.label))
        //        return map.get(node.label);
        //    UndirectedGraphNode cloned = new UndirectedGraphNode(node.label);
        //    map.put(cloned.label, cloned);
        //    for (UndirectedGraphNode neighbor: node.neighbors)
        //    {
        //        cloned.neighbors.add(cloneGraph(neighbor));
        //    }
        //    return cloned;
        //}


        public Dictionary<Node, Node> dict = new Dictionary<Node, Node>();

        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            if (dict.ContainsKey(node))
            {
                return dict[node];
            }

            var nc = new Node(node.val);
            dict[node] = nc;
            foreach (var nodeNeighbor in node.neighbors)
            {
                nc.neighbors.Add(CloneGraph(nodeNeighbor));
            }

            return nc;
        }

        public void Execute()
        {
        }
    }
}