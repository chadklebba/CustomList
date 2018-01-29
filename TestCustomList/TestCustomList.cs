using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace TestCustomList
{
    [TestClass]
    public class TestCustomList
    {
        [TestMethod]
        public void Add_TwoInts_ListWithTwoInts()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(1);
            customList.Add(2);
            //Assert
            Assert.AreEqual(customList.Count, 2);
        }
   
        [TestMethod]
        public void Add_TwoIntsToExistingList_ListWithFourInts()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            //Assert
            Assert.AreEqual(customList.Count, 4);
        }

        [TestMethod]
        public void Add_TwoIntsToExistingList_ThirdNumberSecondIndex()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            //Assert
            Assert.AreEqual(customList.array[2], 3);
        }

        [TestMethod]
        public void Add_TwoStrings_ListWithTwoStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            //Assert
            Assert.AreEqual(customList.Count, 2);
        }

        [TestMethod]
        public void Add_TwoStrings_ListWithFourStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            //Assert
            Assert.AreEqual(customList.Count, 4);
        }

        [TestMethod]
        public void Add_TwoStrings_ThirdStringSecondIndex()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            //Assert
            Assert.AreEqual(customList.array[2], "Three");
        }

        //[TestMethod]
        //public void Remove_OneOfFourInts_ListWithThreeInts()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>() { 1, 2, 3, 4 };
        //    //Act
        //    customList.Remove(1);
        //    //Assert
        //    Assert.AreEqual(customList.Count, 3);
        //}
    }
}
