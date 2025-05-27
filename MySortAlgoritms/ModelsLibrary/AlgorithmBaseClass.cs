using System.Diagnostics;
using System.Globalization;

namespace ModelsLibrary
{
    /// <summary>
    /// Base class for algorithms
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AlgorithmBaseClass<T> where T : IComparable
    {
        /// <summary>
        /// Collection of elements
        /// </summary>
        public List<T> Elements { get; set; }

        /// <summary>
        /// Swap counter
        /// </summary>
        public int SwapCount { get; protected set; }

        /// <summary>
        /// Iteration counter
        /// </summary>
        public int ComparisonCount { get; protected set; }

        /// <summary>
        /// Event of comparing elements in a collection of elements
        /// </summary>
        public virtual event EventHandler<Tuple<T, T>> ComparisonEvent;

        /// <summary>
        /// Event of exchanging elements in a collection of elements
        /// </summary>
        public virtual event EventHandler<Tuple<T, T>> SwapEvent;

        /// <summary>
        /// Event of getting a collection of sorted elements
        /// </summary>
        public virtual event EventHandler<List<T>> GetSortedElements;

        /// <summary>
        /// Event of changing the position of elements in a collection
        /// </summary>
        public event EventHandler<Tuple<int, T>> SetPositionEvent;

        /// <summary>
        /// Base class constructor
        /// </summary>
        public AlgorithmBaseClass()
        {
            Elements = new List<T>();
            SwapCount = 0;
            ComparisonCount = 0;
        }

        /// <summary>
        /// Base class constructor that accepts a collection
        /// </summary>
        /// <param name="elements"></param>
        public AlgorithmBaseClass(IEnumerable<T> elements) : base()
        {
            Elements = new List<T>();
            SwapCount = 0;
            ComparisonCount = 0;
            Elements.AddRange(elements);
        }

        /// <summary>
        /// Swap the items in the collection
        /// </summary>
        /// <param name="firstPosition"></param>
        /// <param name="secondPosition"></param>
        protected void Swap(int firstPosition, int secondPosition)
        {
            if (firstPosition < Elements.Count && secondPosition < Elements.Count)
            {
                var temp = Elements[firstPosition];
                Elements[firstPosition] = Elements[secondPosition];
                Elements[secondPosition] = temp;
                Tuple<T, T> swapElements = new Tuple<T, T>(Elements[firstPosition], Elements[secondPosition]);
                SwapEvent?.Invoke(this, swapElements);
                SwapCount++;
            }
        }

        /// <summary>
        /// Set element position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="element"></param>
        protected void SetPosition(int position, T element)
        {
            if(position < Elements.Count)
            {
                SetPositionEvent?.Invoke(this, new Tuple<int, T>(position, element));
                Elements[position] = element;
            }
        }

        /// <summary>
        /// Measure the time it takes to complete the sorting
        /// </summary>
        public TimeSpan Sort()
        {
            Stopwatch timer = new Stopwatch();
            SwapCount = 0;
            ComparisonCount = 0;
            timer.Start();
            MakeSort();
            timer.Stop();
            return timer.Elapsed;
        }

        /// <summary>
        /// Virtual Sort the collection
        /// </summary>
        protected virtual void MakeSort()
        {
            Elements.Sort();
        }

        /// <summary>
        /// Create an element comparison event for child classes
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        /// <returns></returns>
        protected int Compare(T firstElement, T secondElement)
        {
            Tuple<T, T> compareElements = new Tuple<T, T>(firstElement, secondElement);
            ComparisonEvent?.Invoke(this, compareElements);
            ComparisonCount++;
            return firstElement.CompareTo(secondElement);
        }

        /// <summary>
        /// Create an event to get a collection of sorted items for child classes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sortedElements"></param>
        protected void Algorithm_GetSortedElements(object sender, List<T> sortedElements)
        {
            GetSortedElements?.Invoke(this, sortedElements);
        }
    }
}