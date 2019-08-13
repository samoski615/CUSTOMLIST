using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        readonly CustomList<int> numbers = new CustomList<int>();

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            //arrange
            int expected = 5;
            int actual;

            //act
            numbers.Add(5);
            actual = numbers.Add[0];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_AddToPopulatedList_ItemGoesToEndOfIndex()
        {
            //arrange
            int expected = 5;
            int actual;
            
            //act
            numbers.Add(5);
            numbers.Add(6);
            actual = 

            //assert
            Assert.AreEqual(expected, actual);

        }

    }
}
