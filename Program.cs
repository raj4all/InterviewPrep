using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPrepCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Fibonacci(5));
            //FibonacciSingleTraverse(5);
            //MoveZero2Firsts();
            //TicTacToe();

            //Pangram x = new Pangram();
            //x.PangramCheck("We promptly judged antique ivory buckles for the next prize");

            #region LinkedList
            //LinkedList<int> stack = new LinkedList<int>();

            //Node<int> newNode = new Node<int>(4);

            //stack.Push(newNode);
            //stack.Print();
            #endregion

            #region Triangle Least perimeter
            TriangleLeastPerimeter();
            #endregion

            #region stack
            //StackImplementation();
            #endregion

            #region Binary Search Tree
            //BinarySearchTree();
            #endregion

            int n = Convert.ToInt16(3);
            string[] sh = "3 1 4".Split(' ').ToArray();
            int[] h = Array.ConvertAll(sh, Int32.Parse);
            int m = Convert.ToInt16(0);
            int[] mPos = Array.ConvertAll("".Split(' ').ToArray(), Int32.Parse);

            int height = 0;
            int prevM = 0;
            for (int i = 0; i < mPos.Length; i++)
            {
                for (int j = prevM; j + 1 < mPos[i] && j<h.Length; j++)
                {
                    if (h[j] > (mPos[i] - (j + 1)))
                        height += mPos[i] - (j + 1);
                    else
                        height = height + h[j];
                }
                prevM = mPos[i] - 1;
            }
            for (int i = mPos[mPos.Length - 1]-1; i < h.Length; i++)
                height += h[i];
                Console.WriteLine(height);

            #region ListToTree
            //List<Dictionary<int, int>> input = new List<Dictionary<int, int>>();
            Dictionary<int, int> input = new Dictionary<int, int>();
            input.Add(7, default(int));
            input.Add(8, 7);
            input.Add(9, 7);
            input.Add(10,7);
            input.Add(3, 8);
            input.Add(4, 8);
            input.Add(5, 8);
            input.Add(1, 9);

            HeapTree tree = new HeapTree();
            tree.AddNode(input);

            #endregion
            Console.Read();
        }
        static int SumOf(int[] a, int start, int length)
        {
            int sum = 0;
            int cnt = length;
            while (cnt >= 0)
            {
                sum += a[start];
                start++;
                cnt--;
            }
            return sum;
        }

        //to get 0 based Nth number in the fibonacci series using recursive
        //1 1 2 3 5 8 13 21
        //0 1 2 3 4 5  6  7
        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                int i, j;
                i = FibonacciRecursive(n - 1);
                j = FibonacciRecursive(n - 2);
                Console.Write(i + " ");
                return i + j;
            }
        }

        //
        static int FibonacciSingleTraverse(int n)
        {
            int x = 1;
            int y = 1;
            int y1 = 0;

            for (int i = 0; i < n; i++)
            {
                y1 = x + y;
                x = y;
                y = y1;
                Console.Write(x + " ");
            }
            //Console.Write(x);
            return x;
        }

        static int BinarySearch(int key)
        {
            return 0;
        }

        static int FindTop10Users()
        {
            //HashSet<String> hsUserIds = new HashSet<String>();
            Dictionary<String, int> dsUserIds = new Dictionary<String, int>();
            //loop for all files for say, 30 days
            using (var streamReader = new System.IO.StreamReader(""))
            {
                while (true)
                {
                    string line = streamReader.ReadLine();
                    if (line == null)
                        break;
                    else
                    {
                        //if(!hsUserIds.Contains(line))
                        //    hsUserIds.Add(line);
                        if (!dsUserIds.ContainsKey(line))
                            dsUserIds.Add(line, 1);
                        else
                        {
                            dsUserIds[line] = Convert.ToInt32(dsUserIds[line]) + 1;
                        }
                    }
                }
            }

            //foreach ()
            return 0;

        }

        static void MoveZero2Firsts()
        {
            int[] a = new int[] { 3, 5, 0, 3, 5, 0 };
            int[] b = new int[6];
            int zeroPointer = 0;
            int j = a.Length - 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    b[j] = a[i];
                    j--;
                }
                else
                {
                    b[zeroPointer] = a[i];
                    zeroPointer++;
                }
            }
            foreach (int i in b)
                Console.WriteLine(b[i]);
        }

        static void TicTacToe(int size)
        {
            int[] a = new int[] { 1, 0, 1, 0, 1, 1, 0, 0, 1 };
            int hflag, vflag, dflag;
            hflag = vflag = dflag = 1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    //if(i==0 || (i+1)%size==0)
                }
            }
        }

        static void BinarySearchTree() {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.InsertNode(tree.root, 5);
            tree.InsertNode(tree.root, 8);
            tree.InsertNode(tree.root, 3);
            tree.InsertNode(tree.root, 2);
            tree.InsertNode(tree.root, 2);
            if (tree.count == 0)
                Console.WriteLine("Root is empty");
            else
            {
                tree.PreOrderPrint(tree.root);
                Console.WriteLine();
                tree.InOrderPrint(tree.root);
                Console.WriteLine();
                tree.PostOrderPrint(tree.root);
                Console.WriteLine();
                TreeNode<int> parent;
                tree.Contains(2, out parent);
            }
        }

        static void StackImplementation() {
            Stack<int> stck = new Stack<int>();
            stck.Add(5);
            stck.Add(3);
            stck.Add(8);
            stck.Print();
            stck.Pop();
            stck.Print();
            stck.Pop();
            stck.Print();
            stck.Pop();
            stck.Print();
            stck.Pop();
            stck.Print();
            stck.Pop();
            stck.Print();
            stck.Add(11);
            stck.Print();
            stck.Add(20);
            stck.Print();
        }

        static void TriangleLeastPerimeter() {
            //string[] limits = "3 2".Split(' ');
            //int n = Convert.ToInt32(limits[0]);
            //int k = Convert.ToInt32(limits[1]);
            ////Console.WriteLine(n + " " + k);
            //List<int> sums = new List<int>();
            //int sum;
            //List<int[]> items = new List<int[]>(n);


            //for (int i = 0; i < n; i++)
            //{
            //    var rowItems = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            //    items.Add(rowItems);
            //}
            //for (int i = 0; i < items.Count; i++)
            //{
            //    sum = 0;
            //    for (int j = i + 1; j < items.Count; j++)
            //    {
            //        sum += SumOf(items[j], i, j);
            //    }
            //    sums.Add(sum);
            //}
            //foreach (int i in sums)
            //    Console.WriteLine(i);
        }

    }
}
