using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class RemoveFromList
    {
        [TestMethod]
        public void RemoveFromList_RemoveNumberFromList_ListReturnedWithoutNumber()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 2;
            int actual;

            //act
            resultsList = listOne - listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFromList_RemoveMultipleNumbersFromList_ListReturnedWithoutDuplicateNumbers()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 3, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            resultsList = listOne - listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFromList_CheckIndexOfItemAfterRemovalOfNumberFromList_IndexIsCorrect()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            resultsList = listOne - listTwo;
            actual = resultsList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveFromList_NoMatchesInList_NoItemsGetRemovedFromList()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            resultsList = listOne - listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
