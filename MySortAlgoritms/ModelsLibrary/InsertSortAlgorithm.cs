namespace ModelsLibrary
{
    /// <summary>
    /// Insertion sort algorithm class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class InsertSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {

        /// <summary>
        /// Constructor of the Insertion Sort Algorithm Class
        /// </summary>
        public InsertSortAlgorithm() : base() {}

        /// <summary>
        /// Constructor for an insertion sort algorithm class that takes a collection
        /// </summary>
        public InsertSortAlgorithm(IEnumerable<T> elements) : base(elements){}


        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            for(int i = 1; i < Elements.Count; i++)
            {
                var currentElement = Elements[i];
                var j = i;
                while (j > 0 && Compare(currentElement, Elements[j - 1]) < 0)
                {
                    Swap(j, j - 1);
                    //Elements[j] = Elements[j - 1];
                    j--;
                    SwapCount++;
                }
                Elements[j] = currentElement;
            }
        }
    }
}
