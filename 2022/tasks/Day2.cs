using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static _2022.tasks.Day2;

namespace _2022.tasks {
    public class Day2 {

        public Day2() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2022/tasks_inputs/day2.txt");
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

        public enum Oppo
        {
            Rock = 65,
            Paper = 66,
            Scissors = 67
        }

        public enum Self
        {
            Rock = 88,
            Paper = 89,
            Scissors = 90
        }

        public enum End
        {
            Lose = 88,
            Draw = 89,
            Win = 90
        }

        int part1(string[] inputs)
        {
            int score = 0;

            foreach (var item in inputs)
            {
                Oppo oppo = (Oppo)Enum.ToObject(typeof(Oppo), char.Parse(item.Split(' ')[0]));
                Self self= (Self)Enum.ToObject(typeof(Self), char.Parse(item.Split(' ')[1]));

                switch (self)
                {
                    case Self.Rock:
                        score += 1;
                        if (oppo == Oppo.Rock) score += 3;
                        if (oppo == Oppo.Scissors) score += 6;
                        break;

                    case Self.Paper:
                        score += 2;
                        if (oppo == Oppo.Paper) score += 3;
                        if (oppo == Oppo.Rock) score += 6;
                        break;

                    case Self.Scissors:
                        score += 3;
                        if (oppo == Oppo.Scissors) score += 3;
                        if (oppo == Oppo.Paper) score += 6;
                        break;
                }
            }

            return score;
        }

        int part2(string[] inputs)
        {
            int score = 0;

            foreach (var item in inputs)
            {
                Oppo oppo = (Oppo)Enum.ToObject(typeof(Oppo), char.Parse(item.Split(' ')[0]));
                End end = (End)Enum.ToObject(typeof(End), char.Parse(item.Split(' ')[1]));

                switch (end)
                {
                    case End.Lose:
                        if (oppo == Oppo.Rock) score += 3;
                        if (oppo == Oppo.Paper) score += 1;
                        if (oppo == Oppo.Scissors) score += 2;
                        break;

                    case End.Draw:
                        score += 3;
                        if (oppo == Oppo.Rock) score += 1;
                        if (oppo == Oppo.Paper) score += 2;
                        if (oppo == Oppo.Scissors) score += 3;
                        break;

                    case End.Win:
                        score += 6;
                        if (oppo == Oppo.Rock) score += 2;
                        if (oppo == Oppo.Paper) score += 3;
                        if (oppo == Oppo.Scissors) score += 1;
                        break;
                }
            }

            return score;
        }

    }
}
