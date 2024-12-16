using System.Diagnostics;

namespace Multithreading_practice_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of threads: ");
            int numThreads = int.Parse(Console.ReadLine());

            Stopwatch stopwatch = Stopwatch.StartNew();

            List<int> primes = FindPrimesInRangeUsingThreads(start, end, numThreads);

            stopwatch.Stop();

            Console.WriteLine($"Prime numbers in the range {start}-{end}: {string.Join(", ", primes)}");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");
        }

        static List<int> FindPrimesInRangeUsingThreads(int start, int end, int numThreads)
        {
            HashSet<int> primes = new HashSet<int>();
            List<Thread> threads = new List<Thread>();
            object lockObj = new object();

            int rangeSize = (end - start + 1) / numThreads;
            int remainder = (end - start + 1) % numThreads;

            int currentStart = start;

            for (int i = 0; i < numThreads; i++)
            {
                int threadStart = currentStart;
                int threadEnd = threadStart + rangeSize - 1 + (remainder-- > 0 ? 1 : 0);
                currentStart = threadEnd + 1;

                Thread thread = new Thread(() =>
                {
                    List<int> threadPrimes = FindPrimesInRange(threadStart, threadEnd);
                    lock (lockObj)
                    {
                        primes.UnionWith(threadPrimes);
                    }
                });

                threads.Add(thread);
                thread.Start();
            }
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            List<int> sortedPrimes = primes.ToList();
            sortedPrimes.Sort();
            return sortedPrimes;
        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            for (int i = Math.Max(start, 2); i <= end; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int limit = (int)Math.Sqrt(number);
            for (int i = 3; i <= limit; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

    }
}





/*
namespace Practice_multithreading_2
{
    internal class Program
    {
        static bool running = true;
        static int seconds = 0;
        static object lockObj = new object();

        static void Main(string[] args)
        {
            Thread timerThread = new Thread(UpdateTimer);
            Thread inputThread = new Thread(HandleInput);

            timerThread.Start();
            inputThread.Start();

            timerThread.Join();
            inputThread.Join();
        }

        static void UpdateTimer()
        {
            while (running)
            {
                lock (lockObj)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"Timer: {seconds} seconds   ");
                }
                Thread.Sleep(1000);

                lock (lockObj)
                {
                    seconds++;
                }
            }
        }

        static void HandleInput()
        {
            while (running)
            {
                var key = Console.ReadKey(intercept: true).Key;

                lock (lockObj)
                {
                    if (key == ConsoleKey.R)
                    {
                        seconds = 0;
                    }
                    else if (key == ConsoleKey.Q)
                    {
                        running = false;
                    }
                }
            }
        }
    }
}
*/



