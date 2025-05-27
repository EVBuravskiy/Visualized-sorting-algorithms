using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.DataStructure
{
    /// <summary>
    /// Node class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TNode<T> where T : IComparable
    {
        /// <summary>
        /// Point to parent node
        /// </summary>
        public TNode<T> ParentNode { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Point to left child node
        /// </summary>
        public TNode<T> LeftChildNode { get; set; }

        /// <summary>
        /// Point to right child node
        /// </summary>
        public TNode<T> RightChildNode { get; set; }

        /// <summary>
        /// Index of the current element
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        /// Node constructor
        /// </summary>
        /// <param name="data"></param>
        public TNode(T data, int currentIndex)
        {
            CurrentIndex = currentIndex;
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
