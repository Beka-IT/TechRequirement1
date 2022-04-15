using System;
using Task.Figures;
using Task.Helpers;
using Xunit;
namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CheckGreetingWord()
        {
            FigureManager figureManager = new FigureManager();
 
            // Act
            var result = figureManager.GetGreetingWord();
            // Assert
            Assert.Equal("Добро пожаловать!", result);
        }
        [Fact]
        public void CheckTriangleGetAreaMethod()
        {
            Triangle triangle = new Triangle();
            triangle.SetValues(3,4,5);

            var result = triangle.GetArea();

            Assert.Equal(6, result);
        }
        [Fact]
        public void CheckCircleGetAreaMethod()
        {
            Circle circle = new Circle();
            circle.SetValues(4);

            var result = circle.GetArea();

            Assert.Equal(12.6, result);
        }
    }
}
