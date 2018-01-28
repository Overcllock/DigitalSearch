using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSearch {
    public partial class MainWindow : Form {
        private int[] data_array;
        private int[] data_array_ex;

        private const int DIGITAL_TREE = 0;
        private const int CHAIN_METHOD = 1;
        private const int SORTED_ARRAY = 2;

        private const int PARAM_TIME = 0;
        private const int PARAM_CMPS = 1;
        private const int PARAM_FOUND_KEYS_COUNT = 2;

        public MainWindow() {
            InitializeComponent();
            Reset();
        }

        //Инициализация исходной последовательности ключей
        private void CreateDataArray(int count, int length) {
            data_array = new int[count];
            Random rnd = new Random();
            for (int i = 0; i < data_array.Length; i++) {
                int value = rnd.Next((int)Math.Pow(10, rnd.Next(1, length + 1)) - 1);
                data_array[i] = value;
            }
        }

        //Инициализация последовательности ключей для поиска
        private void CreateExDataArray(int[] base_array, int count, int length) {
            data_array_ex = new int[count * 2];
            Random rnd = new Random();
            for (int i = 0; i < base_array.Length; i++)
                data_array_ex[i] = base_array[i];
            for (int i = base_array.Length; i < data_array_ex.Length; i++)
                data_array_ex[i] = rnd.Next((int)Math.Pow(10, rnd.Next(1, length + 1)) - 1);
        }

        //Запуск
        private void _Run__Click(object sender, EventArgs e) {
            Reset();

            int count = (int)Keys_Count.Value;
            int length = (int)Max_Key_Length.Value;
            CreateDataArray(count, length);
            Thread.Sleep(50);
            CreateExDataArray(data_array, count, length);
            if (Selected_Algorithms.GetItemChecked(CHAIN_METHOD)) {
                Chain chain_method = new Chain(data_array, data_array_ex);
                chain_method.GenerateKeys();
                chain_method.SearchKeys();
                int[] stats = chain_method.GetParams();
                int idx = Stats.Rows.Add();
                Stats.Rows[idx].HeaderCell.Value = "Метод цепочек";
                Stats.Rows[idx].Cells[PARAM_TIME].Value = stats[PARAM_TIME];
                Stats.Rows[idx].Cells[PARAM_FOUND_KEYS_COUNT].Value = stats[PARAM_FOUND_KEYS_COUNT];
                Stats.Rows[idx].Cells[PARAM_CMPS].Value = stats[PARAM_CMPS];
            }
            if (Selected_Algorithms.GetItemChecked(SORTED_ARRAY)) {
                SortedArray sorted_array = new SortedArray(data_array, data_array_ex);
                sorted_array.SearchKeys();
                int[] stats = sorted_array.GetParams();
                int idx = Stats.Rows.Add();
                Stats.Rows[idx].HeaderCell.Value = "Упорядоченный массив ключей";
                Stats.Rows[idx].Cells[PARAM_TIME].Value = stats[PARAM_TIME];
                Stats.Rows[idx].Cells[PARAM_FOUND_KEYS_COUNT].Value = stats[PARAM_FOUND_KEYS_COUNT];
                Stats.Rows[idx].Cells[PARAM_CMPS].Value = stats[PARAM_CMPS];
            }
            if (Selected_Algorithms.GetItemChecked(DIGITAL_TREE)) {
                DigitalTree tree = new DigitalTree(data_array, data_array_ex);
                tree.GenerateKeys();
                tree.SearchKeys();
                int[] stats = tree.GetParams();
                int idx = Stats.Rows.Add();
                Stats.Rows[idx].HeaderCell.Value = "Дерево цифрового поиска";
                Stats.Rows[idx].Cells[PARAM_TIME].Value = stats[PARAM_TIME];
                Stats.Rows[idx].Cells[PARAM_FOUND_KEYS_COUNT].Value = stats[PARAM_FOUND_KEYS_COUNT];
                Stats.Rows[idx].Cells[PARAM_CMPS].Value = stats[PARAM_CMPS];
            }
            RunMultiplySelection();
        }

        private void RunMultiplySelection() {
            int count = (int)Keys_Count.Value;
            int length = (int)Max_Key_Length.Value;

            if (Selected_Algorithms.GetItemChecked(CHAIN_METHOD)) {
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartArea = "ChartArea1";
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                series.Legend = "Legend1";
                series.Name = "Метод цепочек";
                Graph.Series.Add(series);
            }
            if (Selected_Algorithms.GetItemChecked(SORTED_ARRAY)) {
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartArea = "ChartArea1";
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                series.Legend = "Legend1";
                series.Name = "Упорядоченный массив ключей";
                Graph.Series.Add(series);
            }
            if (Selected_Algorithms.GetItemChecked(DIGITAL_TREE)) {
                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.ChartArea = "ChartArea1";
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                series.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                series.Legend = "Legend1";
                series.Name = "Дерево цифрового поиска";
                Graph.Series.Add(series);
            }

            for (int i = 0; i < (int)Cycles_Count.Value; i++) {
                CreateDataArray(count, length);
                Thread.Sleep(50);
                CreateExDataArray(data_array, count, length);
                if (Selected_Algorithms.GetItemChecked(CHAIN_METHOD)) {
                    Chain chain_method = new Chain(data_array, data_array_ex);
                    chain_method.GenerateKeys();
                    chain_method.SearchKeys();
                    int[] stats = chain_method.GetParams();
                    Graph.Series.FindByName("Метод цепочек").Points.AddXY(count, stats[PARAM_TIME]);
                }
                if (Selected_Algorithms.GetItemChecked(SORTED_ARRAY)) {
                    SortedArray sorted_array = new SortedArray(data_array, data_array_ex);
                    sorted_array.SearchKeys();
                    int[] stats = sorted_array.GetParams();
                    Graph.Series.FindByName("Упорядоченный массив ключей").Points.AddXY(count, stats[PARAM_TIME]);
                }
                if (Selected_Algorithms.GetItemChecked(DIGITAL_TREE)) {
                    DigitalTree tree = new DigitalTree(data_array, data_array_ex);
                    tree.GenerateKeys();
                    tree.SearchKeys();
                    int[] stats = tree.GetParams();
                    Graph.Series.FindByName("Дерево цифрового поиска").Points.AddXY(count, stats[PARAM_TIME]);
                }
                count += (int)Increase_Keys_Count.Value;
                length += (int)Increase_Key_Length.Value;
            }
        }

        //Сброс
        private void _Reset__Click(object sender, EventArgs e) {
            Reset();
        }

        private void Reset() {
            Stats.Rows.Clear();
            Stats.Columns.Clear();
            Stats.Columns.Add("readings", "Время");
            Stats.Columns.Add("cmps", "Кол-во сравнений");
            Stats.Columns.Add("time", "Найдено ключей");
            Stats.TopLeftHeaderCell.Value = "Тип";
            Graph.Series.Clear();
            Graph.ChartAreas.Clear();

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            chartArea.Name = "ChartArea1";
            Graph.ChartAreas.Add(chartArea);
            Graph.Dock = DockStyle.Fill;
        }
    }
}
