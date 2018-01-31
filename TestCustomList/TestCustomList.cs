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

        [TestMethod]
        public void Remove_OneOfFourInts_ListWithThreeInts()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Remove(1);
            //Assert
            Assert.AreEqual(customList.Count, 3);
        }

        [TestMethod]
        public void Remove_NumberThree_ListOneTwoFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Remove(3);
            //Assert
            Assert.AreEqual(customList.array[2], 4);
        }

        [TestMethod]
        public void Remove_OneStringFromList_ListWithThreeStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            customList.Remove("One");
            //Assert
            Assert.AreEqual(customList.Count, 3);
        }

        [TestMethod]
        public void Remove_OneStringFromList_BoolEqualsTrue()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            bool answer = customList.Remove("One");
            //Assert
            Assert.AreEqual(answer, true);
        }

        [TestMethod]
        public void Remove_OneStringFromList_BoolEqualsFalse()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            //Act
            customList.Add("One");
            customList.Add("Two");
            customList.Add("Three");
            customList.Add("Four");
            bool answer = customList.Remove("Steve");
            //Assert
            Assert.AreEqual(answer, false);
        }

        [TestMethod]
        public void Zip_TwoListsTogether_OneZippedList()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            customList1.Add("One");
            customList1.Add("Three");
            customList1.Add("Five");
            customList1.Add("Seven");
            customList2.Add("Two");
            customList2.Add("Four");
            customList2.Add("Six");
            customList2.Add("Eight");
            CustomList<string> result = CustomList<string>.Zip(customList1, customList2);
            //Assert
            Assert.AreEqual(result.array[1], "Two");
        }

        [TestMethod]
        public void Zip_TwoListsTogether_LengthIsListOnePlusListTwo()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            customList1.Add("One");
            customList1.Add("Three");
            customList1.Add("Five");
            customList1.Add("Seven");
            customList2.Add("Two");
            customList2.Add("Four");
            customList2.Add("Six");
            customList2.Add("Eight");
            CustomList<string> result = CustomList<string>.Zip(customList1, customList2);
            //Assert
            Assert.AreEqual(result.array.Length, 8);
        }

        [TestMethod]
        public void Zip_TwoIntListsTogether_OneZippedList()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            //Act
            customList1.Add(1);
            customList1.Add(3);
            customList1.Add(5);
            customList1.Add(7);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList2.Add(8);
            CustomList<int> result = CustomList<int>.Zip(customList1, customList2);
            //Assert
            Assert.AreEqual(result.array[1], 2);
        }

        [TestMethod]
        public void Iterate_ListOfStrings_IntoAString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string sentence = "";
            string result = "I went to the store after work ";

            //Act
            customList.Add("I");
            customList.Add("went");
            customList.Add("to");
            customList.Add("the");
            customList.Add("store");
            customList.Add("after");
            customList.Add("work");
            foreach (string word in customList)
            {
                sentence += word + " ";
            }

            //Assert
            Assert.AreEqual(sentence, result);
        }

        [TestMethod]
        public void Iterate_ListOfInts_IntoTotal()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int total = 0;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            foreach (int number in customList)
            {
                total = total + number;
            }

            //Assert
            Assert.AreEqual(total, 28);
        }

        [TestMethod]
        public void ListOfInts_ConvertedIntoString_CombinedString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            string endString = "";

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            endString = customList.ToString();

            //Assert
            Assert.AreEqual(endString, "1234567");
        }

        [TestMethod]
        public void ListOfStrings_ConvertedIntoOneString_CombinedString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string endString = "";

            //Act
            customList.Add("C");
            customList.Add("H");
            customList.Add("A");
            customList.Add("D");
            endString = customList.ToString();

            //Assert
            Assert.AreEqual(endString, "CHAD");
        }

        [TestMethod]
        public void Plus_TwoListsTogether_CountEqualsListOnePlusListTwo()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            customList1.Add("One");
            customList1.Add("Three");
            customList1.Add("Five");
            customList1.Add("Seven");
            customList2.Add("Two");
            customList2.Add("Four");
            customList2.Add("Six");
            customList2.Add("Eight");
            CustomList<string> result = new CustomList<string>();
            result = customList1 + customList2;
            //Assert
            Assert.AreEqual(result.count, 8);
        }

        [TestMethod]
        public void Plus_TwoListsTogether_ThirdListIndexFourIsListTwoIndexZero()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            customList1.Add("One");
            customList1.Add("Three");
            customList1.Add("Five");
            customList1.Add("Seven");
            customList2.Add("Two");
            customList2.Add("Four");
            customList2.Add("Six");
            customList2.Add("Eight");
            CustomList<string> result = new CustomList<string>();
            result = customList1 + customList2;
            //Assert
            Assert.AreEqual(result.array[4], "Two");
        }

        [TestMethod]
        public void MinusStrings_OneListFromAnother_ThirdListEqualsFirstMinusSecond()
        {
            //Arrange
            CustomList<string> customList1 = new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            //Act
            customList1.Add("One");
            customList1.Add("Two");
            customList1.Add("Three");
            customList1.Add("Four");
            customList2.Add("One");
            customList2.Add("Three");

            CustomList<string> result = new CustomList<string>();
            result = customList1 - customList2;
            //Assert
            Assert.AreEqual(result.array[0], "Two");
        }

        [TestMethod]
        public void MinusInts_OneListFromAnother_ThirdListEqualsFirstMinusSecond()
        {
            //Arrange
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            //Act
            customList1.Add(1);
            customList1.Add(2);
            customList1.Add(3);
            customList1.Add(4);
            customList2.Add(1);
            customList2.Add(3);

            CustomList<int> result = new CustomList<int>();
            result = customList1 - customList2;
            //Assert
            Assert.AreEqual(result.array[0], 2);
        }
    }
}
