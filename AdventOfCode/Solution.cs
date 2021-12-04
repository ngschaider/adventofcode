using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode {
    public class Solution {

        public string Part1 {
            get;
        }

        public string Part2 {
            get;
        }

        public Solution(int part1, int part2) : this(part1.ToString(), part2.ToString()) {

        }

        public Solution(string part1, string part2) {
            this.Part1 = part1;
            this.Part2 = part2;
        }

    }
}
