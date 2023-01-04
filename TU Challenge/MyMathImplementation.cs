using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            throw new NotImplementedException();
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> result = new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static bool IsDivisible(int a, int b)
        {
            return (a % b == 0);
        }

        public static bool IsEven(int a)
        {
            return (a % 2 == 0);
        }

        public static int IsInOrder(int a, int b)
        {
            if (a > b)
            {
                return -1;
            }
            else if (a < b)
            {
               return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            throw new NotImplementedException();
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age > 100 || age < 0)
            {
                throw new ArgumentException(String.Format("How are you even alive?"));
            }

            if (age >= 18)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool IsPrimary(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Power(int a, int b)
        {
            int temp = a;
            for (int i = 1; i < b; i++)
            {
                temp *= a; 
            }
            return temp;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            for (int i = 0; i < toSort.Count - 1; i++)
            {
                int mini = i;
                for (int j = i + 1; j < toSort.Count; j++)
                {
                    if (toSort[j] < toSort[i])
                    {
                        mini = j;
                    }
                }
                int temp = toSort[mini];
                toSort[mini] = toSort[i];
                toSort[i] = temp;
            }
            return toSort;
        }
    }
}
