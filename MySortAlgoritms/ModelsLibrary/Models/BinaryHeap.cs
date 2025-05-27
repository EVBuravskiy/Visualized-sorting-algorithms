namespace ModelsLibrary.Models
{
    /// <summary>
    /// List-based binary heap class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryHeap<T> where T : IComparable
    {
        /// <summary>
        /// List of elements of a binary heap
        /// </summary>
        private List<T> binaryHeap { get; set; }

        /// <summary>
        /// Number of elements in a binary heap
        /// </summary>
        private int Count => binaryHeap.Count;


        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public event EventHandler<Tuple<T, T>> ComparisonEvent;

        /// <summary>
        /// Event of exchanging elements in a collection of elements
        /// </summary>
        public event EventHandler<Tuple<T, T>> SwapEvent;

        /// <summary>
        /// Event of getting a collection of sorted elements
        /// </summary>
        public event EventHandler<List<T>> ChangeSortedElements;

        /// <summary>
        /// Default Binary Heap Constructor
        /// </summary>
        public BinaryHeap()
        {
            binaryHeap = new List<T>();
        }

        /// <summary>
        /// Binary Heap Constructor with Element Collection Construction
        /// </summary>
        /// <param name="inputElements"></param>
        public BinaryHeap(IEnumerable<T> inputElements) : this()
        {
            PushElements(inputElements);
        }

        /// <summary>
        /// Extract the root element from a binary heap
        /// </summary>
        /// <returns> element </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public T PeekElement()
        {
            if (Count > 0)
            {
                return binaryHeap[0];
            }
            throw new ArgumentNullException(nameof(binaryHeap), "BinaryHeap is empty");
        }

        /// <summary>
        /// Add elements from a collection to a binary heap
        /// </summary>
        /// <param name="inputElements"></param>
        public void PushElements(IEnumerable<T> inputElements)
        {
            foreach(T element in inputElements)
            {
                PushElement(element);
            }
            ChangeSortedElements?.Invoke(this, binaryHeap);
        }

        /// <summary>
        /// Put an element into a binary heap
        /// </summary>
        /// <param name="element"></param>
        public void PushElement(T element)
        {
            binaryHeap.Add(element);
            int currentIndex = Count - 1;
            int parentIndex = GetParentIndex(currentIndex);
            while (currentIndex > 0 && Compare(binaryHeap[parentIndex], binaryHeap[currentIndex]) > 0)
            {
                SwapElements(currentIndex, parentIndex);
                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        /// <summary>
        /// Get parent index
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <returns>int index</returns>
        private int GetParentIndex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        /// <summary>
        /// Rearrange elements in a binary heap
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <param name="parentIndex"></param>
        private void SwapElements(int parentIndex, int currentIndex)
        {
            T tempElement = binaryHeap[currentIndex];
            binaryHeap[currentIndex] = binaryHeap[parentIndex];
            binaryHeap[parentIndex] = tempElement;
            Tuple<T, T> swapElements = new Tuple<T, T>(binaryHeap[parentIndex], binaryHeap[currentIndex]);
            SwapEvent?.Invoke(this, swapElements);
        }

        /// <summary>
        /// Extract the root element from a binary heap
        /// </summary>
        /// <returns>root element</returns>
        public T PopElement()
        {
            T element = default(T);
            if (Count > 0)
            {
                element = binaryHeap[0];
                binaryHeap[0] = binaryHeap[Count - 1];
                binaryHeap.RemoveAt(Count - 1);
                Balance(0);
            }
            return element;
        }

        /// <summary>
        /// Get a list of sorted elements
        /// </summary>
        /// <returns>List of sorted elements</returns>
        public List<T> GetSortedElements()
        {
            List<T> sortedElements = new List<T>();
            List<T> tempElements = new List<T>();

            while (Count > 0)
            {
                sortedElements.Clear();
                T element = PopElement();
                tempElements.Add(element);
                sortedElements.AddRange(binaryHeap);
                sortedElements.AddRange(tempElements);
                ChangeSortedElements?.Invoke(this, sortedElements);
            }
            return sortedElements;
        }

        /// <summary>
        /// Binary Heap Balancing
        /// </summary>
        /// <param name="inputIndex"></param>
        private void Balance(int inputIndex)
        {
            int currentIndex = inputIndex;
            int leftIndex;
            int rightIndex;
            while (inputIndex <= Count)
            {
                leftIndex = currentIndex * 2 + 1;
                rightIndex = currentIndex * 2 + 2;
                if (leftIndex < Count && Compare(binaryHeap[currentIndex], binaryHeap[leftIndex]) > 0)
                {
                    currentIndex = leftIndex;
                }
                if (rightIndex < Count && Compare(binaryHeap[currentIndex], binaryHeap[rightIndex]) > 0)
                {
                    currentIndex = rightIndex;
                }
                if (inputIndex == currentIndex)
                {
                    break;
                }
                SwapElements(inputIndex, currentIndex);
                inputIndex = currentIndex;
            }
        }

        /// <summary>
        /// Create comparison event
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns>int result compare of elements</returns>
        protected int Compare(T firstElement, T secondElement)
        {
            Tuple<T, T> compareElements = new Tuple<T, T>(firstElement, secondElement);
            ComparisonEvent?.Invoke(this, compareElements);
            return firstElement.CompareTo(secondElement);
        }
    }
}


