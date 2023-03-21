// See https://aka.ms/new-console-template for more information

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
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<int>(13, 2, 21));
        }
    }


    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T lhs, T rhs, T xhs)
        {
            return (dynamic)lhs + (dynamic)rhs + (dynamic)rhs;
        }

    }

}