using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    internal class Graph
    {
        static void Main()
        {
            GraphNode<int> node0 = new GraphNode<int>(0);
            GraphNode<int> node1 = new GraphNode<int>(1);
            GraphNode<int> node2 = new GraphNode<int>(2);
            GraphNode<int> node3 = new GraphNode<int>(3);
            GraphNode<int> node4 = new GraphNode<int>(4);
            GraphNode<int> node5 = new GraphNode<int>(5);
            GraphNode<int> node6 = new GraphNode<int>(6);
            GraphNode<int> node7 = new GraphNode<int>(7);
            GraphNode<int> node8 = new GraphNode<int>(8);

            node0.AddEdge(node3);
            node3.AddEdge(node0);
            node0.AddEdge(node4);
            node4.AddEdge(node0);
        }
    }

    public class GraphNode<T>
    {
        private T vertex;
        public T Vertex { get { return vertex; } set { vertex = value; } }

        public GraphNode(T vertex)
        {
            this.vertex = vertex;
        }

        private List<GraphNode<T>> edges = new List<GraphNode<T>>();
        //public List<GraphNode<T>> Edges { get { return edges; } }

        public void AddEdge(GraphNode<T> node)
        {
            //단방향 연결
            edges.Add(node);
        }

        public void RemoveEdge(GraphNode<T> node)
        {
            //단방향
            edges.Remove(node);
        }

        public bool IsConnect(GraphNode<T> node)
        {
            return edges.Contains(node);
        }

        /*public void Print()
        {
            foreach(List<GraphNode<T>> node in Edges)
            {
                
            }
        }*/
    }

}
