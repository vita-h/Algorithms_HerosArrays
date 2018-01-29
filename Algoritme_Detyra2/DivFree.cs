using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme_Detyra2
{
    class DivFree
    {
        Queue<List<int>> Q;
        int K;
        int N;
        int[] KArray;

        public int dfcount(int n, int k)
        {
            N = n;
            K = k;
            Q = new Queue<List<int>>();
            GenArray();

            foreach (int item in KArray)
            {
                Q.Enqueue(new List<int>() { item });
            }

            for (int i = 1; i < n; i++)
            {
                while (Q.Peek().Count() == i)
                {
                    List<int> current = Q.Dequeue(); 
                    for (int j = 0; j < k; j++)     
                    {
                        for (int l = 0; l < i + 1; l++)
                        {
                            List<int> newList = new List<int>(current);
                            newList.Insert(l, KArray[j]);
                            if (CheckValidity(newList) && !CheckIsInQueue(newList))
                                Q.Enqueue(newList);
                        }
                    }
                }         
            }

            return Q.Count();
        }

        private void GenArray()
        {
            KArray = new int[K];
            for (int i = 0; i < K; i++)
                KArray[i] = i + 1;
        }

        private bool CheckValidity(List<int> l)
        {
            for (int i = 1; i < l.Count(); i++)
                if (!(l[i - 1] <= l[i] || l[i - 1] % l[i] != 0))
                    return false;
            return true;
        }

        private bool CheckIsInQueue(List<int> l)
        {
            foreach (var item in Q)
                if (l.SequenceEqual(item))
                    return true;
            
            return false;
        }

        public string QueueToString()
        {
            string s = "";
            foreach (var item in Q)
                s += "  { " + string.Join(", ", item) + " }  \n";

            return s;
        }
    }
}
