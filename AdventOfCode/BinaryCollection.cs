using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace AdventOfCode {
    public class BinaryCollection : IEquatable<BinaryCollection>, IEnumerable<Binary> {

        private readonly List<Binary> binaries = new List<Binary>();

        public int Count => binaries.Count;
        public BinaryCollection() {
        
        }

        public BinaryCollection(IEnumerable<Binary> binaries) {
            this.binaries.AddRange(binaries);
        }

        /**
         * returns a new Binary made up of all bits of the specified row
         */
        public Binary GetRow(int index) {
            int[] bits = binaries.Select(binary => binary.GetBit(index)).ToArray();
            return new Binary(bits);
        }

        public void Add(Binary binary) => binaries.Add(binary);


        public Binary this[int index] {
            get {
                return binaries[index];
            }
            set {
                binaries[index] = value;
            }
        }

        public override string ToString() {
            return string.Join(", ", binaries);
        }

        public bool Equals([AllowNull] BinaryCollection other) {
            return other == null ? false : binaries == other.binaries;
        }

        public IEnumerator<Binary> GetEnumerator() => binaries.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => binaries.GetEnumerator();
    }
}
