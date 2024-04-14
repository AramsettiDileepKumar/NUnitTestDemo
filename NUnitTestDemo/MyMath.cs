using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestDemo
{
    public class MyMath
    {
        static void Main(string[] args)
        {
            
        }
        public  int add(int a,int b)
        {
            return a + b;
        }
        public int divide(int a,int b) 
        {
            return a / b;
        }
        public  string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public  int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            return sum;
        }
        public  int MaxList(List<int> list)
        {
            int max = list.Max();
            return max;
        }
        public HashSet<int> UnionHashSet(HashSet<int> set1, HashSet<int> set2)
        {
            set1.UnionWith(set2);
            return set1;
        }
        public HashSet<int> IntersectHashSet(HashSet<int> set1, HashSet<int> set2)
        {
            set1.IntersectWith(set2);
            return set1;
        }




    }
}
