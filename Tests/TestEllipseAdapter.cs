using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animate;
using System.Windows.Shapes;
using System.Windows.Media;

namespace Tests
{
    [TestClass]
    public class TestEllipseAdapter
    {
        [TestMethod]
        public void EllipseInitialisesFillAsBlue()
        {

            //Arrange
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            
            //Act
            EllipseAdapter ellipseAdapter = new EllipseAdapter(new Ellipse());

            var color = (SolidColorBrush)ellipseAdapter.Fill;

            //Assert
            Assert.AreEqual(color.Color, brush.Color);

        }
    }
}
