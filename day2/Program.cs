using System;

namespace day2 {
    class Program {
        static void Main(string[] args) {
            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/day2/day2/day2.txt");
            string[] inputs = text.Split('\n');

            int horizontal = 0;
            int depth = 0;

            //Part 1

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

            Console.WriteLine("Part 1: " + horizontal * depth);


            horizontal = 0;
            depth = 0;
            int aim = 0;

            //Part 2

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

            Console.WriteLine("Part 2: " + horizontal * depth);

        }
    }
}
