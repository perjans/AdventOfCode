using System;
namespace aoc2021 {
    public class Day2 {
        public Day2() {
            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/aoc2021/aoc2021/tasks_inputs/day2.txt");
            string[] inputs = text.Split('\n');

            Console.WriteLine("Part1: " + part1(inputs));
            Console.WriteLine("Part2: " + part2(inputs));
        }

        int part1(string[] inputs) {
            int horizontal = 0;
            int depth = 0;

            foreach (var input in inputs) {
                string direction = input.Split(' ')[0];
                int value = int.Parse(input.Split(' ')[1]);

                switch (direction) {
                    case "forward":
                        horizontal += value;
                        break;
                    case "down":
                        depth += value;
                        break;
                    case "up":
                        depth -= value;
                        break;
                }
            }

            return horizontal * depth;
        }

        int part2(string[] inputs) {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (var input in inputs) {
                string direction = input.Split(' ')[0];
                int value = int.Parse(input.Split(' ')[1]);

                switch (direction) {
                    case "forward":
                        horizontal += value;
                        depth += value * aim;
                        break;
                    case "down":
                        aim += value;
                        break;
                    case "up":
                        aim -= value;
                        break;
                }
            }

            return horizontal * depth;
        }

    }
}
