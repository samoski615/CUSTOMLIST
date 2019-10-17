using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;
namespace CustomList
{

    class AdditionUnitTests
    {
        [TestClass]
        public class TestMethods
        {
            CustomList<int> numbers;

            [TestMethod]
            public void Add_AddToEmptyList_ItemGoesToIndexZero()
            {
                //arrange
                numbers = new CustomList<int>();

                int expected = 1;
                int actual;

                //act
                numbers.Add(1);
                actual = numbers[0];

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Add_AddToPopulatedList_ItemGoesToEndOfIndex()
            {
                //arrange
                numbers = new CustomList<int>();
                int expected = 2;
                int actual;

                //act
                numbers.Add(1);
                numbers.Add(2);

                actual = numbers[1];

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Add_AddItemsToFullList_ListExpandsToTakeNewItems()
            {
                //***This also tests the IncreaseArrayCapacity() method***//

                //arrange
                numbers = new CustomList<int>() { 1, 2, 3, 4, 5 };
                int expected = 5;
                int actual;

                //act
                actual = numbers[4];

                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Add_TestAddingPastInitialCapacity_TakeInitalValuesAndPutInNewArray()
            {
                //arrange
                numbers = new CustomList<int>() { 1, 2, 3, 4, 5 };
                int expected = 4;
                int actual;

                //act
                actual = numbers[3];

                //assert
                Assert.AreEqual(expected, actual);
            }

        }

    }

}
