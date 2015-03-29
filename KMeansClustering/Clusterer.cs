using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMeansClustering
{
    public class Clusterer
    {
        int numClusters;
        int[] clustering;
        private double[][] centroids;
        private double[][] rawData;
        private static Random rnd;

        public Clusterer(int numClusters)
        {
            if (numClusters < 2) throw new Exception("You must initialize a new Culsterer with 2 or more cluster counts");
            this.numClusters = numClusters;
            this.centroids = new double[numClusters][];

            if (rnd == null) rnd = new Random(0);
        }

        public Clusterer(double[][] rawData, int numClusters)
            : this(numClusters)
        {
            this.rawData = rawData;
        }

        public int[] Cluster(int[][] rawData)
        {
            throw new NotImplementedException();
        }

        private bool initRandom(double[][] data, int maxAttempts)
        {

            throw new NotImplementedException();
        }


    }
}
