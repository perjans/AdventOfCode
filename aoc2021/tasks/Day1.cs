using System;
using System.Diagnostics;

namespace aoc2021 {
    public class Day1 {

        public Day1() {
            Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatchPart1 = new Stopwatch();
            Stopwatch stopwatchPart2 = new Stopwatch();
            stopwatch.Start();

            string input = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/aoc2021/aoc2021/tasks_inputs/day1.txt");
            string[] measurementsTemp = input.Split('\n');
            int[] measurements = Array.ConvertAll(measurementsTemp, s => int.Parse(s));

            stopwatchPart1.Start();
            Console.Write("Part1: " + part1(measurements));
            stopwatchPart1.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchPart1.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchPart2.Start();
            Console.Write("Part2: " + part2(measurements));
            stopwatchPart2.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchPart2.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatch.Stop();

            Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatch.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
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
