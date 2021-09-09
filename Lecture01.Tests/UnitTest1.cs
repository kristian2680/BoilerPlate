using System;
using Xunit;
using Lecture01;
using System.IO;

namespace Lecture01.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test_IsLeapYear_with_4_returns_true(){
            //arrange
            var expected = true;
            //act
            var actual = new Program().IsLeapYear(1600);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_IsLeapYear_False_IfExactlyDivisibleBy100(){
            //arrange
            var expected =false;
            //act
            var actual = new Program().IsLeapYear(1700);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_IsLeapYear_True_IfExactlyDivisibleBy400(){
            //arrange
            var expected =true;
            //act
            var actual = new Program().IsLeapYear(2000);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_ThrowException_If_lessThan_1582(){
            Assert.Throws<Exception>(() => new Program().IsLeapYear(1580));
        }

        [Fact]
        public void Test_ThrowException_If_User_inputs_something_that_insnt_an_int(){
            Console.SetIn(new StringReader("Hej"));
            Assert.Throws<Exception>(() => Program.Main(new string [0]));
        }
    }
}
