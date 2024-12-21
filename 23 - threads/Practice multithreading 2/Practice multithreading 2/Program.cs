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
