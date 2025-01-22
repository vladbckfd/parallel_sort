using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Topilskiy_Task1
{
    public partial class Form1 : Form
    {
        List<int>? numbers = null;

        public Form1()
        {
            InitializeComponent();
            AddButtonListener();
        }

        private void AddButtonListener()
        {
            button1.Click += Button1_Click;
        }

        // Генерация чисел и запуск сортировок.
        private void Button1_Click(object? sender, EventArgs e)
        {
            // Определение размера массива и диапазона чисел
            int minBound = (int)numericUpDown1.Value;
            int maxBound = (int)numericUpDown2.Value;
            String sizeStr = this.textBox1.Text;
            int size;
            bool parseResult = Int32.TryParse(sizeStr, out size);
            if (!parseResult)
            {
                MessageBox.Show("Ошибка! Введён неправильный размер масива.");
                return;
            }
            if (size <= 0)
            {
                MessageBox.Show("Ошибка! Введённый размер массива меньше или равен нулю.");
                return;
            }
            if (minBound > maxBound)
            {
                MessageBox.Show("Ошибка! Введённый неверный диапазон чисел.");
                return;
            }

            // Очищиаем ListBox от предыдущих значений
            originalNumberListBox.DataSource = null;
            originalNumberListBox.Items.Clear();

            // Скрытие сообщений об окончании прошлой сортировки
            bubleSortLabel.Invoke(new Action(() => bubleSortLabel.Visible = false));
            insertionSortLabel.Invoke(new Action(() => insertionSortLabel.Visible = false));
            countingSortLabel.Invoke(new Action(() => countingSortLabel.Visible = false));

            // Генерация массива
            numbers = new List<int>(size);
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int n = random.Next(minBound, maxBound);
                numbers.Add(n);
            }

            // Вывод массива в ListBox
            originalNumberListBox.Invoke(new Action(() =>
            {
                originalNumberListBox.DataSource = numbers;
            }));

            // Запуск сортировок
            BubleSort();
            InsertionSort();
            CountingSort();
        }

        //Сортировка пузырьком
        private void BubleSort()
        {
            // Определение делегата сортировки
            Task bubleSort = new Task(() =>
            {
                // Очищение ListBox от предыдущих значений
                bubleSortListBox.DataSource = null;
                bubleSortListBox.Invoke(new Action(() => bubleSortListBox.Items.Clear()));

                // Создание нового массива, чтобы в него скопировать сгенерированные числа и в нём совершить сортировку
                int[] sortedArray = new int[numbers?.Count ?? 0];
                numbers?.CopyTo(sortedArray);

                // Включение секундомера
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Переменные для подсчёта количества сравнений и перестановок
                long compareCount = 0;
                long moveCount = 0;

                // Непосредственно сортировка
                int n = sortedArray.Length;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        compareCount++;
                        if (sortedArray[j] > sortedArray[j + 1])
                        {
                            int tempVar = sortedArray[j];
                            sortedArray[j] = sortedArray[j + 1];
                            sortedArray[j + 1] = tempVar;
                            moveCount++;
                        }
                    }
                }

                // Остановка секундомера
                stopwatch.Stop();

                // Вывод сообщения о завершении сортировки и собранных показателях
                bubleSortLabel.Invoke(new Action(() =>
                {
                    bubleSortLabel.Text = "Сортировка пузырьком завершена!\n" +
                    "Кол-во сравнений: " + compareCount + ". \n" +
                    "Кол-во перестановок: " + moveCount + ". \n" +
                    "Затрачено времени: " + stopwatch.ElapsedMilliseconds + " мс.";
                    bubleSortLabel.Visible = true;
                }));

                // Вывод отсортированного массива
                bubleSortListBox.Invoke(new Action(() => bubleSortListBox.DataSource = sortedArray));
            });

            // Запуск сортировки
            bubleSort.Start();
        }

        // Сортировка вставкой
        private void InsertionSort()
        {
            // Определение делегата сортировки
            Task insertionSort = new Task(() =>
            {
                // Очищение ListBox от предыдущих значений
                insertionSortListBox.DataSource = null;
                insertionSortListBox.Invoke(new Action(() => insertionSortListBox.Items.Clear()));

                // Создание нового массива, чтобы в него скопировать сгенерированные числа и в нём совершить сортировку
                int[] sortedArray = new int[numbers?.Count ?? 0];
                numbers?.CopyTo(sortedArray);

                // Включение секундомера
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Переменные для подсчёта количества сравнений и перестановок
                long compareCount = 0;
                long moveCount = 0;

                // Непосредственно сортировка
                for (int i = 1; i < sortedArray.Length; i++)
                {
                    int current = sortedArray[i];
                    bool flag = false;

                    for (int j = i - 1; j >= 0 && !flag;)
                    {
                        compareCount++;
                        if (current < sortedArray[j])
                        {
                            sortedArray[j + 1] = sortedArray[j];
                            j--;
                            sortedArray[j + 1] = current;
                            moveCount++;
                        }
                        else flag = true;
                    }
                }

                // Остановка секундомера
                stopwatch.Stop();

                // Вывод сообщения о завершении сортировки и собранных показателях
                insertionSortLabel.Invoke(new Action(() =>
                {
                    insertionSortLabel.Text = "Сортировка вставками завершена!\n" +
                    "Кол-во сравнений: " + compareCount + ". \n" +
                    "Кол-во перестановок: " + moveCount + ". \n" +
                    "Затрачено времени: " + stopwatch.ElapsedMilliseconds + " мс.";
                    insertionSortLabel.Visible = true;
                }));
                
                // Вывод отсортированного массива
                insertionSortListBox.Invoke(new Action(() => insertionSortListBox.DataSource = sortedArray));
            });

            // Запуск сортировки
            insertionSort.Start();
        }

        //Сортировка подсчётом
        private void CountingSort()
        {
            // Определение делегата сортировки
            Task countingSort = new Task(() =>
            {
                // Очищение ListBox от предыдущих значений
                countingSortListBox.DataSource = null;
                countingSortListBox.Invoke(new Action(() => countingSortListBox.Items.Clear()));

                // Создание нового массива, чтобы в него скопировать сгенерированные числа и в нём совершить сортировку
                int[] sortedArray = new int[numbers?.Count ?? 0];
                numbers?.CopyTo(sortedArray);

                // Включение секундомера
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                // Переменные для подсчёта количества сравнений и перестановок
                long compareCount = 0;
                long moveCount = 0;
               
                // Вспомогательные переменные для сортировки
                int size = sortedArray.Length;
                int maxElement = FindMaxVal(sortedArray, size);
                int[] occurrences = new int[maxElement + 1];

                // Зануление вспомогательного массива
                for (int i = 0; i < maxElement + 1; i++)
                {
                    occurrences[i] = 0;
                }

                // Подсчёт всех вхождений в массив
                for (int i = 0; i < size; i++)
                {
                    occurrences[sortedArray[i]]++;
                    moveCount++;
                }

                // Выстраивание массива в отсортированном виде
                for (int i = 0, j = 0; i <= maxElement; i++)
                {
                    compareCount++;
                    while (occurrences[i] > 0)
                    {
                        sortedArray[j] = i;
                        j++;
                        occurrences[i]--;
                        moveCount++;
                    }
                }

                // Остановка секундомера
                stopwatch.Stop();

                // Вывод сообщения о завершении сортировки и собранных показателях
                countingSortLabel.Invoke(new Action(() =>
                {
                    countingSortLabel.Text = "Сортировка подсчётом завершена!\n" +
                    "Кол-во сравнений: " + compareCount + ". \n" +
                    "Кол-во перестановок: " + moveCount + ". \n" +
                    "Затрачено времени: " + stopwatch.ElapsedMilliseconds + " мс.";
                    countingSortLabel.Visible = true;
                }));

                // Вывод отсортированного массива
                countingSortListBox.Invoke(new Action(() => countingSortListBox.DataSource = sortedArray));
            });

            // Запуск сортировки
            countingSort.Start();
        }

        // Вспомогательная функция поиска максимального значения в массиве
        private int FindMaxVal(int[] array, int size)
        {
            var maxVal = array[0];

            for (int i = 1; i < size; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }

            return maxVal;
        }

    }
}
