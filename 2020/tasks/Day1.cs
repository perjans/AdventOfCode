using System;
using System.Diagnostics;

namespace _2020.tasks {
    public class Day1 {

        public Day1() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2020/tasks_inputs/day1.txt");
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

        int part1(int[] inputs) {
            int threshold = 2020;
            int result = 0;

            for (int i = 0; i < inputs.Length; i++) {
                if (inputs[i] < threshold) {
                    for (int j = 0; j < inputs.Length; j++) {
                        if (inputs[i] + inputs[j] == 2020) {
                            result = inputs[i] * inputs[j];
                            break;
                        }
                    }
                }
            }

            return result;
        }

        int part2(int[] inputs) {
            int threshold = 2020;
            int result = 0;

            for (int i = 0; i < inputs.Length; i++) {
                if (inputs[i] < threshold) {
                    for (int j = 0; j < inputs.Length; j++) {
                        if (inputs[i] + inputs[j] < 2020) {
                            for (int x = 0; x < inputs.Length; x++) {
                                if (inputs[i] + inputs[j] + inputs[x] == threshold) {
                                    result = inputs[i] * inputs[j] * inputs[x];
                                    break;
                                }
                            }

                        }
                    }
                }
            }

            return result;
        }

    }
}
