namespace SortingAlgorithmVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FillBotton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CompareLabel = new System.Windows.Forms.Label();
            this.SwapsLabel = new System.Windows.Forms.Label();
            this.ShakerSortButton = new System.Windows.Forms.Button();
            this.InsertSortButton = new System.Windows.Forms.Button();
            this.ShallSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.SelectSortButton = new System.Windows.Forms.Button();
            this.ModernSelectSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.LSDRadixSort = new System.Windows.Forms.Button();
            this.MSDRadixSortButton = new System.Windows.Forms.Button();
            this.MergeSortButton = new System.Windows.Forms.Button();
            this.QuickSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FillBotton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.FillTextBox);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 133);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Для рандомной коллекции введите ее размер";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить число";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FillBotton
            // 
            this.FillBotton.Location = new System.Drawing.Point(208, 80);
            this.FillBotton.Name = "FillBotton";
            this.FillBotton.Size = new System.Drawing.Size(74, 23);
            this.FillBotton.TabIndex = 1;
            this.FillBotton.Text = "Заполнить";
            this.FillBotton.UseVisualStyleBackColor = true;
            this.FillBotton.Click += new System.EventHandler(this.FillBotton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(208, 23);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(3, 80);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(199, 23);
            this.FillTextBox.TabIndex = 0;
            this.FillTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(3, 23);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(199, 23);
            this.AddTextBox.TabIndex = 0;
            this.AddTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(302, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 133);
            this.panel2.TabIndex = 1;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(5, 139);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(160, 23);
            this.BubbleSortButton.TabIndex = 2;
            this.BubbleSortButton.Text = "Сортировка пузырьком";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(184, 143);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 15);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Время:";
            // 
            // CompareLabel
            // 
            this.CompareLabel.AutoSize = true;
            this.CompareLabel.Location = new System.Drawing.Point(184, 170);
            this.CompareLabel.Name = "CompareLabel";
            this.CompareLabel.Size = new System.Drawing.Size(137, 15);
            this.CompareLabel.TabIndex = 3;
            this.CompareLabel.Text = "Количество сравнений:";
            // 
            // SwapsLabel
            // 
            this.SwapsLabel.AutoSize = true;
            this.SwapsLabel.Location = new System.Drawing.Point(184, 199);
            this.SwapsLabel.Name = "SwapsLabel";
            this.SwapsLabel.Size = new System.Drawing.Size(127, 15);
            this.SwapsLabel.TabIndex = 3;
            this.SwapsLabel.Text = "Количество обменов:";
            // 
            // ShakerSortButton
            // 
            this.ShakerSortButton.Location = new System.Drawing.Point(5, 166);
            this.ShakerSortButton.Name = "ShakerSortButton";
            this.ShakerSortButton.Size = new System.Drawing.Size(160, 23);
            this.ShakerSortButton.TabIndex = 2;
            this.ShakerSortButton.Text = "Шейкерная сортировка";
            this.ShakerSortButton.UseVisualStyleBackColor = true;
            this.ShakerSortButton.Click += new System.EventHandler(this.ShakerSortButton_Click);
            // 
            // InsertSortButton
            // 
            this.InsertSortButton.Location = new System.Drawing.Point(5, 195);
            this.InsertSortButton.Name = "InsertSortButton";
            this.InsertSortButton.Size = new System.Drawing.Size(160, 23);
            this.InsertSortButton.TabIndex = 2;
            this.InsertSortButton.Text = "Сортировка вставками";
            this.InsertSortButton.UseVisualStyleBackColor = true;
            this.InsertSortButton.Click += new System.EventHandler(this.InsertSortButton_Click);
            // 
            // ShallSortButton
            // 
            this.ShallSortButton.Location = new System.Drawing.Point(8, 311);
            this.ShallSortButton.Name = "ShallSortButton";
            this.ShallSortButton.Size = new System.Drawing.Size(160, 23);
            this.ShallSortButton.TabIndex = 2;
            this.ShallSortButton.Text = "Сортировка Шелла";
            this.ShallSortButton.UseVisualStyleBackColor = true;
            this.ShallSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(5, 340);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(160, 23);
            this.TreeSortButton.TabIndex = 2;
            this.TreeSortButton.Text = "Сортировка деревом";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(5, 369);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(160, 23);
            this.HeapSortButton.TabIndex = 2;
            this.HeapSortButton.Text = "Сортировка кучей";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // SelectSortButton
            // 
            this.SelectSortButton.Location = new System.Drawing.Point(5, 224);
            this.SelectSortButton.Name = "SelectSortButton";
            this.SelectSortButton.Size = new System.Drawing.Size(160, 23);
            this.SelectSortButton.TabIndex = 2;
            this.SelectSortButton.Text = "Сортировка выбором";
            this.SelectSortButton.UseVisualStyleBackColor = true;
            this.SelectSortButton.Click += new System.EventHandler(this.SelectSortButton_Click);
            // 
            // ModernSelectSortButton
            // 
            this.ModernSelectSortButton.Location = new System.Drawing.Point(5, 253);
            this.ModernSelectSortButton.Name = "ModernSelectSortButton";
            this.ModernSelectSortButton.Size = new System.Drawing.Size(160, 23);
            this.ModernSelectSortButton.TabIndex = 2;
            this.ModernSelectSortButton.Text = "Сортировка выбором 2";
            this.ModernSelectSortButton.UseVisualStyleBackColor = true;
            this.ModernSelectSortButton.Click += new System.EventHandler(this.ModernSelectSortButton_Click);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(5, 282);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(160, 23);
            this.GnomeSortButton.TabIndex = 2;
            this.GnomeSortButton.Text = "Гномья сортировка";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomeSortButton_Click);
            // 
            // LSDRadixSort
            // 
            this.LSDRadixSort.Location = new System.Drawing.Point(8, 398);
            this.LSDRadixSort.Name = "LSDRadixSort";
            this.LSDRadixSort.Size = new System.Drawing.Size(160, 23);
            this.LSDRadixSort.TabIndex = 2;
            this.LSDRadixSort.Text = "LSD сортировка";
            this.LSDRadixSort.UseVisualStyleBackColor = true;
            this.LSDRadixSort.Click += new System.EventHandler(this.LSDRadixSortButton_Click);
            // 
            // MSDRadixSortButton
            // 
            this.MSDRadixSortButton.Location = new System.Drawing.Point(8, 427);
            this.MSDRadixSortButton.Name = "MSDRadixSortButton";
            this.MSDRadixSortButton.Size = new System.Drawing.Size(160, 23);
            this.MSDRadixSortButton.TabIndex = 2;
            this.MSDRadixSortButton.Text = "MSD сортировка";
            this.MSDRadixSortButton.UseVisualStyleBackColor = true;
            this.MSDRadixSortButton.Click += new System.EventHandler(this.MSDRadixSortButton_Click);
            // 
            // MergeSortButton
            // 
            this.MergeSortButton.Location = new System.Drawing.Point(5, 456);
            this.MergeSortButton.Name = "MergeSortButton";
            this.MergeSortButton.Size = new System.Drawing.Size(160, 23);
            this.MergeSortButton.TabIndex = 2;
            this.MergeSortButton.Text = "Сортировка слиянием";
            this.MergeSortButton.UseVisualStyleBackColor = true;
            this.MergeSortButton.Click += new System.EventHandler(this.MergeSortButton_Click);
            // 
            // QuickSortButton
            // 
            this.QuickSortButton.Location = new System.Drawing.Point(5, 485);
            this.QuickSortButton.Name = "QuickSortButton";
            this.QuickSortButton.Size = new System.Drawing.Size(160, 23);
            this.QuickSortButton.TabIndex = 2;
            this.QuickSortButton.Text = "Быстрая сортировка";
            this.QuickSortButton.UseVisualStyleBackColor = true;
            this.QuickSortButton.Click += new System.EventHandler(this.QuickSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 631);
            this.Controls.Add(this.SwapsLabel);
            this.Controls.Add(this.CompareLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.QuickSortButton);
            this.Controls.Add(this.MergeSortButton);
            this.Controls.Add(this.MSDRadixSortButton);
            this.Controls.Add(this.LSDRadixSort);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.ShallSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.ModernSelectSortButton);
            this.Controls.Add(this.SelectSortButton);
            this.Controls.Add(this.InsertSortButton);
            this.Controls.Add(this.ShakerSortButton);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button FillBotton;
        private Button AddButton;
        private TextBox FillTextBox;
        private TextBox AddTextBox;
        private Panel panel2;
        private Button BubbleSortButton;
        private Label TimeLabel;
        private Label CompareLabel;
        private Label SwapsLabel;
        private Button ShakerSortButton;
        private Button InsertSortButton;
        private Button ShallSortButton;
        private Button TreeSortButton;
        private Button HeapSortButton;
        private Button SelectSortButton;
        private Button ModernSelectSortButton;
        private Button GnomeSortButton;
        private Button LSDRadixSort;
        private Button MSDRadixSortButton;
        private Button MergeSortButton;
        private Button QuickSortButton;
    }
}