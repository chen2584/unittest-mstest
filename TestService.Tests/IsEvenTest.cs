using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestService.Tests
{
    [TestClass]
    public class TestService_IsEven {
        private readonly TestService _testService;
        public TestService_IsEven() {
            _testService = new TestService();
        }
        /*[TestMethod]
        public void ReturnIsEven() {
            var result = _testService.IsEven(2);
            Assert.IsTrue(result, "2 is even");
        }

        [TestMethod]
        public void ReturnIsOdd() {
            var result = _testService.IsEven(3);
            Assert.IsFalse(result, "3 is odd");
        }*/

        [DataTestMethod]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        public void ReturnIsEven(int value) {
            var result = _testService.IsEven(value);
            Assert.IsTrue(result, $"{value} is Even");
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        public void ReturnIsOdd(int value) {
            var result = _testService.IsEven(value);
            Assert.IsFalse(result, $"{value} is Odd");
        }


    }

    /*[TestClass]
    public class TestChen {
        private readonly TestService _testService;
        public TestChen() {
            _testService = new TestService();
        }
        /[TestMethod]
        public void ReturnIsEven() {
            var result = _testService.IsEven(2);
            Assert.IsTrue(result, "2 is even");
        }

        [DataTestMethod]
        [DataRow(4)]
        [DataRow(6)]
        [DataRow(8)]
        public void ReturnIsEven(int value) {
            var result = _testService.IsEven(value);
            Assert.IsTrue(result, $"{value} is Even");
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(5)]
        [DataRow(7)]
        public void ReturnIsOdd(int value) {
            var result = _testService.IsEven(value);
            Assert.IsFalse(result, $"{value} is Odd");
        }


    }*/
}