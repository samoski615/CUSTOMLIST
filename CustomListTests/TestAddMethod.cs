using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class TestAddMethod
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
         //numbers.Add(1);
         actual = numbers[0];
            
         //assert
         Assert.AreEqual(expected, actual);
        

        }


    [TestMethod]
    public void Add_AddToPopulatedList_ItemGoesToEndOfIndex()
    {
             //arrange
             numbers = new CustomList<int>();
             int expected = 1;
             int actual;

             //act
             //numbers.Add(1);
             //numbers.Add(2);
             actual = numbers[1];

             //assert
             Assert.AreEqual(expected, actual);
    }


        //[TestMethod]
        //public void Add_AddToPopulatedList_ItemGoesToSpecificIndex()
        //{
        //    //arrange
        //    numbers = new CustomList<int>();

        //    //act

        //    //assert


        //}


        







    }

}

