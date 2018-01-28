using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSearch {
    //Структура узла (дерево цифрового поиска)
    class Item {
        public char symbol;
        public Item right_item;
        public Item down_item;

        public Item(char data) {
            symbol = data;
        }
    }

    public class DigitalTree {
        private Item head;
        private const int MAX_PARAMS = 3;

        private const int PARAM_TIME = 0;
        private const int PARAM_CMPS = 1;
        private const int PARAM_FOUND_KEYS_COUNT = 2;

        private int[] data;
        private int[] data_ex;
        private int[] stats;

        public DigitalTree(int[] data_array, int[] data_array_ex) {
            data = data_array;
            data_ex = data_array_ex;
            stats = new int[MAX_PARAMS];
            head = new Item('*');
        }

        //Инициализация последовательности ключей
        public void GenerateKeys() {
            if (head == null) return;
            Random rnd = new Random();
            for (int i = 0; i < data.Length; i++) {
                List<char> symbols = GetCharList(data[i]);
                AddKey(ref head, symbols);
            }
        }

        //Поиск ключей
        public void SearchKeys() {
            Stopwatch watch = new Stopwatch();
            int count = 0;
            List<List<char>> database = new List<List<char>>();
            for (int i = 0; i < data_ex.Length; i++)
                database.Add(GetCharList(data_ex[i]));
            watch.Start();
            for (int i = 0; i < data_ex.Length; i++)
                if (FindKey(ref head, database[i]))
                    count++;
            watch.Stop();
            stats[PARAM_TIME] = (int)watch.ElapsedTicks;
            stats[PARAM_FOUND_KEYS_COUNT] = count;
        }

        //Найти ключ
        private bool FindKey(ref Item head, List<char> symbols) {
            stats[PARAM_CMPS]++;
            if (head.symbol.Equals(symbols[0])) {
                symbols.RemoveAt(0);
                if (head.down_item != null)
                    return FindKey(ref head.down_item, symbols);
                if (symbols.Count > 0)
                    return false;
                return true;
            }
            if (head.right_item != null)
                return FindKey(ref head.right_item, symbols);
            return false;
        }

        //Добавить слово в дерево
        private void AddKey(ref Item head, List<char> symbols) {
            if (head.symbol.Equals(symbols[0])) {
                symbols.RemoveAt(0);
                if (head.down_item != null)
                    AddKey(ref head.down_item, symbols);
                return;
            }
            if (head.right_item != null) {
                AddKey(ref head.right_item, symbols);
                return;
            }
            head.right_item = new Item(symbols[0]);
            Item new_head = head.right_item;
            for (int j = 1; j < symbols.Count; j++)
                new_head = AddSymbolDown(ref new_head, symbols[j]);
        }

        //Добавить символ вниз
        private Item AddSymbolDown(ref Item head, char symbol) {
            head.down_item = new Item(symbol);
            return head.down_item;
        }
        
        //Возвращает коллекцию символов
        private List<char> GetCharList(int value) {
            List<char> symbols = new List<char>();
            int count = value > 0 ? (int)Math.Log10(value) + 1 : 1;
            for (int i = 0; i < count; i++) {
                symbols.Add(char.Parse((value % 10).ToString()));
                value /= 10;
            }
            symbols.Reverse();
            symbols.Add('*');
            return symbols;
        }

        //Возвращает характеристики поиска
        public int[] GetParams() { return stats; }
    }
}
