using static System.Console;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();
        }

        static void Task2()
        {
            /* 
            Pseudo Code for Task 2:
            function (int array a, target x)
            {

            }
            */ 
            int[] a = GenerateUniqueNumbers(5);
            foreach(var i in a)
                {
                    Write(i.ToString() + " ");
                }
            CountPrime(a);
            Segregate(a, 0, a.Length - 1);
            WriteLine($"Array elements after segregation");
            foreach(var i in a)
                {
                    Write(i.ToString() + " ");
                }
        }

        static void Segregate(int[] arr, int left, int right)
        {
            while (IsPrime(arr[left]) == true) {
                left++;//left stops at a non-prime
                if(left > arr.Length-1) return;//segregation complete
            }

            while (IsPrime(arr[right]) == false) {
                right--;//right stops at a prime
                if(right < 0) return; //segregation complete
            }
            if(left >= right) return;
            int t = arr[left];
            arr[left] = arr[right];
            arr[right] = t;
            Segregate(arr, left, right);
        }

        static void CountPrime(int[] a)
        {
            int count = 0;
            foreach(int j in a)
            {
                if(IsPrime(j) == true) count++;
            }
            WriteLine($"\nCount of Prime numbers: {count}\n");
            
        }
        static bool IsPrime(int n)
        {
            if(n <= 1) return false; 
            if(n == 2) return true; 
            if(n % 2 == 0) return false; 
            for(int i = 3; i < Math.Sqrt(n); i++) 
            {
                if(n % i == 0) return false; 
            }
            return true;
        }
        static int[] GenerateUniqueNumbers(int size)
        {
            Random random = new Random();
            var values = new HashSet<int>();
            while (true)
            {
                values.Add(random.Next(1, 100));
                if (values.Count == size) break;
            }
            return values.ToArray();
        }
    }
}
