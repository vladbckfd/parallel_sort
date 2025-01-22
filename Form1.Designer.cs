namespace Topilskiy_Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            originalNumberListBox = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            bubleSortListBox = new ListBox();
            bubleSortLabel = new Label();
            insertionSortListBox = new ListBox();
            insertionSortLabel = new Label();
            countingSortListBox = new ListBox();
            countingSortLabel = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(7, 230);
            button1.Name = "button1";
            button1.Size = new Size(127, 54);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать и отсортировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            originalNumberListBox.FormattingEnabled = true;
            originalNumberListBox.ItemHeight = 15;
            originalNumberListBox.Location = new Point(143, 44);
            originalNumberListBox.Name = "listBox1";
            originalNumberListBox.Size = new Size(52, 604);
            originalNumberListBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 125);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Размер массива";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(35, 172);
            numericUpDown1.Maximum = new decimal(new int[] { 2147483640, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(99, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(35, 201);
            numericUpDown2.Maximum = new decimal(new int[] { 2147483640, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(99, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 180);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 6;
            label2.Text = "От";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 209);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 7;
            label3.Text = "До";
            // 
            // listBox2
            // 
            bubleSortListBox.FormattingEnabled = true;
            bubleSortListBox.ItemHeight = 15;
            bubleSortListBox.Location = new Point(306, 45);
            bubleSortListBox.Name = "listBox2";
            bubleSortListBox.Size = new Size(52, 604);
            bubleSortListBox.TabIndex = 8;
            // 
            // label4
            // 
            bubleSortLabel.AutoSize = true;
            bubleSortLabel.Location = new Point(363, 44);
            bubleSortLabel.Name = "label4";
            bubleSortLabel.Size = new Size(204, 15);
            bubleSortLabel.TabIndex = 9;
            bubleSortLabel.Text = "Сортировка пузырьком завершена!";
            bubleSortLabel.Visible = false;
            // 
            // listBox3
            // 
            insertionSortListBox.FormattingEnabled = true;
            insertionSortListBox.ItemHeight = 15;
            insertionSortListBox.Location = new Point(573, 44);
            insertionSortListBox.Name = "listBox3";
            insertionSortListBox.Size = new Size(52, 604);
            insertionSortListBox.TabIndex = 12;
            // 
            // label5
            // 
            insertionSortLabel.AutoSize = true;
            insertionSortLabel.Location = new Point(631, 45);
            insertionSortLabel.Name = "label5";
            insertionSortLabel.Size = new Size(199, 15);
            insertionSortLabel.TabIndex = 14;
            insertionSortLabel.Text = "Сортировка вставками завершена!";
            insertionSortLabel.Visible = false;
            // 
            // listBox4
            // 
            countingSortListBox.FormattingEnabled = true;
            countingSortListBox.ItemHeight = 15;
            countingSortListBox.Location = new Point(836, 45);
            countingSortListBox.Name = "listBox4";
            countingSortListBox.Size = new Size(52, 604);
            countingSortListBox.TabIndex = 15;
            // 
            // label6
            // 
            countingSortLabel.AutoSize = true;
            countingSortLabel.Location = new Point(891, 45);
            countingSortLabel.Name = "label6";
            countingSortLabel.Size = new Size(136, 15);
            countingSortLabel.TabIndex = 16;
            countingSortLabel.Text = "Сортировка подсчётом";
            countingSortLabel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 24);
            label7.Name = "label7";
            label7.Size = new Size(162, 15);
            label7.TabIndex = 18;
            label7.Text = "Сгенерированные значения";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 655);
            Controls.Add(label7);
            Controls.Add(countingSortLabel);
            Controls.Add(countingSortListBox);
            Controls.Add(insertionSortLabel);
            Controls.Add(insertionSortListBox);
            Controls.Add(bubleSortLabel);
            Controls.Add(bubleSortListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(originalNumberListBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Параллельная сортировка разными алгоритмами";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox originalNumberListBox;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label2;
        private Label label3;
        private ListBox bubleSortListBox;
        private Label bubleSortLabel;
        private ListBox insertionSortListBox;
        private Label insertionSortLabel;
        private ListBox countingSortListBox;
        private Label countingSortLabel;
        private Label label7;
    }
}
