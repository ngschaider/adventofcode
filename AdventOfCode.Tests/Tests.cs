using AdventOfCode.Year2021;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AdventOfCode.Tests {
    [TestClass]
    public class Tests {
        [TestMethod]
        public async Task Year2021() {
            await Helpers.AssertDay<Day01>(1715, 1739);
        }
    }
}
