using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeansClustering
{
    public class ConsoleDataPrinter
    {
        static void ShowData(double[][] data, int decimals, bool indeces, bool newLine)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (indeces == true) Console.Write(i.ToString().PadLeft(3) + " ");

                for (int j=0; j < data[i].Length; j++)
                {
                    Console.Write(data[i][j].ToString("F" + decimals) + " ");
                }
                Console.WriteLine("");
            }

            if (newLine == true) Console.WriteLine("");
        }
    }
}
