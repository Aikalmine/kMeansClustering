using System;
using System.Collections.Generic;
using System.IO;

namespace KMeansClustering
{
    public class DataParser
    {
        public static double[][] LoadData(string dataFile, int numColumns, char delimiter)
        {
            List<double[]> rows = new List<double[]>();
            using (FileStream fStream = new FileStream(dataFile, FileMode.Open))
            {
                using (StreamReader sReader = new StreamReader(fStream))
                {
                    string line = "";
                    string[] tokens = null;

                    while ((line = sReader.ReadLine()) != null)
                    {
                        double[] cols = new double[numColumns];
                        tokens = line.Split(delimiter);

                        if (tokens.Length > numColumns) throw new Exception("File row contains more columns than specified");

                        for (int i = 0; i < tokens.Length; i++)
                        {
                            cols[i] = Double.Parse(tokens[i]);
                        }
                        rows.Add(cols);
                    }
                }
            }
            return rows.ToArray();
        }
    }
}
