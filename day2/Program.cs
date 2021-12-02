using System;
using System.Diagnostics;

namespace day2 {
    class Program {
        static void Main(string[] args) {
            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/day2/day2/day2.txt");
            string[] inputs = text.Split('\n');

            Stopwatch stopwatch = new Stopwatch();

            int horizontal = 0;
            int depth = 0;

            //Part 1
            stopwatch.Start();

            foreach (var input in inputs) {
                string direction = input.Split(' ')[0];
                int value = int.Parse(input.Split(' ')[1]);

                switch (direction) {
                    case "forward":
                        horizontal += value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }

            stopwatch.Stop();

            Console.WriteLine("Part 1: " + horizontal * depth);


            horizontal = 0;
            depth = 0;
            int aim = 0;

            //Part 2

            stopwatch.Start();

            foreach (var input in inputs) {
                string direction = input.Split(' ')[0];
                int value = int.Parse(input.Split(' ')[1]);

                switch (direction) {
                    case "forward":
                        horizontal += value;
                        depth += value * aim;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }

            stopwatch.Stop();
            double ms = (Convert.ToDouble(stopwatch.ElapsedTicks) / Stopwatch.Frequency) * 1000;

            Console.WriteLine("Part 2: " + horizontal * depth);
            Console.WriteLine();
            Console.WriteLine("Execution time: " + ms + "ms");

        }
    }
}
