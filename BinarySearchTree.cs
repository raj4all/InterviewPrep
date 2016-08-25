using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPrepCSharp
{
    class TreeNode<T>:IComparable<T>
        where T:IComparable<T>
    {
        public T data;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode(T value)
        {
            data = value;
        }

        public int CompareTo(T otherValue)
        {
            return data.CompareTo(otherValue);
        }
    }
    class BinarySearchTree<T>
        where T:IComparable<T>
    {
        public TreeNode<T> root;

        public int count;

        public void InsertNode(TreeNode<T> node, T value)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
                root = node;
                count++;
            }
            else
            {

                if (node.data.CompareTo(value) > 0)//move left
                {
                    if (node.left != null)
                    {
                        InsertNode(node.left, value);
                    }
                    else
                    {
                        node.left = new TreeNode<T>(value);
                        count++;
                    }
                }
                if (node.data.CompareTo(value) <= 0)//move right
                {
                    if (node.right != null)
                    {
                        InsertNode(node.right, value);
                    }
                    else
                    {
                        node.right = new TreeNode<T>(value);
                        count++;
                    }
                }
            }
        }

        public void PreOrderPrint(TreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write("{0}\t", node.data);
                PreOrderPrint(node.left);
                PreOrderPrint(node.right);
            }
        }

        public void InOrderPrint(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrderPrint(node.left);
                Console.Write("{0}\t", node.data);
                InOrderPrint(node.right);
            }
        }
        public void PostOrderPrint(TreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderPrint(node.left);
                PostOrderPrint(node.right);
                Console.Write("{0}\t", node.data);
            }
        }

        public TreeNode<T> Contains(T value, out TreeNode<T> parent)
        {
            TreeNode<T> current = root;
            parent = null;
            while (current != null)
            {
                if (current.data.CompareTo(value) == 0)
                {
                    return current;
                }
                else if (current.data.CompareTo(value) > 0)//move left
                {
                    if (current.left == null)
                        return null;
                    else
                    {
                        parent = current;
                        current = current.left;
                    }
                }
                else//move left
                {
                    if (current.right == null)
                        return null;
                    else
                    {
                        parent = current;
                        current = current.right;
                    }
                }
            }
            return null;
        }
    }
}
