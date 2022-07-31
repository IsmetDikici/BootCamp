using System;

namespace DictionaryDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(34, "İstanbul");
            plakalar.Add(78, "Karabük");

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "İsmet");
            myDictionary.Add(2, "Hayrullah");
            myDictionary.Add(3, "Hasan");
            myDictionary.Add(4, "Niyazi");

            myDictionary.ShowList();

        }
    }

    }
