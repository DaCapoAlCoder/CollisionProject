using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class BallModel : IBallModel
    {
        private int _radius;
        private double _xVelocity;
        private double _yVelocity;
        private double _centreActualX;
        private double _centreActualY;

        /// <summary>
        /// Model contains the core data and functionality of a ball in the simulation
        /// </summary>
        public BallModel()
        {
            _xVelocity = 1;
            _yVelocity = 1;
            _centreActualX = 50;
            _centreActualY = 50;
            _radius = 25;
        }

        #region Properties
        /// <summary>
        /// X Component of the ball's veleocity
        /// </summary>
        public double XVelocity
        {
            set => _xVelocity = value;
            get => _xVelocity;
        }

        /// <summary>
        /// Y Component of the ball's veleocity
        /// </summary>
        public double YVelocity
        {
            set => _yVelocity = value;
            get => _yVelocity;
        }

        /// <summary>
        /// The actual (floating point) X position of the ball on the canvas
        /// </summary>
        public double centreActualX 
        {
            get => _centreActualX;
            set => _centreActualX = value;
        }

        /// <summary>
        /// The actual (floating point) Y position of the ball on the canvas
        /// </summary>
        public double centreActualY
        {
            get => _centreActualY;
            set => _centreActualY = value;
        }

        /// <summary>
        /// The ball's radius
        /// </summary>
        public double Radius => _radius;
        #endregion Properties

        #region events
        /// <summary>
        /// Event triggers each time the ball wants to be moved
        /// </summary>
        public event EventHandler MoveRequest;
        /// <summary>
        /// Event should trigger after each move to determine if the ball has collided with something
        /// </summary>
        public event EventHandler CollisionDectectionRequest;

        /// <summary>
        /// Event should trigger after each move to tell the canvas to redraw it on screen
        /// </summary>
        public event EventHandler RedrawRequest;
        #endregion events

        #region methods
        /// <summary>
        /// Final method in updating the ball's position
        /// </summary>
        public void Move()
        {
            BallMoveRequest();
            BallCollisionDetectionRequest();
            BallRedrawRequest();
        }

        /// <summary>
        /// Fires the ball moved event
        /// </summary>
        private void BallMoveRequest()
        {
            MoveRequest?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Firest the event to determine if the ball has collided with anything
        /// </summary>
        private void BallCollisionDetectionRequest()
        {
            CollisionDectectionRequest?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Requests that the ball is redrawn on the canvas
        /// </summary>
        private void BallRedrawRequest()
        {
            RedrawRequest?.Invoke(this, EventArgs.Empty);
        }
        #endregion methods
    }
}
