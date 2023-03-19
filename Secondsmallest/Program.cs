using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondsmallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 111, 13, 25, 9, 34, 1 };
            int n = arr.Length;

            Array.Sort(arr);

            Console.WriteLine("smallest element is " + arr[0]);
            Console.WriteLine("second smallest element is " + arr[1]);
        }
    }
}
