namespace ModelsLibrary
{
    /// <summary>
    /// Quicksort Algorithm Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Quicksort Algorithm Class Constructor
        /// </summary>
        public QuickSortAlgorithm() : base() { }

        /// <summary>
        /// Constructor for the quicksort algorithm class that takes a collection
        /// </summary>

        public QuickSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            QuickSort(0, Elements.Count - 1);
        }

        /// <summary>
        /// Recursively execute quicksort method
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void QuickSort(int left, int right)
        {
            if (left > right) return;
            int pivot = Sorting(left, right);
            QuickSort(left, pivot - 1);
            QuickSort(pivot + 1, right);
        }

        /// <summary>
        /// Sort the elements
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private int Sorting(int left, int right)
        {
            int pointer = left;
            for (int i = left; i <= right; i++) 
            {
                if (Compare(Elements[right], Elements[i]) > 0)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }
            Swap(pointer, right);
            return pointer;
        }
    }
}
