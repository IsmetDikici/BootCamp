using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDeneme
{
    class MyDictionary<T,K>
    {
        KeyValuePair<T, K>[] items;
        KeyValuePair<T, K>[] tempArray;
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }

        public void Add(T _key, K _value)
        {
            if (Control(_key))
            {
                Configuration(_key);
                items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value);
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri eşsiz olmalı.");
            }
        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        bool Control(T _key)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == _key.ToString())
                {
                    control = false;
                }
            }
            return control;
        }

        void Configuration(T _key)
        {
            tempArray = items;
            items = new KeyValuePair<T, K>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
    }
}
