namespace ModelsLibrary
{
    /// <summary>
    /// Shell sorting algorithm class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShellSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Shell Sort Algorithm class constructor
        /// </summary>
        public ShellSortAlgorithm() : base(){}

        /// <summary>
        /// Shell sort algorithm class constructor that takes a collection
        /// </summary>

        public ShellSortAlgorithm(IEnumerable<T> elements) : base(elements){}
        
        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            int step = Elements.Count / 2;
            while (step > 0)
            {
                for (int i = step; i < Elements.Count; i++)
                {
                    int j = i;
                    while (j >= step && Compare(Elements[j - step], Elements[j]) > 0)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
