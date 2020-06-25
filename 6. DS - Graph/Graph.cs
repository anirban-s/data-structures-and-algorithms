using System;
using System.Collections.Generic;
using System.Text;

class Graph
{
    private Dictionary<int, List<int>> adjacentList;
    private int numberOfNodes;

    public Graph()
    {
        adjacentList = new Dictionary<int, List<int>>();
        numberOfNodes = 0;
    }

    public void addVertex(int value) {
        adjacentList.Add(value, new List<int>());
        numberOfNodes++;
    }

    public void addEdge(int value1, int value2)
    {
        adjacentList[value1].Add(value2);
        adjacentList[value2].Add(value1);
    }

    public void showConnections()
    {
        foreach(var item in adjacentList) {
          List<int> nodeConnections = adjacentList[item.Key];
          StringBuilder connections = new StringBuilder();
          foreach(int edge in nodeConnections) {
            connections.Append(edge).Append(" ");
          }
          Console.WriteLine(item.Key + "-->" + connections);
        }
    }

    static void Main(string[] args)
    {
        Graph graph = new Graph();
        graph.addVertex(0);
        graph.addVertex(1);
        graph.addVertex(2);
        graph.addVertex(3);
        graph.addVertex(4);
        graph.addVertex(5);
        graph.addVertex(6);
        graph.addEdge(3, 1);
        graph.addEdge(3, 4);
        graph.addEdge(4, 2);
        graph.addEdge(4, 5);
        graph.addEdge(1, 2);
        graph.addEdge(1, 0);
        graph.addEdge(0, 2);
        graph.addEdge(6, 5);
        graph.showConnections();
    }
}