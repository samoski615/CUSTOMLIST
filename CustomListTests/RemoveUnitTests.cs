using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class RemoveUnitTests
    {

        CustomList<int> numbers;

        [TestMethod]
        public void Remove_ReplaceItemFromArray_ArrayItemIsReplaced()
        {
            //arrange
            numbers = new CustomList<int>() { 1, 2, 3 };
            int expected = 3;
            int actual;

            //act
            numbers.RemoveAndReplace(2);
            actual = numbers[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_RemoveItemFromArray_ArrayItemIsRemoved()
        {
            //arrange
            numbers = new CustomList<int>() { 1, 2, 3, 4 };
            int expected = 2;
            int actual;

            //act
            numbers.RemoveAndReplace(1);
            actual = numbers[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ValueRemovedFromArray_ListShrinksBelowStartingCapacity()
        {
            //arrange
            numbers = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 8;
            int actual;

            //act
            numbers.RemoveAndReplace(5);
            actual = numbers.Capacity;

            //assert
            Assert.AreEqual(expected, actual);          
        }

    }


}



