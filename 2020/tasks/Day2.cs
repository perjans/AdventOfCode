using System;
using System.Diagnostics;

namespace _2020.tasks {
    public class Day2 {

        public Day2() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2020/tasks_inputs/day2.txt");
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
            int result = 0;

            foreach (var input in inputs) {
                char letter = Convert.ToChar(input.Split(' ')[1].TrimEnd(':'));
                int leastOccur = int.Parse(input.Split(' ')[0].Split('-')[0]);
                int mostOccur = int.Parse(input.Split(' ')[0].Split('-')[1]);
                string password = input.Split(' ')[2];

                int occurance = 0;

                if (password.Contains(letter)) {
                    foreach (var c in password) {
                        if (c == letter) {
                            occurance++;
                        }
                    }
                }

                if (occurance >= leastOccur && occurance <= mostOccur) {
                    result++;
                }
            }

            return result;
        }

        int part2(string[] inputs) {
            int result = 0;

            foreach (var input in inputs) {
                char letter = Convert.ToChar(input.Split(' ')[1].TrimEnd(':'));
                int firstLetter = int.Parse(input.Split(' ')[0].Split('-')[0]) - 1;
                int secondLetter = int.Parse(input.Split(' ')[0].Split('-')[1]) - 1;
                string password = input.Split(' ')[2];

                int occurance = 0;

                if (password.Contains(letter)) {
                    int charIndex = 0;

                    foreach (var c in password) {
                        if (c == letter) {
                            if (charIndex == firstLetter || charIndex == secondLetter) {
                                occurance++;
                            }
                        }

                        charIndex++;
                    }
                }

                if (occurance == 1) {
                    result++;
                }

            }

            return result;
        }
    }
}
