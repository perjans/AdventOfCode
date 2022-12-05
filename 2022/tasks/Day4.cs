using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using static _2022.tasks.Day4;

namespace _2022.tasks {
    public class Day4 {

        public Day4() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2022/tasks_inputs/day4.txt");
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

        int part1(string[] inputs)
        {
            int score = 0;

            foreach (var item in inputs)
            {
                var elves = item.Split(',');
                int from1 = int.Parse(elves[0].Split('-')[0]);
                int to1 = int.Parse(elves[0].Split('-')[1]);

                int from2 = int.Parse(elves[1].Split('-')[0]);
                int to2 = int.Parse(elves[1].Split('-')[1]);

                if (from1 <= from2 && to1 >= to2) score++;
                else if (from1 >= from2 && to1 <= to2) score++;
            }

            return score;
        }

        int part2(string[] inputs)
        {
            int score = 0;

            foreach (var item in inputs)
            {
                var elves = item.Split(',');
                int from1 = int.Parse(elves[0].Split('-')[0]);
                int to1 = int.Parse(elves[0].Split('-')[1]);

                int from2 = int.Parse(elves[1].Split('-')[0]);
                int to2 = int.Parse(elves[1].Split('-')[1]);

                if (from1 <= to1 && from2 <= to1) score++;
            }

            return score;
        }

    }
}
