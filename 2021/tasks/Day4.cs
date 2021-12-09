using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _2021.tasks {
    public class Day4 {

        static int fuckingNumber = 0;

        public Day4() {
            Stopwatch stopwatchProg = new Stopwatch();
            Stopwatch stopwatchTask = new Stopwatch();
            stopwatchProg.Start();

            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day4.txt");
            string[] inputs = text.Split('\n');
            string[] numbers = inputs[0].Split(',');

            List<string[][]> listMatrix = new List<string[][]>();
            string[][] matrix = new string[5][];


            int y = 0;

            for (int i = 2; i < inputs.Length; i++) {
                if (!String.IsNullOrEmpty(inputs[i])) {
                    string[] row = inputs[i].Split(' ').Where(x => !String.IsNullOrEmpty(x)).ToArray();

                    matrix[y] = row;

                    y++;

                    if (y == 5) {
                        listMatrix.Add(matrix.ToArray());
                        y = 0;
                    }
                }
            }


            List<int> resultList = new List<int>();

            foreach (var arr in part2(numbers, listMatrix)) {
                foreach (var item in arr) {
                    //Console.Write(item + "\t");
                    if (item != "X") {
                        resultList.Add(int.Parse(item));
                    }
                }
                //Console.WriteLine();

            }

            int result = 0;

            foreach (var item in resultList) {
                result += item;
            }

            Console.WriteLine(result * fuckingNumber);


            //foreach (var arr in part2(numbers, listMatrix)) {
            //    foreach (var item in arr) {
            //        Console.Write(item + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(part1(inputs));
            //stopwatchTask.Start();
            //Console.Write("Part1: " + part1(inputs));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchTask.Reset();

            //stopwatchTask.Start();
            //Console.Write("Part2: " + part2(inputs, 0));
            //stopwatchTask.Stop();
            //Console.WriteLine(", " + Math.Round(Convert.ToDouble(stopwatchTask.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");

            //stopwatchProg.Stop();

            //Console.WriteLine("Program execution time: " + Math.Round(Convert.ToDouble(stopwatchProg.ElapsedTicks) / Stopwatch.Frequency * 1000, 4) + "ms");
        }


        string[][] part1(string[] numbers, List<string[][]> listMatrix) {

            foreach (var number in numbers) {

                foreach (var board in listMatrix) {
                    for (int y = 0; y < board.Length; y++) {
                        for (int x = 0; x < board[y].Length; x++) {
                            if (board[y][x] == number) {
                                board[y][x] = "X";

                                switch (y) {
                                    case 0:
                                        if (board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X" && board[y + 4][x] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 1:
                                        if (board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 2:
                                        if (board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 3:
                                        if (board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 4:
                                        if (board[y - 4][x] == "X" && board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                }

                                switch (x) {
                                    case 0:
                                        if (board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X" && board[y][x + 4] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 1:
                                        if (board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 2:
                                        if (board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 3:
                                        if (board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                    case 4:
                                        if (board[y][x - 4] == "X" && board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X") {
                                            fuckingNumber = int.Parse(number);
                                            Console.WriteLine(number);
                                            return board;
                                        }
                                        break;
                                }

                            }
                        }
                    }
                }

            }

            return new string[0][];
        }

        string[][] part2(string[] numbers, List<string[][]> listMatrix) {

            foreach (var number in numbers) {

                if (listMatrix.Count > 1) {
                    foreach (var board in listMatrix) {
                        for (int y = 0; y < board.Length; y++) {
                            for (int x = 0; x < board[y].Length; x++) {
                                if (board[y][x] == number) {
                                    board[y][x] = "X";

                                    switch (y) {
                                        case 0:
                                            if (board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X" && board[y + 4][x] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 1:
                                            if (board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 2:
                                            if (board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 3:
                                            if (board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 4:
                                            if (board[y - 4][x] == "X" && board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                    }

                                    switch (x) {
                                        case 0:
                                            if (board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X" && board[y][x + 4] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 1:
                                            if (board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 2:
                                            if (board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 3:
                                            if (board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                        case 4:
                                            if (board[y][x - 4] == "X" && board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X") {
                                                listMatrix.Remove(board);
                                                return part2(numbers, listMatrix);
                                            }
                                            break;
                                    }

                                }
                            }
                        }
                    }
                 } else {
                    foreach (var board in listMatrix) {
                        for (int y = 0; y < board.Length; y++) {
                            for (int x = 0; x < board[y].Length; x++) {
                                if (board[y][x] == number) {
                                    board[y][x] = "X";

                                    switch (y) {
                                        case 0:
                                            if (board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X" && board[y + 4][x] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 1:
                                            if (board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X" && board[y + 3][x] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 2:
                                            if (board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X" && board[y + 2][x] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 3:
                                            if (board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X" && board[y + 1][x] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 4:
                                            if (board[y - 4][x] == "X" && board[y - 3][x] == "X" && board[y - 2][x] == "X" && board[y - 1][x] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                    }

                                    switch (x) {
                                        case 0:
                                            if (board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X" && board[y][x + 4] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 1:
                                            if (board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X" && board[y][x + 3] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 2:
                                            if (board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X" && board[y][x + 2] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 3:
                                            if (board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X" && board[y][x + 1] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                        case 4:
                                            if (board[y][x - 4] == "X" && board[y][x - 3] == "X" && board[y][x - 2] == "X" && board[y][x - 1] == "X") {
                                                fuckingNumber = int.Parse(number);
                                                Console.WriteLine(number);
                                                return board;
                                            }
                                            break;
                                    }

                                }
                            }
                        }
                    }
                }

            }

            return listMatrix.First();
        }

    }
}
