using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Animate;

namespace Tests
{
    [TestClass]
    public class TestMotionModel
    {
        [TestMethod]
        public void MotionModelChangesPosition()
        {
            //Arrange
            MotionModel motionModel = new MotionModel();
            IBall mockBall = MockRepository.GenerateMock<IBall>();
            mockBall.Stub(x => x.XVelocity).Return(25);
            mockBall.Stub(x => x.YVelocity).Return(25);
            mockBall.Stub(x => x.centreActualX).Return(100);
            mockBall.Stub(x => x.centreActualY).Return(100);
            //mockBall.Stub(x => x.SimulationTime).Return(0.1);

            //Act
            //motionModel.ApplyMotionModel(mockBall);

            //Assert
            Assert.AreEqual(motionModel.centreActualX,102.5);
            Assert.AreEqual(motionModel.centreActualY,102.5);
        }
    }
}
