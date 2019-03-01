using System;
namespace MyCode
{

    public class MyDataStructure
    {
        public class MyQueue
        {
            private int _qMaxSize = 100000;
            private int _head;
            private int _tail;
            private object[] _Q;
        
            // init
            public MyQueue() {
                _Q = new Object[_qMaxSize];
                _head = 0;
                _tail = 0;
            }

            public void Enqueue(object obj)
            {
                if (IsFull())
                {
                    throw new OverflowException();
                }

                _Q[_tail] = obj;

                _tail = (_tail + 1 == _qMaxSize) ? _tail = 0 : _tail += 1;
            }

            public object Dequeue()
            {
                if (IsEmpty())
                {
                    //TODO UNDERFLAW EXCEPTION
                }

                object deq = _Q[_head];
                _head = (_head + 1 == _qMaxSize) ? _head = 0 : _head += 1;
                return deq;
            }

            public bool IsFull()
            {
                return _head == (_tail + 1) % _qMaxSize;
            }

            public bool IsEmpty()
            {
                return _head == _tail;
            }
        }        
    }

    public class NumberTheory
    {
        public static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            
            // O (N)
            //int y = x - 1;
            //while(y > 1)
            //{
            //    if (x % y == 0) return false;
            //    y--;
            //}
            
            // O(√N)
            // using Composite number
            double r = Math.Sqrt(x);
            for (int i = 2; i <= r; i++)
            {
                if (x % i == 0) return false;
            }

            return true;
        }
        
        public static void SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n+1];
            for (int i = 0; i < n; i++)
            {
                isPrime[i] = true;
            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                int j;
                if (isPrime[i])
                {
                    j = i + i;
                    while (j <= n)
                    {
                        isPrime[j] = false;
                        j = j + i;
                    }
                }
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])    
                {
                    Console.Write(i);
                }
            }
        }

        /// <summary>
        /// The prerequisite: a > 0, b > 0 
        /// Order: O(log b)
        /// </summary>
        public static int GreatedtCommonDivisor(int a, int b)
        {
            if (b == 0) return a;
            return a % b == 0 ? b : GreatedtCommonDivisor(b, a % b);
        }
        
    }

    public class Sort
    {
        //<summary>
        //O(N^2)
        //</summary>
        public static int[] BubbleSort(int[] A)
        {    
            int n = A.Length;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int j = n - 1; j > 0 ; j--)
                {
                    if (A[j - 1] > A[j])
                    {
                        int tmp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = tmp;
                        flag = true;
                    }
                }
            }

            return A;
        }


    }

    public class Graph
    {
        public static void BreathFirstSearch()
        {
            
        }
    }



    public class MyBinary
    {
        public static string ToBinStr(int n, int bit = 16)
        {
            //Range Check
            if (n > Math.Pow(2,bit) -1) return "OVERFLAW";
            if (n < 0) return "UNDERFLAW";

            //Init
            string str = "";
            
            while(bit > 0){                                
                bit--;
                if (Math.Pow(2,bit) > n){ str += "0"; } 
                else
                {
                    str += "1";
                    n -= (int)Math.Pow(2,bit);
                }                               
            }
            return str;            
        }
    }
}