using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _2021.tasks {
    public class Day5 {

        public Day5() {
            //Stopwatch stopwatchProg = new Stopwatch();
            //Stopwatch stopwatchTask = new Stopwatch();
            //stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day5.txt");
            string[] inputsTemp = text.Split('\n');


            string[] pos1 = new string[inputsTemp.Length];
            string[] pos2 = new string[inputsTemp.Length];

            for (int i = 0; i < inputsTemp.Length; i++) {
                pos1[i] = inputsTemp[i].Split(new string[] { " -> " }, StringSplitOptions.None)[0];
                pos2[i] = inputsTemp[i].Split(new string[] { " -> " }, StringSplitOptions.None)[1];
            }

            int[,] from = new int[inputsTemp.Length, 2];
            int[,] to = new int[inputsTemp.Length, 2];

            for (int i = 0; i < inputsTemp.Length; i++) {
                from[i, 0] = int.Parse(pos1[i].Split(',')[0]);
                from[i, 1] = int.Parse(pos1[i].Split(',')[1]);

                to[i, 0] = int.Parse(pos2[i].Split(',')[0]);
                to[i, 1] = int.Parse(pos2[i].Split(',')[1]);

            }

            int[,] map = new int[1000,1000];

            for (int i = 0; i < inputsTemp.Length; i++) {

                if (from[i, 0] == to[i, 0] || from[i, 1] == to[i, 1]) {
                    for (int x = Math.Min(from[i, 0], to[i, 0]); x <= Math.Max(from[i, 0], to[i, 0]); x++) {
                        for (int y = Math.Min(from[i, 1], to[i, 1]); y <= Math.Max(from[i, 1], to[i, 1]); y++) {
                            map[x, y]++;
                        }
                    }
                } else {

                    int steps = Math.Abs(from[i, 0] - to[i, 0]) + 1;

                    for (int j = 0; j < steps; j++) {
                        //Console.WriteLine(Math.Abs(from[i, 0] - to[i, 0]) + 1);
                        //Console.WriteLine(from[i, 0] + ":" + from[i, 1]);

                        map[from[i, 0], from[i, 1]]++;

                        if (from[i, 0] > to[i, 0]) {
                            from[i, 0]--;
                        } else {
                            from[i, 0]++;
                        }

                        if (from[i, 1] > to[i, 1]) {
                            from[i, 1]--;
                        } else {
                            from[i, 1]++;
                        }


                    }
                }
            }

            //for (int i = 0; i < map.GetLength(0); i++) {
            //    for (int j = 0; j < map.GetLength(1); j++) {
            //        Console.Write(map[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            int result = 0;

            for (int i = 0; i < map.GetLength(0); i++) {
                for (int j = 0; j < map.GetLength(1); j++) {
                    if (map[i, j] > 1) {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);


            //steg 1, loopa över input
            //steg 2, loopa över x och y i current input
            //steg 3, increment current pos med 1 i 2d arr
            //steg 4, sum 2d arr som är över 2



            //for (int y = 0; y < inputsTemp.Length; y++) {
            //    for (int x = 0; x < inputsTemp.Length; x++) {

            //        bool hit = false;

            //        for (int i = 0; i < inputsTemp.Length; i++) {

            //        }

            //        if (hit) {
            //            Console.Write('X');
            //        } else {
            //            Console.Write('.');
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //stopwatchTask.Start();
            //Console.Write("Part1: " + part1(inputs));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchTask.Reset();

            //stopwatchTask.Start();
            //Console.Write("Part2: " + part2(inputs));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchProg.Stop();

            //Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }

        string part1(int[] measurements) {
            

            return "";
        }

        string part2(int[] measurements) {
            int prev = measurements[0] + measurements[1] + measurements[2];
            int increments = 0;

            for (int i = 0; i < measurements.Length - 2; i++) {

                if (prev < measurements[i] + measurements[i + 1] + measurements[i + 2]) {
                    increments++;
                }

                prev = measurements[i] + measurements[i + 1] + measurements[i + 2];

            }

            return "";
        }
    }
}
