using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSearch {
    public class Chain {
        private Node[] table;
        private const int TABLE_SIZE = 999;
        private const int MAX_PARAMS = 3;

        private const int PARAM_TIME = 0;
        private const int PARAM_CMPS = 1;
        private const int PARAM_FOUND_KEYS_COUNT = 2;
        
        private int[] data;
        private int[] data_ex;
        private int[] stats;

        public Chain(int[] data_array, int[] data_array_ex) {
            data = data_array;
            data_ex = data_array_ex;
            stats = new int[MAX_PARAMS];
            table = new Node[TABLE_SIZE];
        }

        //Инициализация последовательности ключей
        public void GenerateKeys() {
            if (table == null) return;
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++) {
                int idx = GetHash(data[i]);
                AddKey(ref table[idx], data[i]);
            }
        }

        //Поиск ключей
        public void SearchKeys() {
            Stopwatch watch = new Stopwatch();
            int keys_count = 0;
            watch.Start();
            for (int i = 0; i < data_ex.Length; i++) {
                int idx = GetHash(data_ex[i]);
                if (FindKey(ref table[idx], data_ex[i]))
                    keys_count++;
            }
            watch.Stop();
            stats[PARAM_FOUND_KEYS_COUNT] = keys_count;
            stats[PARAM_TIME] = (int)watch.ElapsedTicks;
        }

        //Возвращает результат поиска ключа
        private bool FindKey(ref Node node, int key) {
            if (node == null) return false;
            stats[PARAM_CMPS]++;
            if (node.data.Equals(key)) return true;
            return FindKey(ref node.next, key);
        }

        //Добавить ключ в цепочку
        private void AddKey(ref Node node, int key) {
            if (node == null) {
                node = new Node(key);
                return;
            }
            AddKey(ref node.next, key);
        }

        //Возвращает хеш-адрес
        private int GetHash(int value) {
            int hash = 0;
            int digits_count = GetDigitsCount(value);
            int series_length = GetDigitsCount(TABLE_SIZE);
            int divider = (int)Math.Pow(10, series_length);
            while (value > 0) {
                hash += value % divider;
                if (GetDigitsCount(hash) > GetDigitsCount(TABLE_SIZE))
                    hash = hash % (int)Math.Pow(10, GetDigitsCount(TABLE_SIZE));
                if (hash >= TABLE_SIZE)
                    hash = 0;
                value /= divider;
            }
            return hash;
        }

        //Возвращает кол-во цифр в числе
        private int GetDigitsCount(int value) {
            return (int)Math.Log10(value) + 1;
        }

        //Возвращает характеристики поиска
        public int[] GetParams() { return stats; }
    }

    //Структура узла (метод цепочек)
    class Node {
        public int data;
        public Node next;

        public Node(int value) {
            data = value;
            next = null;
        }
    }
}
