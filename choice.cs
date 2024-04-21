using System;

namespace choice
{
    public class choice
    {
        public choice()
        {
        }
        public void SelectionSort(DataGridView dataGridView)
        {
            int n = dataGridView.Rows.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (CompareRows(dataGridView.Rows[j], dataGridView.Rows[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    SwapRows(dataGridView, i, minIndex);
                }
            }
        }

        private int CompareRows(DataGridViewRow row1, DataGridViewRow row2)
        {
            // Здесь необходимо реализовать сравнение двух строк и вернуть результат сравнения
            // Например, если необходимо сортировать по столбцу "Name" типа string:
            string value1 = row1.Cells["Name"].Value.ToString();
            string value2 = row2.Cells["Name"].Value.ToString();

            return string.Compare(value1, value2);
        }

        private void SwapRows(DataGridView dataGridView, int index1, int index2)
        {
            DataGridViewRow row1 = dataGridView.Rows[index1];
            DataGridViewRow row2 = dataGridView.Rows[index2];

            dataGridView.Rows.Remove(row1);
            dataGridView.Rows.Remove(row2);

            dataGridView.Rows.Insert(index1, row2);
            dataGridView.Rows.Insert(index2, row1);
        }
    }
}
