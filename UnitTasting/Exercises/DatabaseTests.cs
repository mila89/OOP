using NUnit.Framework;
using System.Linq;
using System;

namespace Tests
{
    public class DatabaseTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldThrowExceptionWhenAddingElementMoreThan16()
        {
            // Assert.Pass();
            Database data = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            //Arange


            //Act

            //Assert
            Assert.That(() => data.Add(17), Throws.InvalidOperationException.
                With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void ShouldAddElementAtTheNextFreeCell()
        {
            //Arange
            Database data = new Database(Enumerable.Range(1, 10).ToArray());

            //Act
            data.Add(5);
            var result = data.Fetch();

            //Assert
            var expectedResult = 5;
            var actualResult = result[10];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TestConstructor()
        {
            //Arange
            int[] numbers = Enumerable.Range(1, 16).ToArray();
            //Act
            Database data = new Database(numbers);
            //Assert
            Assert.AreEqual(data.Count, 16);
        }

        public void ConstructorShouldThrowExceptionWhenIsMoreThan16Integers()
        {
            //TODO later
            //Arange
            int[] numbers = Enumerable.Range(1, 17).ToArray();
            //Act
            Database data = new Database(numbers);
            //Assert
            // Assert.AreEqual(data.Count, 16);
        }

        [Test]
        public void RemoveOperationShouldRemoveElementAtTheLastIndex()
        {
            //Arange
            Database data = new Database(Enumerable.Range(1, 10).ToArray());

            //Act
            data.Remove();
            var resultArray = data.Fetch();

            //Assert
            var expectedResult = 9;
            var actualResult = resultArray[resultArray.Length - 1];
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ShouldThrowExceptionWhenRemoveElementFromEmptyDatabase()
        {
            //Arrange
            Database data = new Database();

            //Act Assert

            Assert.Throws<InvalidOperationException>(() => data.Remove());

        }

        [Test]
        public void FetchMethodShouldReturnElementsAsArray()
        {
            //Arrange
            Database data = new Database(Enumerable.Range(1, 10).ToArray());

            //Act
            var result = data.Fetch();
            int[] expected =Enumerable.Range(1, 10).ToArray();

            //Assert
            CollectionAssert.AreEqual(result, expected);
            //Assert.AreEqual(result, expected);

        }
    }
}