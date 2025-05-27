namespace SortingAlgorithmVisualizer
{
    /// <summary>
    /// Class for displaying elements in a form 
    /// </summary>
    public class ViewElementsOfCollection : IComparable
    {
        /// <summary>
        /// VerticalProgressBar
        /// </summary>
        public VerticalProgressBar VerticalProgressBar { get; private set; }

        /// <summary>
        /// Label
        /// </summary>
        public Label Label { get; private set; }

        /// <summary>
        /// Value of element
        /// </summary>
        public int Value { get; private set; }


        /// <summary>
        /// Element position
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// Starting position of the element
        /// </summary>
        public int StartNumber { get; private set; }

        /// <summary>
        /// Constructor of the class for displaying elements in a form
        /// </summary>
        /// <param name="value"></param>
        /// <param name="number"></param>
        public ViewElementsOfCollection(int value, int number)
        {

            Value = value;
            Number = number;
            StartNumber = number;

            VerticalProgressBar = new VerticalProgressBar();
            Label = new Label();

            int x = Number * 20;

            // 
            // VerticalProgressBar
            // 
            VerticalProgressBar.BorderStyle = SortingAlgorithmVisualizer.BorderStyles.Classic;
            VerticalProgressBar.Color = System.Drawing.Color.LightBlue;
            VerticalProgressBar.Location = new System.Drawing.Point(x, 3);
            VerticalProgressBar.Maximum = 100;
            VerticalProgressBar.Minimum = 0;
            VerticalProgressBar.Name = "VerticalProgressBar" + Number;
            VerticalProgressBar.Size = new System.Drawing.Size(19, 100);
            VerticalProgressBar.Step = Number;
            VerticalProgressBar.Style = SortingAlgorithmVisualizer.Styles.Solid;
            VerticalProgressBar.TabIndex = 0;
            VerticalProgressBar.Value = Value;

            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, 106);
            Label.Name = "ProgressBarLabel" + Number;
            Label.Size = new System.Drawing.Size(19, 15);
            Label.TabIndex = Number;
            Label.Text = Value.ToString();
            Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// Compare class instances
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object? obj)
        {
            if (obj is ViewElementsOfCollection element)
            {
                return Value.CompareTo(element.Value);
            }
            throw new ArgumentException($"Object is not {nameof(ViewElementsOfCollection)}", nameof(obj));
        }

        /// <summary>
        /// Swap elements
        /// </summary>
        /// <param name="firstElement"></param>
        /// <param name="secondElement"></param>
        public void SetPosition (int number)
        {
            Number = number;
            var x = Number * 20;
            VerticalProgressBar.Location = new System.Drawing.Point(x, 3);
            VerticalProgressBar.Name = "VerticalProgressBar" + Number;
            VerticalProgressBar.Step = Number;

            Label.Location = new System.Drawing.Point(x, 106);
            Label.Name = "ProgressBarLabel" + Number;
            Label.TabIndex = Number;
        }

        /// <summary>
        /// Set color for swapped elements
        /// </summary>
        /// <param name="color"></param>
        public void SetColor(Color color)
        {
            VerticalProgressBar.Color = color;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        /// <summary>
        /// Restore positions of elements after sorting
        /// </summary>
        public void Refresh()
        {
            Number = StartNumber;
            var x = Number * 20;
            VerticalProgressBar.Location = new System.Drawing.Point(x, 3);
            VerticalProgressBar.Name = "VerticalProgressBar" + Number;
            VerticalProgressBar.Step = Number;

            Label.Location = new System.Drawing.Point(x, 106);
            Label.Name = "ProgressBarLabel" + Number;
            Label.TabIndex = Number;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Value;
        }
    }
}
