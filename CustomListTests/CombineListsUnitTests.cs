using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class CombineListsUnitTests
    {
        [TestMethod]
        public void CombineTwoLists_CombineTwoListsTogether_ListsCombine()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> listTwo = new CustomList<int>() { 5, 6, 7, 8 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            resultsList = listOne + listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_CombineAFullListWithAnEmptyList_ListsCombine()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            resultsList = listOne + listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_CombineListsOfDifferentSizes_ListsCombine()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> listTwo = new CustomList<int>() { 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 6;
            int actual;

            //act
            resultsList = listOne + listTwo;
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CombineTwoLists_CheckIndexOfItemsInList_ItemInListAtCorrectIndex()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> listTwo = new CustomList<int>() { 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            resultsList = listOne + listTwo;
            actual = resultsList[3];

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
