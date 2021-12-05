using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Year2021 {
    public class Day01 : ISolver {

        private readonly int windowSize = 3;

        public Solution Solve(string input) {
            int[] depths = InputConverter.ToIntArray(input);

            // Part1
            int part1 = HowManyTimesIncrementing(depths);

            List<int> windows = new List<int>();

            int windowsCount = depths.Length - (windowSize - 1);
            for(int i = 0; i < windowsCount; i++) {
                windows.Add(GetWindow(depths, i, windowSize));
            }

            int part2 = HowManyTimesIncrementing(windows.ToArray());

            return new Solution(part1, part2);
        }

        private int GetWindow(int[] numbers, int offset, int windowSize) {
            int sum = 0;

            for(int i = 0; i < windowSize; i++) {
                sum += numbers[offset + i];
            }

            return sum;
        }

        private int HowManyTimesIncrementing(int[] numbers) {
            int counter = 0;
            int? previous = null;

            foreach(int number in numbers) {
                if(previous != null && number > previous) {
                    counter++;
                }
                previous = number;
            }

            return counter;
        }

    }
}
