// See https://aka.ms/new-console-template for more information
<<<<<<< Updated upstream
Console.WriteLine("Hello, World!");
=======

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan penjumlahan = new Penjumlahan();
            Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 21));

            SimpleDataBase<int> db = new SimpleDataBase<int>();
            db.AddNewData(13);
            db.AddNewData(02);
            db.AddNewData(21);

            db.PrintAllData();
        }
    }


    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T lhs, T rhs, T xhs)
        {
            return (dynamic)lhs + (dynamic)rhs + (dynamic)rhs;
        }

    }



    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i< storedData.Count; i++)
            {
                Console.WriteLine($"Data{i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }
}
>>>>>>> Stashed changes
