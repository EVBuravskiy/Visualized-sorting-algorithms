namespace ModelsLibrary
{
    /// <summary>
    /// Merge Sort Algorithm Class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSortAlgorithm<T> : AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Merge Sort Algorithm Class Constructor
        /// </summary>
        public MergeSortAlgorithm() : base() { }

        /// <summary>
        /// Constructor for a merge sort algorithm class that takes a collection
        /// </summary>
        public MergeSortAlgorithm(IEnumerable<T> elements) : base(elements) { }

        /// <summary>
        /// Overriding the sort method
        /// </summary>
        protected override void MakeSort()
        {
            List<T> sortedElements = MergeSort(Elements);
            for (int i = 0; i < sortedElements.Count; i++)
            {
                SetPosition(i, sortedElements[i]);
            }
        }

        /// <summary>
        /// Merge Sort
        /// </summary>
        /// <param name="collection"></param>
        /// <returns>List of sorted elements by merge method</returns>
        private List<T> MergeSort(List<T> collection)
        {
            if(collection.Count == 1) return collection;
            int middleIndex = collection.Count / 2;
            List<T> leftCollection = collection.Take(middleIndex).ToList();
            List<T> rightCollection = collection.Skip(middleIndex).ToList();
            return Merge(MergeSort(leftCollection), MergeSort(rightCollection));
        }

        /// <summary>
        /// Perform the merge
        /// </summary>
        /// <param name="leftCollection"></param>
        /// <param name="rightCollection"></param>
        /// <returns>List of sorted elements by merge method</returns>
        private List<T> Merge(List<T> leftCollection, List<T> rightCollection)
        {
            int count = leftCollection.Count + rightCollection.Count;
            int leftPointer = 0;
            int rightPointer = 0;
            List<T> resultCollection = new List<T>();
            for(int i = 0; i < count; i++)
            {
                if (leftPointer < leftCollection.Count && rightPointer < rightCollection.Count)
                {
                    if (Compare(leftCollection[leftPointer], rightCollection[rightPointer]) < 0)
                    {
                        resultCollection.Add(leftCollection[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        resultCollection.Add(rightCollection[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < rightCollection.Count)
                    {
                        resultCollection.Add(rightCollection[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        resultCollection.Add(leftCollection[leftPointer]);
                        leftPointer++;
                    }
                }
            }
            return resultCollection;
        }
    }
}
