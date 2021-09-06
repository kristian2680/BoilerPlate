using System;
using Xunit;
using Lecture01;

namespace Lecture01.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test_LeapYear2_with_4_returns_true(){
            //arrange
            var expected = true;
            //act
            var actual = new Program().LeapYear2(4);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_IsLeapYear3_False_IfExactlyDivisibleBy100(){
            //arrange
            var expected =false;
            //act
            var actual = new Program().IsLeapYear3(1700);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_IsLeapYear_True_IfExactlyDivisibleBy400(){
            //arrange
            var expected =true;
            //act
            var actual = new Program().IsLeapYear(1600);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
