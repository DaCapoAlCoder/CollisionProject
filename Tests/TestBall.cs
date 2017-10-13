using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Animate;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;

namespace Tests
{
    [TestClass]
    public class TestBall
    {
        [TestMethod]
        public void BallMoves()
        {
            //IEllipseAdapter mockEllipse = MockRepository.GenerateMock<IEllipseAdapter>();
            //ICanvasAdapter mockCanvas = MockRepository.GenerateMock<ICanvasAdapter >();
            //IMotionModel mockMotion = MockRepository.GenerateMock<IMotionModel>();
            ////Ball ball = new Ball(mockCanvas, mockEllipse );

            ////Arrange
            //mockMotion.Stub(x => x.centreActualX).Return(100.1);
            //mockMotion.Stub(x => x.centreActualY).Return(100.1);
            //mockEllipse.Height = 25;
            //mockEllipse.Width = 25;

            ////Act
            //ball.Move();

            ////Assert
            //Assert.AreEqual(ball.centreActualX, 100.1);
            //Assert.AreEqual(ball.centreActualY, 100.1);
            //Assert.AreEqual(ball.PosPixelX, 100);
            //Assert.AreEqual(ball.PosPixelY, 100);
            //mockCanvas.AssertWasCalled(x => x.SetLeft(Arg<UIElement>.Is.Anything, Arg<double>.Is.Anything));
            //mockCanvas.AssertWasCalled(x => x.SetTop(Arg<UIElement>.Is.Anything, Arg<double>.Is.Anything));
        }
    }
}
