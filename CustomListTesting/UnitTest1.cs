using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTesting
{
    [TestClass]
    public class CustomListTesting
    {
        private CustomList<T> numbers = new CustomList<T>();


        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            //arrange
            CustomList<int> numbers = new CustomList<int>();
            int expected = 5;
            int actual;

            //act
            numbers.Add(5);
            actual = Add[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        
           
    }
}

