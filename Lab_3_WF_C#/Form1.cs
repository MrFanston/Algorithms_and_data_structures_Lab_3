using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sort;

namespace Lab_3_WF_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Структура с полями для таблицы
        private List<double> arr = new List<double>();
        private struct Field
        {
            public double time;
            public double c_n;
            public double m_n;
        }
        Field res_choice = new Field(); // поля выборки
        Field res_insert = new Field(); // поля вставки
        Field res_exchange = new Field(); // поля вставки
        Field res_patience = new Field(); // поля Пасьянсной сортировки
        Field res_quick = new Field(); // поля Быстрой сортировки
        Field res_comb = new Field(); // поля сортировки Расческой

        private Random rand = new Random();
        double generateRandomNumber(double A, double B, double C)
        {
            int u;
            double root, right;
            u = rand.Next();
            right = (Convert.ToDouble(u) / Convert.ToDouble(int.MaxValue)); // Проекция u на интервале (0,1)
            root = A + B * Math.Pow((1 / right - 1), (-1 / C)); // обратная функция распределения Fisk
            return root;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button_sort.Enabled = true;
            button_result.Enabled = false;
            dataGridView2.Rows.Clear();
            double n = Convert.ToInt32(numericUpDown_N.Value);
            double A = Convert.ToDouble(numericUpDown_A.Value);
            double B = Convert.ToDouble(numericUpDown_B.Value);
            double C = Convert.ToDouble(numericUpDown_C.Value);
            double x;
            for (int i = 0; i < n; i++)
            {
                x = generateRandomNumber(A, B, C);
                dataGridView1.Rows.Add(x);
                arr.Add(x);
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            Choice choice = new Choice();
            Insert insert = new Insert();
            Exchange exchange = new Exchange();
            Partience partience = new Partience();
            Quick quick = new Quick();
            Comb comb = new Comb();

            List<double> arr_sort = new List<double>();
            button_result.Enabled = true;
            button_sort.Enabled = false;
            double[] result;
            // сортировка выбором
            arr_sort = arr.ToList();
            result = choice.Sort(arr_sort);
            res_choice.time = result[0];
            res_choice.c_n = result[1];
            res_choice.m_n = result[2];
            // сортировка вставками
            arr_sort = arr.ToList();
            result = insert.Sort(arr_sort);
            res_insert.time = result[0];
            res_insert.c_n = result[1];
            res_insert.m_n = result[2];
            // сортировка обменом
            arr_sort = arr.ToList();
            result = exchange.Sort(arr_sort);
            res_exchange.time = result[0];
            res_exchange.c_n = result[1];
            res_exchange.m_n = result[2];
            // сортировка Пасьянсная
            arr_sort = arr.ToList();
            result = partience.Sort(arr_sort);
            res_patience.time = result[0];
            res_patience.c_n = result[1];
            res_patience.m_n = result[2];
            // сортировка Быстрая
            arr_sort = arr.ToList();
            result = quick.Sort(arr_sort, 0, arr_sort.Count() - 1);
            res_quick.time = result[0];
            res_quick.c_n = result[1];
            res_quick.m_n = result[2];
            // сортировка Расческой
            arr_sort = arr.ToList();
            result = comb.Sort(arr_sort);
            res_comb.time = result[0];
            res_comb.c_n = result[1];
            res_comb.m_n = result[2];

            dataGridView2.Rows.Clear();

            for (int i = 0; i < arr_sort.Count; i++)
            {
                dataGridView2.Rows.Add(arr_sort[i]); // записываем каждый элемент в отдельную ячейку.
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            button_sort.Enabled = false;
            button_result.Enabled = false;
            arr.Clear();
        }
        private void ShowChildForm(Form form)
        {
            form.Show(); // показываем новую форму
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            FormRes form = new FormRes(); // создаем новую форму c результатом
            double time_otn = res_choice.time + res_insert.time + res_exchange.time + res_patience.time + res_quick.time + res_comb.time;
            form.Add("Выборка" , Convert.ToString(res_choice.time), Convert.ToString(res_choice.time/time_otn * 100), Convert.ToString(res_choice.c_n), Convert.ToString(res_choice.m_n));
            form.Add("Вставка", Convert.ToString(res_insert.time), Convert.ToString(res_insert.time / time_otn * 100), Convert.ToString(res_insert.c_n), Convert.ToString(res_insert.m_n));
            form.Add("Обмен", Convert.ToString(res_exchange.time), Convert.ToString(res_exchange.time / time_otn * 100), Convert.ToString(res_exchange.c_n), Convert.ToString(res_exchange.m_n));
            form.Add("Пасьянсная сортировка", Convert.ToString(res_patience.time), Convert.ToString(res_patience.time / time_otn * 100), "", "");
            form.Add("Быстрая сортировка", Convert.ToString(res_quick.time), Convert.ToString(res_quick.time / time_otn * 100), "", "");
            form.Add("Сортировка расческой", Convert.ToString(res_comb.time), Convert.ToString(res_comb.time / time_otn * 100), "", "");

            ShowChildForm(form);
        }

    }
}
