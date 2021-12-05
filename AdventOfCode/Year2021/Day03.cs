using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode.Year2021 {
    public class Day03 : ISolver {
        public Solution Solve(string input) {
            BinaryCollection binaries = InputConverter.ToBinaryCollection(input);

            int gammaRate = GetGammaRate(binaries);
            int epsilonRate = GetEpsilonRate(binaries);
            int part1 = gammaRate * epsilonRate;

            int oxygenGeneratorRating = GetOxygenGeneratorRating(binaries);
            int co2ScrubberRating = GetCO2ScrubberRating(binaries);
            int part2 = oxygenGeneratorRating * co2ScrubberRating;
            return new Solution(part1, part2);
        }

        private int GetOxygenGeneratorRating(BinaryCollection binaries) {
            int index = binaries[0].Length - 1;
            while(binaries.Count > 1 && index >= 0) {
                int mostCommon = binaries.GetRow(index).GetMostCommonBit();
                binaries = new BinaryCollection(binaries.Where(binary => binary.GetBit(index) == mostCommon));
                index--;
            }

            return binaries[0].ToDecimal();
        }

        private int GetCO2ScrubberRating(BinaryCollection binaries) {
            int index = binaries[0].Length - 1;
            while(binaries.Count > 1 && index >= 0) {
                int leastCommon = binaries.GetRow(index).GetLeastCommonBit();

                binaries = new BinaryCollection(binaries.Where(binary => binary.GetBit(index) == leastCommon));
                index--;
            }

            return binaries[0].ToDecimal();
        }


        private int GetGammaRate(BinaryCollection binaries) {
            int amountOfBits = binaries[0].Length;

            Binary binary = new Binary();
            for(int i = 0; i < amountOfBits; i++) {
                binary.AddMSB(binaries.GetRow(i).GetMostCommonBit());
            }

            return binary.ToDecimal();
        }

        private int GetEpsilonRate(BinaryCollection binaries) {
            int amountOfBits = binaries[0].Length;

            Binary binary = new Binary();
            for(int i = 0; i < amountOfBits; i++) {
                binary.AddMSB(binaries.GetRow(i).GetLeastCommonBit());
            }

            return binary.ToDecimal();
        }

    }
}
