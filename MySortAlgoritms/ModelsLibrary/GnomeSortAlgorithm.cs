namespace ModelsLibrary
{
    /// <summary>
    /// Gnome sorting algorithm class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GnomeSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Gnome sorting algorithm class constructor
        /// </summary>
        public GnomeSortAlgorithm() : base() { }

        /// <summary>
        /// Gnome sort algorithm class constructor that takes a collection
        /// </summary>
        public GnomeSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            int currentIndex = 1;
            int lastCheckIndex = 1;
            while(currentIndex < Elements.Count)
            {
                if (currentIndex == 0 || Compare(Elements[currentIndex], Elements[currentIndex - 1]) != -1)
                {
                    currentIndex++;
                    lastCheckIndex++;
                    if(currentIndex < lastCheckIndex)
                    {
                        currentIndex = lastCheckIndex;
                    }
                }
                else
                {
                    Swap(currentIndex, currentIndex - 1);
                    currentIndex--;
                }
            }
        }
    }
}
