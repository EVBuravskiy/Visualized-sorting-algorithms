using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelsLibrary;
using ModelsLibrary.DataStructure;
using ModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLibrary.Tests
{
    [TestClass()]
    public class SortTests
    {
        //Arrange
        Random random = new Random();
        List<int> Elements = new List<int>();
        List<int> SortedElements = new List<int>();
        int count = 10000;

        /// <summary>
        /// Initialize of collections before tests
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            Elements.Clear();

            ////Worst case
            //for (int i = count; i > 0; i--)
            //{
            //    Elements.Add(i);
            //}

            //Normal case
            for (int i = 0; i < count; i++)
            {
                Elements.Add(random.Next(1, count));
            }

            ////Best case
            //for (int i = 0; i < count; i++)
            //{
            //    Elements.Add(i);
            //}


            SortedElements.Clear();
            SortedElements.AddRange(Elements);
            SortedElements.Sort();
        }

        /// <summary>
        /// Base sort test
        /// </summary>
        [TestMethod()]
        public void BaseSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> baseSort = new AlgorithmBaseClass<int>();
            baseSort.Elements.AddRange(Elements);

            //Act
            baseSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, baseSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], baseSort.Elements[i]);
            }
        }

        /// <summary>
        /// Bubble sort test
        /// </summary>
        [TestMethod()]
        public void BubbleSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> bubbleSort = new BubbleSortAlgorithm<int>();
            bubbleSort.Elements.AddRange(Elements);

            //Act
            bubbleSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, bubbleSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], bubbleSort.Elements[i]);
            }
        }

        /// <summary>
        /// Shaker sort test
        /// </summary>
        [TestMethod()]
        public void ShakerSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> shakerSort = new ShakerSortAlgorithm<int>();
            shakerSort.Elements.AddRange(Elements);

            //Act
            shakerSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, shakerSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], shakerSort.Elements[i]);
            }
        }

        /// <summary>
        /// Insert sort test
        /// </summary>
        [TestMethod()]
        public void InsertSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> insertSort = new InsertSortAlgorithm<int>();
            insertSort.Elements.AddRange(Elements);

            //Act
            insertSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, insertSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], insertSort.Elements[i]);
            }
        }

        /// <summary>
        /// Shall sort test
        /// </summary>
        [TestMethod()]
        public void ShallSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> shellSort = new ShellSortAlgorithm<int>();
            shellSort.Elements.AddRange(Elements);

            //Act
            shellSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, shellSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], shellSort.Elements[i]);
            }
        }


        /// <summary>
        /// Tree sort test
        /// </summary>
        [TestMethod()]
        public void BinaryTreeSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> BinaryTreeSort = new BinaryTreeSortAlgorithm<int>();
            BinaryTreeSort.Elements.AddRange(Elements);

            //Act
            BinaryTreeSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, BinaryTreeSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], BinaryTreeSort.Elements[i]);
            }
        }

        /// <summary>
        /// Binary heap sort test
        /// </summary>
        [TestMethod()]
        public void BinaryHeapSortTest()
        {
            //Arrange
            //AlgorithmBaseClass<int> binaryHeapSort = new BinaryHeapSortAlgorithm<int>();
            //binaryHeapSort.Elements.AddRange(Elements);

            AlgorithmBaseClass<int> binaryHeapSort = new BinaryHeapSortAlgorithm<int>(Elements);


            //Act
            binaryHeapSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, binaryHeapSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], binaryHeapSort.Elements[i]);
            }
        }

        /// <summary>
        /// Selection sort test
        /// </summary>
        [TestMethod()]
        public void SelectionSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> SelectionSort = new SelectionSortAlgorithm<int>();
            SelectionSort.Elements.AddRange(Elements);

            //Act
            SelectionSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, SelectionSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], SelectionSort.Elements[i]);
            }
        }

        /// <summary>
        /// Modern Selection sort test
        /// </summary>
        [TestMethod()]
        public void ModernSelectionSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> modernSelectionSort = new ModernSelectionSortAlgorithm<int>();
            modernSelectionSort.Elements.AddRange(Elements);

            //Act
            modernSelectionSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, modernSelectionSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], modernSelectionSort.Elements[i]);
            }
        }

        /// <summary>
        /// Gnome sort test
        /// </summary>
        [TestMethod()]
        public void GnomeSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> gnomeSort = new GnomeSortAlgorithm<int>();
            gnomeSort.Elements.AddRange(Elements);

            //Act
            gnomeSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, gnomeSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], gnomeSort.Elements[i]);
            }
        }

        /// <summary>
        /// Tree sort test
        /// </summary>
        [TestMethod()]
        public void BTreeSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> BTreeSort = new BTree<int>(Elements);
            
            //Act
            BTreeSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, BTreeSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], BTreeSort.Elements[i]);
            }
        }

        /// <summary>
        /// LSD Radix sort test
        /// </summary>
        [TestMethod()]
        public void LSDRadixSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> lsdRadixSort = new LSDRadixSortAlgorithm<int>(Elements);

            //Act
            lsdRadixSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, lsdRadixSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], lsdRadixSort.Elements[i]);
            }
        }

        /// <summary>
        /// MSD Radix sort test
        /// </summary>
        [TestMethod()]
        public void MSDRadixSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> msdRadixSort = new MSDRadixSortAlgorithm<int>(Elements);

            //Act
            msdRadixSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, msdRadixSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], msdRadixSort.Elements[i]);
            }
        }

        /// <summary>
        /// Merge sort test
        /// </summary>
        [TestMethod()]
        public void MergeSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> mergeSort = new MergeSortAlgorithm<int>(Elements);

            //Act
            mergeSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, mergeSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], mergeSort.Elements[i]);
            }
        }

        /// <summary>
        /// Quick sort test
        /// </summary>
        [TestMethod()]
        public void QuickSortTest()
        {
            //Arrange
            AlgorithmBaseClass<int> quickSort = new QuickSortAlgorithm<int>(Elements);

            //Act
            quickSort.Sort();

            //Assert
            Assert.AreEqual(SortedElements.Count, quickSort.Elements.Count);
            for (int i = 0; i < SortedElements.Count; i++)
            {
                Assert.AreEqual(SortedElements[i], quickSort.Elements[i]);
            }
        }
    }
}