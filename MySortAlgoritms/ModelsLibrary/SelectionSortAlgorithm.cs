namespace ModelsLibrary
{
    /// <summary>
    /// Selection sort algorithm class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Selection Sort Algorithm Class Constructor
        /// </summary>
        public SelectionSortAlgorithm() : base() { }

        /// <summary>
        /// Constructor for a selection sort algorithm class that takes a collection
        /// </summary>
        public SelectionSortAlgorithm(IEnumerable<T> elements) : base(elements) { }
        
        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            int minIndex = 0;
            for(int i = 0; i < Elements.Count - 1; i++)
            {
                minIndex = i;
                for(int j = i + 1; j < Elements.Count; j++)
                {
                    if (Compare(Elements[minIndex], Elements[j]) > 0)
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    Swap(i, minIndex);
                }

            }
        }
    }
}
