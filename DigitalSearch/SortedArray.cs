using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSearch {
    public class SortedArray {
        private const int MAX_PARAMS = 3;

        private const int PARAM_TIME = 0;
        private const int PARAM_CMPS = 1;
        private const int PARAM_FOUND_KEYS_COUNT = 2;

        private int[] data;
        private int[] data_ex;
        private int[] stats;

        public SortedArray(int[] data_array, int[] data_array_ex) {
            Array.Sort(data_array);
            data = data_array;
            data_ex = data_array_ex;
            stats = new int[MAX_PARAMS];
        }

        //Поиск ключей
        public void SearchKeys() {
            Stopwatch watch = new Stopwatch();
            int keys_count = 0;
            watch.Start();
            for (int i = 0; i < data_ex.Length; i++)
                if (FindKey(data_ex[i]))
                    keys_count++;
            watch.Stop();
            stats[PARAM_FOUND_KEYS_COUNT] = keys_count;
            stats[PARAM_TIME] = (int)watch.ElapsedTicks;
        }

        //Возвращает результат поиска ключа
        private bool FindKey(int key) {
            for (int i = 0; i < data.Length; i++) {
                stats[PARAM_CMPS]++;
                if (data[i].Equals(key)) return true;
            }
            return false;
        }

        //Возвращает характеристики поиска
        public int[] GetParams() { return stats; }
    }
}
