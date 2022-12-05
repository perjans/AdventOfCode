using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using static _2022.tasks.Day3;

namespace _2022.tasks {
    public class Day3 {

        public Day3() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2022/tasks_inputs/day3.txt");
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

            foreach (var row in inputs)
            {
                string compartement1 = row.Substring(0, row.Length / 2);
                string compartement2 = row.Substring(row.Length / 2, row.Length / 2);

                var unique = new HashSet<char>(compartement1);

                foreach (var c1 in unique)
                {
                    if (compartement2.Contains(c1))
                    {
                        if (Char.IsLower(c1)) score += (int)c1 - 96;
                        if (Char.IsUpper(c1)) score += (int)c1 - 38;
                    }
                }
            }

            return score;
        }

        int part2(string[] inputs)
        {
            int score = 0;
            string temp = "";

            List<string> list = new List<string>();

            for (int i = 1; i < inputs.Length + 1; i++)
            {
                if (i == inputs.Length)
                {
                    temp += inputs[i - 1];
                    list.Add(temp);
                }
                else if (i % 3 != 0)
                {
                    temp += inputs[i - 1] + " ";
                }
                else
                {
                    temp += inputs[i - 1];
                    list.Add(temp);
                    temp = "";
                }
            }
            int finalScore = 0;

            foreach (var item in list)
            {
                var backpacks = item.Split(' ');
                var unique = new HashSet<char>(backpacks[0]);
                int tempScore = 0;

                foreach (var c in backpacks[0])
                {
                    if (backpacks[1].Contains(c) && backpacks[2].Contains(c))
                    {
                        if (Char.IsLower(c))
                        {
                            if ((int)c - 96 > tempScore) score = (int)c - 96;
                        }
                        if (Char.IsUpper(c))
                        {
                            if ((int)c - 38 > tempScore) score = (int)c - 38;
                        }
                    }
                }

                finalScore += score;
                tempScore = 0;
            }

            return finalScore;
        }

    }
}
