using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class ZipUnitTests
    {
        [TestMethod]
        public void Zip_ZipTwoListsTogether_ListsAreZipped()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 6;
            int actual;

            //act
            resultsList = CustomList<int>.Zip(listOne, listTwo);
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipSmallerListWithLargerList_ListsAreZipped()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6, 7, 8};
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 10;
            int actual;

            //act
            resultsList = CustomList<int>.Zip(listOne, listTwo);
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipLargerListWithSmallerList_ListsAreZipped()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 6, 7, 8 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 10;
            int actual;

            //act
            resultsList = CustomList<int>.Zip(listOne, listTwo);
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipPopulatedListWithEmptyList_ListStaysTheSame()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 5;
            int actual;

            //act
            resultsList = CustomList<int>.Zip(listOne, listTwo);
            actual = resultsList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_CheckIndexOfZippedItems_ItemsAtCorrectIndexAfterZippingLists()
        {
            //arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            resultsList = CustomList<int>.Zip(listOne, listTwo);
            actual = resultsList[4];

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
