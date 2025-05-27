using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Models
{
    /// <summary>
    /// Binary tree node class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T> : IComparable where T : IComparable
    {
        /// <summary>
        /// Pointer to parent node
        /// </summary>
        public TreeNode<T> ParentNode { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Pointer to left child node
        /// </summary>
        public TreeNode<T> LeftChildNode { get; set; }

        /// <summary>
        /// Pointer to right child node
        /// </summary>
        public TreeNode<T> RightChildNode { get; set; }

        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public event EventHandler<Tuple<T, T>> ComparisonEvent;

        /// <summary>
        /// Tree node constructor
        /// </summary>
        /// <param name="data"></param>
        public TreeNode(T data)
        {
            ParentNode = null;
            Data = data;
            LeftChildNode = null;
            RightChildNode = null;
        }
        
        /// <summary>
        /// Add node
        /// </summary>
        /// <param name="data"></param>
        public void AddNode(TreeNode<T> newNode)
        {
            if(Compare(Data, newNode.Data) > 0)
            {
                if(LeftChildNode == null)
                {
                    newNode.ParentNode = this;
                    LeftChildNode = newNode;
                }
                else
                {
                    LeftChildNode.AddNode(newNode);
                }
            }
            else
            {
                if(RightChildNode == null)
                {
                    newNode.ParentNode = this;
                    RightChildNode = newNode;
                }
                else
                {
                    RightChildNode.AddNode(newNode);
                }
            }
        }

        /// <summary>
        /// Create a node comparison event
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        protected int Compare(T firstElement, T secondElement)
        {
            Tuple<T, T> compareElements = new Tuple<T, T>(firstElement, secondElement);
            ComparisonEvent?.Invoke(this, compareElements);
            return firstElement.CompareTo(secondElement);
        }

        /// <summary>
        /// Compare nodes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if(obj is TreeNode<T> node)
            {
                return node.Data.CompareTo(Data);
            }
            throw new ArgumentException("obj is not TreeNode");
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
