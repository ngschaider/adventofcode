using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Tests {
    [TestClass]
    public class BinaryTests {

        [TestMethod]
        public void BinaryParsing() {
            Binary binary = new Binary("1101");
            Assert.AreEqual(1, binary.GetBit(0));
            Assert.AreEqual(0, binary.GetBit(1));
            Assert.AreEqual(1, binary.GetBit(2));
            Assert.AreEqual(1, binary.GetBit(3));
        }
        
        [TestMethod]
        public void BinaryToDecimal() {
            Binary binary = new Binary("1101");
            Assert.AreEqual(13, binary.ToDecimal());
        }


        [TestMethod]
        public void GetRow() {
            BinaryCollection collection = new BinaryCollection();
            collection.Add(new Binary("110"));
            collection.Add(new Binary("001"));
            collection.Add(new Binary("010"));
            collection.Add(new Binary("101"));

            Assert.AreEqual(new Binary("0101").ToString(), collection.GetRow(0).ToString());
            Assert.AreEqual(new Binary("1010").ToString(), collection.GetRow(1).ToString());
            Assert.AreEqual(new Binary("1001").ToString(), collection.GetRow(2).ToString());
        }

        [TestMethod]
        public void GetLeastCommonBit() {
            Assert.AreEqual(0, new Binary("10100111").GetLeastCommonBit());
            Assert.AreEqual(1, new Binary("00101010").GetLeastCommonBit());
        }

        [TestMethod]
        public void GetMostCommonBit() {
            Assert.AreEqual(1, new Binary("10100111").GetMostCommonBit());
            Assert.AreEqual(0, new Binary("00101010").GetMostCommonBit());
        }


    }
}
