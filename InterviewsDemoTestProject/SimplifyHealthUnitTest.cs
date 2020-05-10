using System;
using InterviewDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace InterviewsDemoTestProject {
    [TestClass]
    public class SimplifyHealthUnitTest {
        [TestMethod()]
        public void GetSelctionChancesTest() {
            var mockSimplifyTest = new Mock<SimplifyHealthCareTest>();

            Action act = () => {
                var sut = new SimplifyHealthCareTest();
                Assert.AreEqual(new int[] { 0, 0, 2, 0, 3 }, sut.GetSelctionChances(5, new int[] { 3, 4, 1, 5, 2 }));
                Assert.AreEqual(new int[] { 0, 0, 1, 3, 4, 0 }, sut.GetSelctionChances(6, new int[] { 4, 9, 5, 3, 2, 10 }));
                Assert.AreEqual(new int[] { 0, 0, 2, 3, 4, 5, 6, 7, 8, 9 }, sut.GetSelctionChances(10, new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));

            };
        }
    }
}
