using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPrepCSharp
{
    class TriangleNode<T>{
        T data;
        public TriangleNode<T> left;
        public TriangleNode<T> right;
        float Sum;

        public TriangleNode(T value) {
            data = value;
        }
    }
    class TrianglePerimeter<T>
    {
        TriangleNode<T> root;
        void AddNodes(TriangleNode<T> node, T value) {
            if (node == null)
            {
                node = new TriangleNode<T>(value);
                return;
            }
            else {
                //get the pointer

                TriangleNode<T> current = node;

                while (true)
                {
                    if (current.left == null)
                    {
                        current.left = new TriangleNode<T>(value);
                        break;
                    }

                    if (current.right== null)
                    {
                        current.right = new TriangleNode<T>(value);
                        break;
                    }
                }
                if (node.left == null)
                {
                    node.left = new TriangleNode<T>(value);
                    return;
                }
            }

        }

        void CalculateSum(TriangleNode<T> rootNode)
        {
        }
    }
}
