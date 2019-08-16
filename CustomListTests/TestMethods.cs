using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
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


        //[TestMethod]
        //public void Add_AddToPopulatedList_ItemGoesToSpecificIndex()
        //{
        //    //arrange
        //    numbers = new CustomList<int>();
        //    int expected = 5;
        //    int actual;

        //    //act
            
        //    //assert


        //}

        //[TestMethod]
        //public void Add_IncreaseCapacityOfArray_ArrayCapacityIsDoubled()
        //{
        //    //arrange
        //    int count = 2;
        //    int capacity = 2;

        //    //act



        //}

        [TestMethod]
        public void Subtract_ReplaceItemFromArray_ArrayItemIsReplaced()
        {
            //arrange
            numbers = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            numbers.Add(3);
            numbers.Add(1);
            numbers.RemoveAndReplace(1);

            actual = numbers[0];

            //assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Remove_RemoveItemFromArray_ArrayItemIsRemoved()
        //{
        //    //arrange
        //    numbers = new CustomList<int>();
        //    int expected = 3;
        //    int actual;

        //    //act
        //    numbers.Add(3);
        //    numbers.Add(4);
        //    numbers.Remove(1);

        //    actual = numbers[0];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}









    }

}

