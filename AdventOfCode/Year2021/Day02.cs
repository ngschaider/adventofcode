using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Year2021 {
    public class Day02 : ISolver {
        public Solution Solve(string input) {
            int part1 = GetPart1(input);
            int part2 = GetPart2(input);

            return new Solution(part1, part2);
        }

        private int GetPart2(string input) {
            int depth = 0;
            int position = 0; // horizontal position
            int aim = 0;

            foreach(string line in input.Split('\n')) {
                if(line == "") {
                    continue;
                }

                string[] splits = line.Split(' ');
                if(splits[0] == "forward") {
                    position += Convert.ToInt32(splits[1]);
                    depth += aim * Convert.ToInt32(splits[1]);
                } else if(splits[0] == "up") {
                    aim -= Convert.ToInt32(splits[1]);
                } else if(splits[0] == "down") {
                    aim += Convert.ToInt32(splits[1]);
                }
            }

            return depth * position;
        }

        private int GetPart1(string input) {
            int depth = 0;
            int position = 0; // horizontal position

            foreach(string line in input.Split('\n')) {
                if(line == "") {
                    continue;
                }

                string[] splits = line.Split(' ');
                if(splits[0] == "forward") {
                    position += Convert.ToInt32(splits[1]);
                } else if(splits[0] == "up") {
                    depth -= Convert.ToInt32(splits[1]);
                } else if(splits[0] == "down") {
                    depth += Convert.ToInt32(splits[1]);
                }
            }

            return depth * position;
        }

    }
}
