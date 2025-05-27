using ModelsLibrary.Models;

namespace ModelsLibrary
{
    /// <summary>
    /// Binary tree sorting class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTreeSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public override event EventHandler<Tuple<T, T>> ComparisonEvent;

        /// <summary>
        /// Event of getting a collection of sorted elements
        /// </summary>
        public override event EventHandler<List<T>> GetSortedElements;

        /// <summary>
        /// Event of exchanging elements in a collection of elements
        /// </summary>
        public override event EventHandler<Tuple<T, T>> SwapEvent;

        /// <summary>
        /// Binary tree sort class constructor
        /// </summary>
        public BinaryTreeSortAlgorithm() : base() { }

        /// <summary>
        /// Binary tree sort class constructor that takes a collection
        /// </summary>
        public BinaryTreeSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            List<T> saves = new List<T>();
            saves.AddRange(Elements);
            BinaryTree<T> binaryTree = new BinaryTree<T>();
            binaryTree.ChangeSortedElements += Algorithm_GetSortedElements;
            binaryTree.CompareBinaryTreeEvent += Algorithm_CompareEvent;
            binaryTree.SwapEvent += Algorithm_SwapEvent;
            binaryTree.AddNodes(Elements);
            List<T> sortedElements = binaryTree.InfixTreeTraversal();
            Elements = sortedElements.ToList();
        }

        /// <summary>
        /// Create element comparison event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void Algorithm_CompareEvent(object sender, Tuple<T, T> tuple)
        {
            ComparisonEvent?.Invoke(this, tuple);
            ComparisonCount++;
        }

        /// <summary>
        /// Create an event to get a collection of sorted elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="changeElements"></param>
        private void Algorithm_GetSortedElements(object sender, List<T> changeElements)
        {
            GetSortedElements?.Invoke(this, changeElements);
        }

        /// <summary>
        /// Create event of exchanging elements in a collection of elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="elements"></param>
        private void Algorithm_SwapEvent(object sender, List<T> elements)
        {
            List<T> values = new List<T>();
            values.AddRange(elements);
            T firstElement = values.Last() ?? default(T);
            T secondElement = values.Last() ?? values.First();
            Tuple<T, T> swapsElements = new Tuple<T, T>(firstElement, secondElement);
            SwapEvent?.Invoke(this, swapsElements);
            SwapCount++;
        }
    }
}
