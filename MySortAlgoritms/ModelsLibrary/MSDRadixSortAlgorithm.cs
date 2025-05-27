namespace ModelsLibrary
{
    /// <summary>
    /// Class of MSD radix sorting algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MSDRadixSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Constructor of the Radix Sort Algorithm Class
        /// </summary>
        public MSDRadixSortAlgorithm() : base() { }

        /// <summary>
        /// Constructor of the radix sort algorithm class that takes a collection
        /// </summary>
        public MSDRadixSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden method sort
        /// </summary>
        protected override void MakeSort()
        {
            int maxDisharge = GetMaxDisharge(Elements);
            List<T> sortedCollection = SortCollection(Elements, maxDisharge - 1);
            for(int i =0; i < sortedCollection.Count; i++)
            {
                SetPosition(i, sortedCollection[i]);
            }
        }

        /// <summary>
        /// Recursive collection sorting
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="disharge"></param>
        /// <returns>List of sorted elements</returns>
        private List<T> SortCollection(List<T> collection, int disharge)
        {
            List<T> sortedCollection = new List<T>();
            List<List<T>> keys = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                keys.Add(new List<T>());
            }
            foreach (var element in collection)
            {
                int currentValue = element.GetHashCode();
                int value = (currentValue % (int)Math.Pow(10, disharge + 1)) / (int)Math.Pow(10, disharge);
                keys[value].Add(element);
            }
            foreach (var key in keys)
            {
                if (key.Count > 1 && disharge > 0)
                {
                    sortedCollection.AddRange(SortCollection(key, disharge - 1));
                    continue;
                }
                sortedCollection.AddRange(key);
            }
            return sortedCollection;
        }
        /// <summary>
        /// Determine the maximum discharge
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private int GetMaxDisharge(List<T> collection)
        {
            int maxDisharge = 0;
            foreach (var elements in collection)
            {
                if (elements.GetHashCode() < 0)
                {
                    throw new ArgumentException("Radix sort only supports positive integers");
                }
                int currentDisharge = 0;
                if (elements.GetHashCode() > 0)
                {
                    currentDisharge = Convert.ToInt32(Math.Log10(elements.GetHashCode()));
                }
                if (maxDisharge < currentDisharge)
                {
                    maxDisharge = currentDisharge;
                }
            }
            return maxDisharge;
        }
    }
}
