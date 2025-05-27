using ModelsLibrary.Models;

namespace ModelsLibrary
{
    /// <summary>
    /// Binary Heap Sort Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryHeapSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public override event EventHandler<Tuple<T, T>> ComparisonEvent;

        /// <summary>
        /// Event of exchanging elements in a collection of elements
        /// </summary>
        public override event EventHandler<Tuple<T, T>> SwapEvent;

        /// <summary>
        /// Event of getting a collection of sorted elements
        /// </summary>
        public override event EventHandler<List<T>> GetSortedElements;

        /// <summary>
        /// Constructor of the Insertion Sort Algorithm class that accepts a collection
        /// </summary>
        public BinaryHeapSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            BinaryHeap<T> binaryHeap = new BinaryHeap<T>();
            binaryHeap.SwapEvent += Algorithm_SwapEvent;
            binaryHeap.ComparisonEvent += Algorithm_CompareEvent;
            binaryHeap.ChangeSortedElements += Algorithm_GetSortedElements;
            binaryHeap.PushElements(Elements);
            List<T> sortedElements = binaryHeap.GetSortedElements();
            Elements = sortedElements;
        }

        /// <summary>
        /// Create event of exchanging elements in a collection of elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void Algorithm_SwapEvent(object sender, Tuple<T, T> tuple)
        {
            SwapEvent?.Invoke(this, tuple);
            SwapCount++;
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

    }
}
