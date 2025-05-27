namespace ModelsLibrary
{
    /// <summary>
    /// Shaker sort algorithm class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShakerSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable 
    {

        /// <summary>
        /// Shaker Sort Algorithm Class Constructor
        /// </summary>
        public ShakerSortAlgorithm() : base() { }

        /// <summary>
        /// Shaker Sort Algorithm Class Constructor taking a collection
        /// </summary>
        public ShakerSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overridden sort method
        /// </summary>
        protected override void MakeSort()
        {
            int left = 0;
            int right = Elements.Count - 1;
            while(left < right)
            {
                bool fl = false;
                for (int i = left; i < right; i++)
                {
                    if (Compare(Elements[i], Elements[i + 1]) > 0)
                    {
                        Swap(i, i + 1);
                        fl = true;
                    }
                }
                if (!fl) break;
                right--;
                for(int i = right; i > left; i--)
                {
                    if (Compare(Elements[i], Elements[i - 1]) < 0)
                    {
                        Swap(i, i - 1);
                        fl = true;
                    }
                }
                left++;
                if(!fl) break;
            }
        }
    }
}
