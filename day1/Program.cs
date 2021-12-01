using System;

namespace day1 {
    class Program {
        static void Main(string[] args) {
            var watch = new System.Diagnostics.Stopwatch();

            string input = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/day1/day1/day1.txt");
            string[] measurements = input.Split('\n');

            //Part 1

            int prev = int.Parse(measurements[0]);
            int increments = 0;

            for (int i = 0; i < measurements.Length; i++) {

                if (prev < int.Parse(measurements[i])) {
                    increments++;
                }

                prev = int.Parse(measurements[i]);
            }

            Console.WriteLine("Part 1: " + increments);


            //Part 2

            prev = int.Parse(measurements[0]) + int.Parse(measurements[1]) + int.Parse(measurements[2]);
            increments = 0;

            for (int i = 0; i < measurements.Length - 2; i++) {

                if (prev < int.Parse(measurements[i]) + int.Parse(measurements[i + 1]) + int.Parse(measurements[i + 2])) {
                    increments++;
                }

                prev = int.Parse(measurements[i]) + int.Parse(measurements[i + 1]) + int.Parse(measurements[i + 2]);

            }

            Console.WriteLine("Part 2: " + increments);

        }
    }
}
