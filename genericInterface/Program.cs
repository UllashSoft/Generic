using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] IntArray = new int[] {1,2,3,4,5};
            double[] DoubleArray = new double[] { 1.5, 2.5, 3.5, 4.5 };
            string[] StringArray = new string[] {"10","20","30","40" };

            GenericInterface(IntArray);
            GenericInterface(DoubleArray);
            GenericInterface(StringArray);
            Console.ReadKey();
        }
        public static void GenericInterface<T>(T[] IntArray)
        {
            foreach (T Titem in IntArray)
            {
                Console.Write(Titem + " ");
            }
            Console.WriteLine("End");
        }
        
    }
}
