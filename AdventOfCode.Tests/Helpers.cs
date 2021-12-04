using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests {
    public static class Helpers {

        public static async Task AssertDay<T>(string part1, string part2) where T : ISolver, new() {
            Solution solution = await Runner.GetSolution<T>();

            Assert.AreEqual(part1, solution.Part1);
            Assert.AreEqual(part2, solution.Part2);
        }

        public static async Task AssertDay<T>(int part1, int part2) where T : ISolver, new() {
            await AssertDay<T>(part1.ToString(), part2.ToString());
        }

    }
}
