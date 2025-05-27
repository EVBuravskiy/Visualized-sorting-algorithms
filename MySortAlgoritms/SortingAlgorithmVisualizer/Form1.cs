using ModelsLibrary;
using ModelsLibrary.DataStructure;
using ModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SortingAlgorithmVisualizer
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// List of elements
        /// </summary>
        private List<ViewElementsOfCollection> elements;

        /// <summary>
        /// Variable for pausing execution 
        /// </summary>
        private const int sleep = 50;

        /// <summary>
        /// Form constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            elements = new List<ViewElementsOfCollection>();
            AddTextBox.Focus();
        }

        /// <summary>
        /// Handling the event of clicking on the add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(AddTextBox.Text, out int value))
            {
                var element = new ViewElementsOfCollection(value, elements.Count);
                elements.Add(element);
            }
            RefreshElements();
            AddTextBox.Clear();
            AddTextBox.Focus();
        }

        /// <summary>
        /// Handling the event of clicking the fill button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillBotton_Click(object sender, EventArgs e)
        {
            if(int.TryParse(FillTextBox.Text, out int value))
            {
                Random random = new Random();
                for (int i = 0; i < value; i++)
                {
                    var element = new ViewElementsOfCollection(random.Next(1, 100), elements.Count);
                    elements.Add(element);
                }
                RefreshElements();
            }
            FillTextBox.Clear();
        }

        /// <summary>
        /// Draw elements
        /// </summary>
        /// <param name="elements"></param>
        private void DrawElements(List<ViewElementsOfCollection> elements)
        {
            foreach (ViewElementsOfCollection element in elements)
            {
                panel2.Controls.Add(element.VerticalProgressBar);
                panel2.Controls.Add(element.Label);
            }
            panel2.Refresh();
        }

        /// <summary>
        /// Refresh elements
        /// </summary>
        private void RefreshElements()
        {
            panel2.Controls.Clear();
            for (int i = 0; i < elements.Count; i++)
            {
                elements[i].Refresh();

            }
            DrawElements(elements);
        }

        /// <summary>
        /// Execute on button click
        /// </summary>
        /// <param name="algorithm"></param>
        private void ButtonClick(AlgorithmBaseClass<ViewElementsOfCollection> algorithm)
        {
            RefreshElements();

            algorithm.ComparisonEvent += AlgorithmCompareEvent;
            algorithm.SwapEvent += AlgorithmSwapEvent;
            algorithm.GetSortedElements += AlgorithmChangeElement;
            algorithm.SetPositionEvent += AlgorithmSetPositionEvent;
            TimeSpan time = algorithm.Sort();

            TimeLabel.Text = $"Время: {time.Seconds}";
            CompareLabel.Text = $"Количество сравнений: {algorithm.ComparisonCount}";
            SwapsLabel.Text = $"Количество обменов: {algorithm.SwapCount}";
            algorithm.ComparisonEvent -= AlgorithmCompareEvent;
            algorithm.SwapEvent -= AlgorithmSwapEvent;
            algorithm.GetSortedElements -= AlgorithmChangeElement;
            algorithm.SetPositionEvent -= AlgorithmSetPositionEvent;
        }


        /// <summary>
        /// Handling element rearrangement events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void AlgorithmSwapEvent(object sender, Tuple<ViewElementsOfCollection, ViewElementsOfCollection> tuple)
        {
            var temp = tuple.Item1.Number;
            tuple.Item1.SetPosition(tuple.Item2.Number);
            tuple.Item2.SetPosition(temp);
            tuple.Item1.SetColor(Color.Red);
            tuple.Item2.SetColor(Color.DarkRed);
            panel2.Refresh();

            Thread.Sleep(sleep);

            tuple.Item1.SetColor(Color.LightBlue);
            tuple.Item2.SetColor(Color.LightBlue);
            panel2.Refresh();

        }

        /// <summary>
        /// Handling Element Comparison Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void AlgorithmCompareEvent(object sender, Tuple<ViewElementsOfCollection, ViewElementsOfCollection> tuple)
        {
            tuple.Item1.SetColor(Color.Blue);
            tuple.Item2.SetColor(Color.DarkBlue);
            panel2.Refresh();

            Thread.Sleep(sleep);

            tuple.Item1.SetColor(Color.LightBlue);
            tuple.Item2.SetColor(Color.LightBlue);
            panel2.Refresh();
        }

        /// <summary>
        /// Handling events for receiving a collection of sorted elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="sortedElements"></param>
        private void AlgorithmChangeElement(object sender, List<ViewElementsOfCollection> sortedElements) 
        {
            for(int i = 0; i < elements.Count; i++)
            {
                ViewElementsOfCollection element = elements.Find(x => x.StartNumber == sortedElements[i].StartNumber);
                element.SetPosition(i);
            }
            panel2.Refresh();
        }

        /// <summary>
        /// Handling element position change events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="tuple"></param>
        private void AlgorithmSetPositionEvent(object sender, Tuple<int, ViewElementsOfCollection> tuple)
        {
            tuple.Item2.SetColor(Color.Red);
            panel2.Refresh();

            Thread.Sleep(sleep);

            tuple.Item2.SetPosition(tuple.Item1);
            panel2.Refresh();

            Thread.Sleep(sleep);

            tuple.Item2.SetColor(Color.LightBlue);
            panel2.Refresh();

            Thread.Sleep(sleep);
        }

        /// <summary>
        /// Handling the button click event of the bubble sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BubbleSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> bubble = new BubbleSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(bubble);
        }

        /// <summary>
        /// Handling the event of pressing the button of the shaker sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShakerSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> shaker = new ShakerSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(shaker);
        }

        /// <summary>
        /// Handling the button click event of the insertion sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> insert = new InsertSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(insert);
        }

        /// <summary>
        /// Handling the button click event of the Shell sorting algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShellSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> shell = new ShellSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(shell);
        }

        /// <summary>
        /// Handling the button click event of the tree sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //The customer did not like this visualization
        //private void TreeSortButton_Click(object sender, EventArgs e)
        //{
        //    AlgorithmBaseClass<ViewElementsOfCollection> tree = new BinaryTreeSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
        //    ButtonClick(tree);
        //}

        /// <summary>
        /// Handling the button click event of the tree sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> tree = new BTree<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(tree);
        }

        /// <summary>
        /// Handling the Heap Sort Algorithm Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeapSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> heap = new BinaryHeapSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(heap);
        }

        /// <summary>
        /// Handling the Selection Sort Algorithm Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> select = new SelectionSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(select);
        }

        /// <summary>
        /// Handling the button click event of the upgraded selection sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModernSelectSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> select = new ModernSelectionSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(select);
        }

        /// <summary>
        /// Handling the button click event of the gnome sorting algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GnomeSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> gnome = new GnomeSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(gnome);
        }

        /// <summary>
        /// Handling the button click event of the LSD radix sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LSDRadixSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> lsdRadix = new LSDRadixSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(lsdRadix);
        }

        /// <summary>
        /// Handling the button click event of the MSD radix sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSDRadixSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> msdRadix = new MSDRadixSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(msdRadix);
        }

        /// <summary>
        /// Handling the button click event of the merge sort algorithm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MergeSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> mergeSort = new MergeSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(mergeSort);
        }

        /// <summary>
        /// Handling the Quick Sort Algorithm Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuickSortButton_Click(object sender, EventArgs e)
        {
            AlgorithmBaseClass<ViewElementsOfCollection> quickSort = new QuickSortAlgorithm<ViewElementsOfCollection>(elements.ToList());
            ButtonClick(quickSort);
        }
    }
}
