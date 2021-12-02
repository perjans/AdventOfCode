using System;
namespace aoc2021 {
    public class Day1 {

        public Day1() {
            string input = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/aoc2021/aoc2021/tasks_inputs/day1.txt");
            string[] measurementsTemp = input.Split('\n');
            int[] measurements = Array.ConvertAll(measurementsTemp, s => int.Parse(s));

            Console.WriteLine("Part1: " + part1(measurements));
            Console.WriteLine("Part2: " + part2(measurements));
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
