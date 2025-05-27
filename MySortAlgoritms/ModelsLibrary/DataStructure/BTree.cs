using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.DataStructure
{
    /// <summary>
    /// Binary tree class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BTree<T> : AlgorithmBaseClass<T> where T: IComparable
    {
        /// <summary>
        /// Root element of a binary tree
        /// </summary>
        public TNode<T> Root { get; private set; }

        /// <summary>
        /// Binary tree element counter
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Default Binary Tree Constructor
        /// </summary>
        public BTree()
        {
            Root = null;
            Count = 0;
        }

        /// <summary>
        /// Binary tree constructor with construction from a collection of elements
        /// </summary>
        /// <param name="elements"></param>
        public BTree(IEnumerable<T> elements) : this()
        {
            AddNodes(elements);
        }

        /// <summary>
        /// Add all elements to a binary tree from a collection of elements
        /// </summary>
        /// <param name="elements"></param>
        public void AddNodes(IEnumerable<T> elements)
        {
            List<T> inputElements = elements.ToList();
            for(int i = 0; i < inputElements.Count; i++)
            {
                T element = inputElements[i];
                Elements.Add(element);
                TNode<T> newNode = new TNode<T>(element, i);
                AddNode(newNode);
            }
        }

        /// <summary>
        /// Add element to binary tree
        /// </summary>
        /// <param name="element"></param>
        public void AddNode(TNode<T> newNode)
        {
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return;
            }
            AddNode(Root, newNode);
            Count++;
        }

        /// <summary>
        /// Recursively adding a new node
        /// </summary>
        /// <param name="element"></param>
        private void AddNode(TNode<T> currentNode, TNode<T> newNode)
        {
            if (Compare(currentNode.Data, newNode.Data) > 0)
            {
                if (currentNode.LeftChildNode == null)
                {
                    newNode.ParentNode = currentNode;
                    currentNode.LeftChildNode = newNode;
                }
                else
                {
                    AddNode(currentNode.LeftChildNode, newNode);
                }
            }
            else
            {
                if (currentNode.RightChildNode == null)
                {
                    newNode.ParentNode = currentNode;
                    currentNode.RightChildNode = newNode;
                }
                else
                {
                    AddNode(currentNode.RightChildNode, newNode);
                }
            }
        }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        /// <returns>List of binary tree elements</returns>
        protected override void MakeSort()
        {
            List<T> result = InfixTreeTraversal(Root).Select(r => r.Data).ToList();

            for(int i = 0; i < result.Count; i++)
            {
                SetPosition(i, result[i]);
            }
        }

        /// <summary>
        /// Private infix traversal of a binary tree
        /// </summary>
        /// <param name="currentNode"></param>
        /// <returns>List of binary tree element values</returns>
        private List<TNode<T>> InfixTreeTraversal(TNode<T> currentNode)
        {
            List<TNode<T>> result = new List<TNode<T>>();
            if (currentNode != null)
            {
                if (currentNode.LeftChildNode != null)
                {
                    result.AddRange(InfixTreeTraversal(currentNode.LeftChildNode));
                }

                result.Add(currentNode);
                
                if (currentNode.RightChildNode != null)
                {
                    result.AddRange(InfixTreeTraversal(currentNode.RightChildNode));
                }
            }
            return result;
        }
    }
}