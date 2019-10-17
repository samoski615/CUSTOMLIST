using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTests
{
    [TestClass]
    public class ToStringUnitTests
    {
      

        [TestMethod]
        public void GetString_GetStringIfListItemIsInt_GotString()
        {
            //assign
            CustomList<int> numbers = new CustomList<int>() { 1, 2 };
            string expected = "1, 2";
            string actual;

            //act
            actual = numbers.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void GetString_GetStringIfListHasIsString_GotString()
        {
            //assign
            CustomList<string> words = new CustomList<string>() { "list", "strings" };
            string expected = "list, strings";
            string actual;

            //act
            actual = words.ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetString_GetStringIfListHasBool_GotString()
        {
            //assign
            CustomList<bool> isTrue = new CustomList<bool>();
            string expected = "true";
            string actual;

            //act
            isTrue.Add(true);
            actual = isTrue.ToString().ToLower();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
