using System;
using System.Collections.Generic;
using System.Linq;

namespace _2021.tasks {
    public class Day8 {

        public Day8() {
            string text = System.IO.File.ReadAllText(@"/Users/perjansson/Projects/AdventOfCode/2021/tasks_inputs/day8.txt");
            string[] inputs = text.Split('\n');

            List<Dictionary<int, string>> dictList = new List<Dictionary<int, string>>();

            string balle = "";
            int entillballe = 0;

            foreach (var inputRow in inputs) {

                string leftSideValues = inputRow.Split('|')[0].Trim();
                string[] patterns = leftSideValues.Split(' ');

                Dictionary<int, string> patternDict = new Dictionary<int, string>();

                //get the known patterns first
                //1, 4, 7 and 8
                foreach (var pattern in patterns) {
                    switch (pattern.Length) {
                        //1
                        case 2:
                            patternDict.Add(1, pattern);
                            break;
                        //4
                        case 4:
                            patternDict.Add(4, pattern);
                            break;
                        //7
                        case 3:
                            patternDict.Add(7, pattern);
                            break;
                        //8
                        case 7:
                            patternDict.Add(8, pattern);
                            break;
                    }
                }

                for (int i = 0; i < patterns.Length; i++) {
                    string pattern = patterns[i];
                    int charCount = 0;

                    switch (pattern.Length) {
                        //0, 6 or 9
                        case 6:
                            //0
                            if (!patternDict.ContainsKey(0)) {
                                foreach (var c in patternDict[7]) {
                                    if (!pattern.Contains(c)) {
                                        charCount++;
                                    }
                                }
                                foreach (var c in patternDict[4]) {
                                    if (!pattern.Contains(c)) {
                                        charCount++;
                                    }
                                }
                                if (charCount == 1) {
                                    patternDict.Add(0, pattern);
                                }
                                charCount = 0;
                            }

                            //6
                            if (!patternDict.ContainsKey(6)) {
                                foreach (var c in patternDict[1]) {
                                    if (!pattern.Contains(c)) {
                                        patternDict.Add(6, pattern);
                                        if (patternDict.ContainsKey(6)) {
                                            i = 0;
                                        }
                                    }
                                }
                                charCount = 0;
                            }

                            //9
                            if (!patternDict.ContainsKey(9)) {
                                foreach (var c in pattern) {
                                    if (!patternDict[4].Contains(c) && !patternDict[7].Contains(c)) {
                                        charCount++;
                                    }
                                }
                                if (charCount == 1) {
                                    patternDict.Add(9, pattern);
                                    i = 0;
                                }
                                charCount = 0;
                            }
                            break;
                        //2, 3 or 5
                        case 5:
                            //2
                            if (!patternDict.ContainsKey(2)) {
                                foreach (var c in pattern) {
                                    if (!patternDict[4].Contains(c)) {
                                        charCount++;
                                    }
                                }
                                if (charCount == 3) {
                                    patternDict.Add(2, pattern);
                                    i = 0;
                                }
                                charCount = 0;
                            }

                            //3
                            if (!patternDict.ContainsKey(3)) {
                                foreach (var c in patternDict[7]) {
                                    if (!pattern.Contains(c)) {
                                        charCount++;
                                    }
                                }
                                if (charCount == 0) {
                                    patternDict.Add(3, pattern);
                                }
                                charCount = 0;
                            }

                            //5
                            if (!patternDict.ContainsKey(5)) {
                                foreach (var c in patternDict[4]) {
                                    if (!pattern.Contains(c)) {
                                        charCount++;
                                    }
                                }
                                foreach (var c in patternDict[7]) {
                                    if (!pattern.Contains(c)) {
                                        charCount++;
                                    }
                                }
                                if (charCount == 2) {
                                    patternDict.Add(5, pattern);
                                }
                                charCount = 0;
                            }

                            break;
                    }


                }


                string rightSideValues = inputRow.Split('|')[1].Trim();
                string[] outputs = rightSideValues.Split(' ');

                if (patternDict.Count <= 9) {
                    foreach (var item in patternDict.OrderBy(r => r.Key)) {
                        Console.WriteLine(item.Key + ":" + item.Value);
                    }
                }

                foreach (var output in outputs) {
                    foreach (var item in patternDict) {
                        if (item.Value.Length == output.Length) {
                            int test = 0;
                            foreach (var c in item.Value) {
                                if (!output.Contains(c)) {
                                    test++;
                                }
                            }
                            if (test == 0) {
                                balle += item.Key;
                            }
                        }
                    }
                }

                entillballe += int.Parse(balle);


                balle = "";
            }

            Console.WriteLine(entillballe);


        }
    }
}
