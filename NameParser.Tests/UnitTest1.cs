using System;
using NameParser;
using Xunit;

namespace NameParser.Tests
{
    public class NameParsingTests
    {
        [Fact]
        public void MartisNameShouldBeParsedAccurately()
        {
            //Arrangea
            var name = "Martin Cross";
            var parser = new Parser();
            //Act
            var result = parser.ParseName(name);

            //Assert
            Assert.Equal("Martin",result.FirstName);
            Assert.Equal("Cross",result.LastName);
        }
        [Fact]
        public void ThreePartNamesShouldBeParsedAccurately()
        {
            //Arrange
            var name = "Martic Zachariah Cross";
            var parser = new Parser();
            //Act
            //Assert
        }
    }
}
