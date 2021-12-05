using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace AdventOfCode {
    public class Binary : IEquatable<Binary> {

        private readonly List<int> bits = new List<int>();

        public int Length => bits.Count;

        public Binary() {
        
        }
        public Binary(string numberStr) {
            for(int i = numberStr.Length - 1; i >= 0; i--) {
                // ToString so we dont get the ASCII value of zeros and ones
                string bitStr = numberStr[i].ToString();
                int bit = Convert.ToInt32(bitStr);
                AddMSB(bit);
            }
        }

        public Binary(int[] bits) {
            this.bits = new List<int>(bits);
        }

        /**
         * returns an integer representing the binary number in decimal
         */
        public int ToDecimal() {
            int result = 0;

            for(int i = 0; i < bits.Count; i++) {
                result += bits[i] * (int)Math.Pow(2, bits.Count - i - 1);
            }

            return result;
        }

        public void AddMSB(int value) {
            bits.Insert(0, value);
        }

        public void AddLSB(int value) {
            bits.Add(value);
        }

        /**
         * returns the most common bit (zero or one)
         * if amount of zeros is equal to the amount of ones, one is returned.
         */
        public int GetMostCommonBit() {
            return this.bits.Sum() >= bits.Count - this.bits.Sum() ?  1 : 0;
        }

        /**
         * returns the least common bit (zero or one)
         * if amount of zeros is equal to the amount of ones, zero is returned.
         */
        public int GetLeastCommonBit() {
            return this.bits.Sum() < bits.Count - this.bits.Sum() ? 1 : 0;
        }

        /**
         * Returns the bit at the specified index.
         */
        public int GetBit(int index) {
            return bits[bits.Count - index - 1];
        }

        public override string ToString() {
            return string.Join("", bits);
        }

        public bool Equals([AllowNull] Binary other) {
            return other == null ? false : this.ToString() == other.ToString();
        }
    }
}
