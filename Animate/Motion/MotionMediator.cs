using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    /// <summary>
    /// Mediator between the ball and the motion model
    /// </summary>
    public class MotionMediator
    {
        ///// <summary>
        ///// Object in the simulation
        ///// </summary>
        //private IBall _ball;

        /// <summary>
        /// Model that describes the motion of a simulation object
        /// </summary>
        private IMotionModel _motionModel;
        private IBallModel _ballModel;

        ///// <summary>
        ///// Mediator between the ball and the motion model
        ///// </summary>
        //public MotionMediator(IMotionModel motionModel, IBall ball)
        //{
        //    _ball = ball;
        //    _ball.MoveRequest += OnBallMoveRequest;
        //    _motionModel = motionModel;
        //}

        /// <summary>
        /// Mediator between the ball and the motion model
        /// </summary>
        public MotionMediator(IMotionModel motionModel, IBallModel ballModel)
        {
            _ballModel = ballModel;
            _motionModel = motionModel;
            _ballModel.MoveRequest += OnBallMoveRequest;
        }

        private void OnBallMoveRequest(object sender, EventArgs e)
        {
            _motionModel.ApplyMotionModel(_ballModel.XVelocity, _ballModel.YVelocity, _ballModel.centreActualX, _ballModel.centreActualY);
            _ballModel.centreActualX = _motionModel.centreActualX;
            _ballModel.centreActualY = _motionModel.centreActualY;
        }

        //private void OnBallMoveRequest(object sender, EventArgs e)
        //{
        //    _motionModel.ApplyMotionModel(_ball.XVelocity, _ball.YVelocity, _ball.centreActualX, _ball.centreActualY);
        //    _ball.centreActualX = _motionModel.centreActualX;
        //    _ball.centreActualY = _motionModel.centreActualY;
        //}
    }
}
