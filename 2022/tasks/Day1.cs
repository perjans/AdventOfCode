using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _2022.tasks {
    public class Day1 {

        public Day1() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2022/tasks_inputs/day1.txt");
            string[] inputsFile = text.Split('\n');
            //int[] inputs = Array.ConvertAll(inputsFile, s => int.Parse(s));

            stopwatchTask.Start();
            Console.Write("Part1: " + part1(inputsFile));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchTask.Reset();

            stopwatchTask.Start();
            Console.Write("Part2: " + part2(inputsFile));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchProg.Stop();

            Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }

        int part1(string[] inputs) {
            List<int> elves = new List<int>();
            int sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (String.IsNullOrEmpty(inputs[i]))
                {
                    elves.Add(sum);
                    sum = 0;
                }
                else if (i == inputs.Length - 1)
                {
                    sum += int.Parse(inputs[i]);
                    elves.Add(sum);
                }
                else
                {
                    sum += int.Parse(inputs[i]);
                }
            }

            int biggie = 0;
            foreach (var item in elves)
            {
                if (item > biggie)
                {
                    biggie = item;
                }
            }

            return biggie;
        }

        int part2(string[] inputs)
        {
            List<int> elves = new List<int>();
            int sum = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (String.IsNullOrEmpty(inputs[i]))
                {
                    elves.Add(sum);
                    sum = 0;
                }
                else if (i == inputs.Length - 1)
                {
                    sum += int.Parse(inputs[i]);
                    elves.Add(sum);
                }
                else
                {
                    sum += int.Parse(inputs[i]);
                }
            }

            var top3 = elves.OrderByDescending(i => i).Take(3);

            sum = 0;
            foreach (var item in top3)
            {
                sum += item;
            }

            return sum;
        }

    }
}
