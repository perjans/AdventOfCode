using System;
using System.Diagnostics;

namespace _2021.tasks {
    public class Day2 {

        public Day2() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day2.txt");
            string[] inputs = text.Split('\n');

            stopwatchTask.Start();
            Console.Write("Part1: " + part1(inputs));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchTask.Reset();

            stopwatchTask.Start();
            Console.Write("Part2: " + part2(inputs));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchProg.Stop();

            Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
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
