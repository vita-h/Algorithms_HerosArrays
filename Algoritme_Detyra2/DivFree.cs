﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritme_Detyra2
{
    class DistinctListComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            if (x.SequenceEqual(y))
                return true;
            else
                return false;
        }

        public int GetHashCode(List<int> obj)
        {
            throw new NotImplementedException();
        }
    }

    class DivFree
    {
        Queue<List<int>> Q;
        int K;
        int N;
        int[] KArray;

        public int dfcount(int n, int k)
        {
            if (n < 1 || n > 50000 || k < 1 || k > 50000)
                throw new Exception("N and K will be between 1 and 50000, inclusive.");

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
                            if (CheckValidity(newList) && !Q.Contains(newList, new DistinctListComparer()))
                                Q.Enqueue(newList);
                        }
                    }
                }         
            }

            return (Q.Count() % 1000000007);
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

        public string QueueToString()
        {
            string s = "";
            foreach (var item in Q)
                s += "  { " + string.Join(", ", item) + " }  \n";

            return s;
        }
    }
}
