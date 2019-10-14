using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class ToStringUnitTests
    {
        CustomList<int> numbers;

        [TestMethod]
        public void GetString_GetStringIfListItemIsInt_GotString()
        {
            //assign
            numbers = new CustomList<int>() { 1, 2 };
            string expected = "1, 2";
            string actual;

            //act
            actual = numbers.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
