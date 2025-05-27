namespace ModelsLibrary
{
    /// <summary>
    /// Bubble Sort Algorithm Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {

        /// <summary>
        /// Bubble Sort Algorithm Class Constructor
        /// </summary>
        public BubbleSortAlgorithm() : base() {}

        /// <summary>
        /// Bubble sort algorithm class constructor that takes a collection
        /// </summary>

        public BubbleSortAlgorithm(IEnumerable<T> elements) : base(elements) {}

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            var lenght = Elements.Count();
            for (int i = 0; i < lenght; i++)
            {
                bool fl = false;
                for (int j = 0; j < lenght - 1 - i; j++)
                {
                    var leftElement = Elements[j];
                    var rightElement = Elements[j + 1];
                    if (Compare(leftElement, rightElement) > 0)
                    {
                        Swap(j, j + 1);
                        fl = true;
                    }
                }
                if (!fl)
                {
                    break;
                }
            }
        }
    }
}
