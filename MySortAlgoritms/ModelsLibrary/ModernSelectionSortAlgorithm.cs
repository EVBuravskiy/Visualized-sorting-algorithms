namespace ModelsLibrary
{
    /// <summary>
    /// Class of modernized shaker sort algorithm
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ModernSelectionSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {

        /// <summary>
        /// Modernized Shaker Sort Algorithm Class Constructor
        /// </summary>
        public ModernSelectionSortAlgorithm() : base() { }

        /// <summary>
        /// Modernized Shaker Sort Algorithm Class constructor that accepts a collection
        /// </summary>
        public ModernSelectionSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden method sort
        /// </summary>
        protected override void MakeSort()
        {
            int left = 0;
            int right = Elements.Count - 1;
            while(left < right)
            {
                bool findMin = false;
                bool findMax = false;
                T minElement = Elements[left];
                T maxElement = Elements[left];
                int maxElementIndex = 0;
                int minElementIndex = 0;
                int i = left;
                for(; i < right; i++)
                {
                    if (Compare(minElement, Elements[i + 1]) > 0)
                    {
                        minElement = Elements[i + 1];
                        minElementIndex = i + 1;
                        findMin = true;
                    }
                    if (Compare(maxElement, Elements[i + 1]) < 0)
                    {
                        maxElement = Elements[i + 1];
                        maxElementIndex = i + 1;
                        findMax = true;
                    }
                }
                if(findMin)
                {
                    Swap(left, minElementIndex);
                    left++;
                }
                if(findMax)
                {
                    Swap(right, maxElementIndex);
                    right--;
                }
                if(!findMin && !findMax)
                {
                    break;
                }
            }

        }
    }
}
