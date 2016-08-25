using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPrepCSharp
{
    class HeapNode:IEquatable<HeapNode>
    {
        public int data;
        public HeapNode parent;
        public List<HeapNode> children = new List<HeapNode>();

        public HeapNode(int value)
        {
            data = value;
        }

        public bool Equals(HeapNode other) {
            if (this.data == other.data)
                return true;
            foreach(HeapNode c in children)
                if (c.data == other.data)
                    return true;
            return false;
        }

        public HeapNode Find()
        {
            return null;
        }
    }

    class HeapTree
    {
        int count;
        HeapNode root;
        public List<HeapNode> items = new List<HeapNode>();

        public void AddNode(Dictionary<int,int> input)
        {
            foreach (KeyValuePair<int, int> kvp in input)
            {
                //if (items != null)
                //{
                //    items.Add(new HeapNode(kvp.Key));
                //}
                //else
                //{

                //get parent
                //GetParent(kvp.Value);
                HeapNode parent = items.Find(x => x.data == kvp.Value);
                if (parent != null)
                {
                    parent.children.Add(new HeapNode(kvp.Key));
                    //items.Add(parent); // create parent
                }
                else
                    items.Add(new HeapNode(kvp.Key));

                count++;
            }
            //HeapNode root;
            ////get parent
            //root = input.Where(x => x.Value == default(int)).Select(x => new HeapNode(x.Key)).FirstOrDefault();

                //HeapNode pointer = root;
                //while (pointer != null)
                //{
                //    pointer = 
                //}
                //foreach (KeyValuePair<int,int> kvp in input)
                //{
                //   heap.children = input.Where(x => x.Value == kvp.Key).Select(x => x.Key).ToArray();
                //   heap.data = kvp.Key;
                //   //heap.parent = kvp.Value;
                //}
        }

        public HeapNode GetParent(HeapNode child)
        {
            foreach (HeapNode i in items)
            {

            }
            //HeapNode parent = items.Where(x => x.children.Equals(other.data)).Select(x => x.parent).FirstOrDefault();
            return null;
        }
    }
}
