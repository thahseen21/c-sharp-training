//Stopwatch
using System;
using System.Threading;

namespace StopWatchProject
{
    class StopWatch
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int Hours { get; set; }

        public bool Started { get; set; }

        //Here the second,minute and hours are calculate here
        public void Counter()
        {
            while (this.Started)
            {
                Seconds++;
                if (Seconds == 59)
                {
                    Seconds = 0;
                    Minutes++;
                    if (Minutes == 59)
                    {
                        Minutes = 0;
                        Hours++;
                        if (Hours == 23)
                        {
                            Hours = 0;
                        }
                    }
                }
                Thread.Sleep(1000);
            }
        }

        //To get the Key input from the keyboard for to display the interval and to stop
        public void KeyboardListener()
        {
            var input = " ";
            while (string.IsNullOrWhiteSpace(input))
            {
                input = Console.ReadLine();
                if (input.Equals("show"))
                {
                    DisplayStopWatch();
                    input = " ";
                }
            }
            Started = false;
            Stop();
        }

        //To display the time
        public void DisplayStopWatch()
        {
            Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
        }

        public void Start()
        {
            Console.WriteLine($"type 'show' to print the stopwatch value, type 'stop' to stop");

            this.Started = true;

            Thread secondsThread = new Thread(Counter);
            secondsThread.Start();

            Thread keyboardListener = new Thread(KeyboardListener);
            keyboardListener.Start();
        }
        
        //To display the stopwatch time span and to stop
        public void Stop()
        {
            DisplayStopWatch();
            Console.WriteLine($"Stopwatch is reseted");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1. To Start ");
            var choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var stopWatch = new StopWatch();
                    stopWatch.Start();
                    break;
                default:
                    Console.WriteLine($"Please enter a valid input");
                    break;
            }
        }
    }
}
