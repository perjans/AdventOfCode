using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _2021.tasks {
    public class Day3 {

        public Day3() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day3.txt");
            string[] inputs = text.Split('\n');

            Console.WriteLine(part1(inputs));
            stopwatchTask.Start();
            Console.Write("Part1: " + part1(inputs));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchTask.Reset();

            stopwatchTask.Start();
            Console.Write("Part2: " + part2(inputs, 0));
            stopwatchTask.Stop();
            Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            stopwatchProg.Stop();

            Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }

        int part1(string[] inputs) {
            string gammaString = "";

            for (int i = 0; i < inputs[0].Length; i++) {
                int ones = 0;
                int zeros = 0;
                foreach (var row in inputs) {
                    char c = row[i];

                    if (c == '1') {
                        ones++;
                    } else if (c == '0') {
                        zeros++;
                    }
                }

                gammaString += ones > zeros ? '1' : '0';
            }

            int gammaRating = Convert.ToInt32(gammaString, 2);

            string epsilonString = "";

            foreach (var c in gammaString) {
                epsilonString += c == '1' ? '0' : '1';
            }

            int epsilonRating = Convert.ToInt32(epsilonString, 2);

            return gammaRating * epsilonRating;
        }

        int part2(string[] inputs, int i) {
            int oxygenRating = Convert.ToInt32(getOxygenRating(inputs, i), 2);
            int scrubberRating = Convert.ToInt32(getScrubberRating(inputs, i), 2);

            return oxygenRating * scrubberRating;
        }

        string getScrubberRating(string[] inputs, int i) {
            int ones = 0;
            int zeros = 0;

            foreach (var row in inputs) {
                if (row[i] == '1') {
                    ones++;
                } else if (row[i] == '0') {
                    zeros++;
                }
            }

            char leastCommon = ones >= zeros ? '0' : '1';

            List<string> filteredList = new List<string>();

            foreach (var row in inputs) {
                if (row[i] == leastCommon) {
                    filteredList.Add(row);
                }
            }

            string[] newInputs = filteredList.Select(s => s.ToString()).ToArray();

            if (newInputs.Length == 1) {
                return newInputs[0];
            }

            i++;
            return getScrubberRating(newInputs, i);
        }

        string getOxygenRating(string[] inputs, int i) {
            int ones = 0;
            int zeros = 0;

            foreach (var row in inputs) {
                if (row[i] == '1') {
                    ones++;
                } else if (row[i] == '0') {
                    zeros++;
                }
            }

            char mostCommon = ones >= zeros ? '1' : '0';

            List<string> filteredList = new List<string>();

            foreach (var row in inputs) {
                if (row[i] == mostCommon) {
                    filteredList.Add(row);
                }
            }

            string[] newInputs = filteredList.Select(s => s.ToString()).ToArray();

            if (newInputs.Length == 1) {
                return newInputs[0];
            }

            i++;
            return getOxygenRating(newInputs, i);
        }

    }
}
