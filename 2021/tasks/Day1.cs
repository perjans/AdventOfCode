using System;
using System.Diagnostics;

namespace _2021.tasks {
    public class Day1 {

        public Day1() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day1.txt");
            string[] inputsTemp = text.Split('\n');
            int[] inputs = Array.ConvertAll(inputsTemp, s => int.Parse(s));

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

        int part1(int[] measurements) {
            int prev = measurements[0];
            int increments = 0;

            for (int i = 0; i < measurements.Length; i++) {

                if (prev < measurements[i]) {
                    increments++;
                }

                prev = measurements[i];
            }

            return increments;
        }

        int part2(int[] measurements) {
            int prev = measurements[0] + measurements[1] + measurements[2];
            int increments = 0;

            for (int i = 0; i < measurements.Length - 2; i++) {

                if (prev < measurements[i] + measurements[i + 1] + measurements[i + 2]) {
                    increments++;
                }

                prev = measurements[i] + measurements[i + 1] + measurements[i + 2];

            }

            return increments;
        }

    }
}
