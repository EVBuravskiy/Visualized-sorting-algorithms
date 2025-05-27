namespace ModelsLibrary
{
    /// <summary>
    /// Class of LSD radix sorting algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LSDRadixSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Constructor of the Radix Sort Algorithm Class
        /// </summary>
        public LSDRadixSortAlgorithm() : base() { }

        /// <summary>
        /// Constructor of the radix sort algorithm class that takes a collection
        /// </summary>
        public LSDRadixSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden method sort
        /// </summary>
        protected override void MakeSort()
        {
            List<List<T>> keys = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                keys.Add(new List<T>());
            }

            int maxDisharge = GetMaxDisharge();

            for (int step = 0; step < maxDisharge; step++)
            {
                foreach(var element in Elements)
                {
                    int currentValue = element.GetHashCode();
                    int value = (currentValue % (int)Math.Pow(10, step + 1)) / (int)Math.Pow(10, step);
                    keys[value].Add(element);
                }

                int j = 0;

                foreach(var key in keys)
                {
                    foreach(var element in key)
                    {
                        SetPosition(j, element);
                        j++;
                    }
                }

                foreach(var key in keys)
                {
                    key.Clear();
                }
            }
        }

        /// <summary>
        /// Determine the maximum discharge
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private int GetMaxDisharge()
        {
            int maxDisharge = 0;
            foreach (var elements in Elements)
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
