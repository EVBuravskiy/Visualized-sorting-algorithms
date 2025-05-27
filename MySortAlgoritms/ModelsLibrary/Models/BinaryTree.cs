using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModelsLibrary.Models
{
    /// <summary>
    /// Binary tree class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T> where T : IComparable
    {
        /// <summary>
        /// Root element of a binary tree
        /// </summary>
        public TreeNode<T> Root { get; private set; }

        /// <summary>
        /// Binary tree element counter
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// List of nodes to visualize
        /// </summary>
        public List<T> ListOfNodes { get; set; }

        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public event EventHandler<Tuple<T, T>> CompareBinaryTreeEvent;

        /// <summary>
        /// Sorted items collection change event
        /// </summary>
        public event EventHandler<List<T>> ChangeSortedElements;

        /// <summary>
        /// Event of exchanging elements in a collection of elements
        /// </summary>
        public event EventHandler<List<T>> SwapEvent;

        /// <summary>
        /// Default Binary Tree Constructor
        /// </summary>
        public BinaryTree() 
        {
            Root = null;
            Count = 0;
            ListOfNodes = new List<T>();
        }

        /// <summary>
        /// Binary tree constructor with construction from a collection of elements
        /// </summary>
        /// <param name="elements"></param>
        public BinaryTree(IEnumerable<T> elements) : this()
        {
            foreach(T element in elements)
            {
                AddNode(element);
                ListOfNodes.Add(element);
            }
        }

        /// <summary>
        /// Add nodes from the elements collection
        /// </summary>
        /// <param name="elements"></param>
        public void AddNodes(IEnumerable<T> elements)
        {
            foreach (T element in elements)
            {
                AddNode(element);
                ListOfNodes.Add(element);
            }
        }

        /// <summary>
        /// Create a node from an element and add the node to a binary tree
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(T data)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(data);
                Root.ComparisonEvent += Node_ComparisonEvent;
                Count++;
                return;
            }
            TreeNode<T> newNode = new TreeNode<T>(data);
            Root.AddNode(newNode);
            newNode.ComparisonEvent += Node_ComparisonEvent;
            Count++;
        }

        /// <summary>
        /// Tree traversal using infix traversal
        /// </summary>
        /// <returns>List of binary tree element values</returns>
        public List<T> InfixTreeTraversal()
        {
            if(Root == null)
            {
                return new List<T>();
            }
            return InfixTreeTraversal(Root);
        }

        /// <summary>
        /// Private infix traversal of a binary tree
        /// </summary>
        /// <param name="currentNode"></param>
        /// <returns>List of binary tree element values</returns>
        private List<T> InfixTreeTraversal(TreeNode<T> currentNode) 
        { 
            List<T> list = new List<T>();
            if(currentNode != null)
            {
                if(currentNode.LeftChildNode != null)
                {
                    list.AddRange(InfixTreeTraversal(currentNode.LeftChildNode));
                }
                list.Add(currentNode.Data);
                GetSortedElements(list);
                if(currentNode.RightChildNode != null)
                {
                    list.AddRange(InfixTreeTraversal(currentNode.RightChildNode));
                }
            }
            return list;

        }

        /// <summary>
        /// Get a list of sorted elements
        /// </summary>
        /// <returns>List of sorted elements</returns>
        public void GetSortedElements(List<T> list)
        {
            List<T> tempElements = new List<T>();
            tempElements.AddRange(ListOfNodes);
            foreach(T element in list)
            {
                tempElements.Remove(element);
            }
            tempElements.AddRange(list);
            ListOfNodes = tempElements;
            ChangeSortedElements?.Invoke(this, tempElements);
            SwapEvent?.Invoke(this, list);
        }

        /// <summary>
        /// Create comparison event for visualisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void Node_ComparisonEvent(object sender, Tuple<T, T> tuple)
        {
            CompareBinaryTreeEvent?.Invoke(this, tuple);
        }
    }
}
