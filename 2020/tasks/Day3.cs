using System;
using System.Diagnostics;

namespace _2020.tasks {
    public class Day3 {

        public Day3() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2020/tasks_inputs/day1.txt");
            string[] inputs = text.Split('\n');

            //stopwatchTask.Start();
            Console.Write("Part1: " + part1(inputs));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchTask.Reset();

            //stopwatchTask.Start();
            //Console.Write("Part2: " + part2(inputs));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchProg.Stop();

            //Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }

        int part1(string[] inputs) {
            int result = 0;



            return result;
        }
    }
}
