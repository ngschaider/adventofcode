using AdventOfCode.Year2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AdventOfCode.Tests {
    [TestClass]
    public class Year2021 {

        [TestMethod]
        public async Task Day01() {
            await Helpers.AssertDay<Day01>(1715, 1739);
        }

        [TestMethod]
        public async Task Day02() {
            await Helpers.AssertDay<Day02>(1947824, 1813062561);
        }

        [TestMethod]
        public async Task Day03() {
            await Helpers.AssertDay<Day03>(3309596, 2981085);
        }
    }
}
