﻿namespace _03MostReliablePath
{

    using System;

    public class Edge : IComparable<Edge>
    {
        public Edge(int parent, int child, double weight)
        {
            this.Parent = parent;
            this.Child = child;
            this.Weight = weight;
        }

        public int Parent { get; set; }

        public int Child { get; set; }

        public double Weight { get; set; }

        public int CompareTo(Edge other)
        {
            return this.Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return string.Format("({0} {1}) -> {2}", this.Parent, this.Child, this.Weight);
        }
    }
}
