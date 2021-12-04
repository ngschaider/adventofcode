using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode {
    public static class Converters {

        public static int[] ToIntArray(string str) {
            List<int> numbers = new List<int>();
            foreach(string split in str.Split('\n')) {
                if(split != "") {
                    numbers.Add(Convert.ToInt32(split));
                }
            }
            return numbers.ToArray();
        }

    }
}
