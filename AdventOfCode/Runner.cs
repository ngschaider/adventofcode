using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    public static class Runner {

        public static async Task<Solution> GetSolution<T>() where T : ISolver, new() {
            string year = typeof(T).Namespace!.Split('.')[1][4..];
            string day = typeof(T).Name[4..];

            string input = await Utils.GetPuzzleInput(Convert.ToInt32(year), Convert.ToInt32(day));

            ISolver solver = new T();
            return solver.Solve(input);
        }

    }
}
