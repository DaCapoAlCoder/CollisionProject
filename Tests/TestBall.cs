using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Animate;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace Tests
{
    [TestClass]
    public class TestBall
    {

        [TestMethod]
        public void BallMoves()
        {
            IEllipseAdapter mockEllipse = MockRepository.GenerateMock<IEllipseAdapter>();
            bool motionRequest = false;
            bool collisionDetectionRequest = false;
            bool ballRedrawRequest = false;

            //Arrange
            Ball ball = new Ball(mockEllipse);
            mockEllipse.Height = 50;
            mockEllipse.Width = 50;
            ball.MoveRequest += delegate (object sender, EventArgs args)
            {
                motionRequest = true;
            };
            ball.CollisionDectectionRequest += delegate (object sender, EventArgs args)
            {
                collisionDetectionRequest = true;
            };

            ball.CollisionDectectionRequest += delegate (object sender, EventArgs args)
            {
                ballRedrawRequest = true;
            };

            ball.MoveRequest += Ball_MoveRequest;

            //Act
            ball.Move();

            //Assert
            Assert.IsTrue(motionRequest);
            Assert.IsTrue(collisionDetectionRequest);
            Assert.IsTrue(ballRedrawRequest);
        }

        public void Ball_MoveRequest(object sender, EventArgs e)
        {

        }
    }
}
