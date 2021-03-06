﻿using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable application!");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            hash.GetFrequency("not");
            hash.GetFrequency("1");

            Console.WriteLine("\n");
            hash.displayFrequencyAllWordsInList();
            hash.Remove("1");

            Console.WriteLine("After removing: \n");
            hash.displayFrequencyAllWordsInList();

            Console.ReadKey();
        }
    }
}
