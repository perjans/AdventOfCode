using System;
using System.Diagnostics;

namespace aoc2021 {
    public class Day2 {

        public Day2() {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatchPart1 = new Stopwatch();
            Stopwatch stopwatchPart2 = new Stopwatch();
            stopwatch.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/aoc2021/aoc2021/tasks_inputs/day2.txt");
            string[] inputs = text.Split('\n');

            stopwatchPart1.Start();
            Console.Write("Part1: " + part1(inputs));
            stopwatchPart1.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchPart1.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchPart2.Start();
            Console.Write("Part2: " + part2(inputs));
            stopwatchPart2.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchPart2.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatch.Stop();

            Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatch.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }

        int part1(string[] inputs) {
            int horizontal = 0;
            int depth = 0;

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

            return horizontal * depth;
        }

        int part2(string[] inputs) {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

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

            return horizontal * depth;
        }

    }
}
