using AdventOfCode.Year2021;
using System;
using System.Threading.Tasks;

namespace AdventOfCode {
    public class Program {
        public static void Main() {

            MainAsync().GetAwaiter().GetResult();

        }

        public static async Task MainAsync() {
            Solution solution = await Runner.GetSolution<Day02>();
            Console.WriteLine(solution.Part1);
            Console.WriteLine(solution.Part2);
        }
    }
}
