using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo.Tests
{
    [TestClass()]
    public class ComputeGradeTests
    {
        [TestMethod()]
        public void GetGradeTest()
        {
            //Arrange
            int score = 43;
            string expectedGrade = "E";
            //Act
            var comp = new ComputeGrade();
            var rtnGrade = comp.GetGrade(score);

            //Assert
            Assert.AreEqual(expectedGrade, rtnGrade);

        }
    }
}