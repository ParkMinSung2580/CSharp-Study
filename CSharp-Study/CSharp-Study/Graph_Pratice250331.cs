using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    internal class Graph_Pratice250331
    {
        //단방향 연결 그래프
        /*
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

            node0.AddNode(node1);   // 0 -> 1
            node2.AddNode(node1);   // 2 -> 1     
            node3.AddNode(node1);   // 3 -> 1     
            node0.AddNode(node3);   // 0 -> 3     
            node2.AddNode(node4);   // 2 -> 4     
            node3.AddNode(node5);   // 3 -> 5     
            node5.AddNode(node3);   // 5 -> 3     
            node6.AddNode(node5);   // 6 -> 5     
            node7.AddNode(node5);   // 7 -> 5
            node6.AddNode(node7);   // 6 -> 7     
            node7.AddNode(node6);   // 7 -> 6

            List<GraphNode<int>> GraphList = new List<GraphNode<int>>();
            GraphList.Add(node0);
            GraphList.Add(node1);
            GraphList.Add(node2);
            GraphList.Add(node3);
            GraphList.Add(node4);
            GraphList.Add(node5);
            GraphList.Add(node6);
            GraphList.Add(node7);

            foreach(GraphNode<int> node in GraphList)
            {
                node.Print();
            }
        }

        public class GraphNode<T>
        {
            private T vertex;
            public T Vertex { get { return vertex; } set { vertex = value; } }

            private List<GraphNode<T>> edges;   //갈수있는 간선의 List

            public List<GraphNode<T>> Edges { get { return edges; } set { edges = value; } }

            public GraphNode(T vertex) { this.vertex = vertex; this.edges = new List<GraphNode<T>>(); } // 생성자

            public void AddNode(GraphNode<T> node)
            {
                Edges.Add(node);    //노드들끼리의 연결
            }

            public void RemoveNode(GraphNode<T> node) 
            {
                Edges.Remove(node); //노드 연결 해제
            }

            public void Print() {
                foreach (GraphNode<T> edge in Edges)
                {
                    Console.Write("[나의 번호 : {0}] ", this.vertex);
                    Console.Write("{0} -> {1}   ",this.vertex, edge.vertex);
                }
                Console.WriteLine();
            }
        }*/

        //가중치 그래프
        
        public static void Main()
        {

        }

        public class Edge       //간선
        {
            //가중치,목표

        };

        public class GraphNode
        { 
        
        };
    }
}


