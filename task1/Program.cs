using System;
using static System.Console; //console.writeline similar to system.out.println
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("The numbers in the file are: ");
            int[] arr = Task1(); //only needed this line because it is printing as it initialises,
            ArrayOperations(arr); 
        }
        static int[] Task1()
        {
            string[] lines = null;
            try
            {
                lines = File.ReadAllLines("data.txt");
            }catch(IOException e)
            {
                WriteLine(e.Source);
            }
            int[] numArr = null;
            if(lines != null)
            {
                numArr = Array.ConvertAll(lines, int.Parse);
                foreach(int i in numArr)
                {
                    Write(i + " ");
                }
            }
            return numArr;
        }

        static void ArrayOperations(int[] arr)
        {

            int m = arr.Min();
            WriteLine("\n");
            WriteLine($"The minimum number is {m}"); 
            int idx = Array.IndexOf(arr, m);
            WriteLine($"The minimum number index is {idx}\n");

            int min = int.MinValue; 
            foreach(int i in arr)
            {
                if(i < min) min = i;
            }
        }
    }
}