using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("**Starting random!! User input is required**\nStarting value: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ending value: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many numbers do you want to display: ");
            int many = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour Numbers are: "+ DisplayArr(CreateArr(start, end, many))+"\n\n**Stopping random**\n**Press any key to close the program**");
            Console.ReadKey();
        }

        public static int[] CreateArr(int start, int end, int many)
        {
            int[] intarr = new int[end-start];
            for(int i = 0; i < intarr.Length; i++)
            {
                intarr[i] = start++;
            }
            Random random = new Random();
            for(int i = 0; i < intarr.Length; i++)
            {
                int temp = intarr[i];
                int r = random.Next(i, intarr.Length);
                intarr[i] = intarr[r];
                intarr[r] = temp;
            }
            int[] randomly = new int[many];
            for(int i = 0; i < many; i++)
            {
                randomly[i] = intarr[i];
            }
            Array.Sort(randomly);
            return randomly;
        }
        public static String DisplayArr(int[] arr)
        {
            String numbers = "";
            for(int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                    numbers += arr[i];
                else
                    numbers += arr[i] + ", ";
            }
            return numbers;
        }
    }
}
