using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Animate {

    /// <summary>
    /// Describes the ball used in the simulation
    /// </summary>
    public class Ball : IBall
    {
        private int _radius;
        private double _xVelocity;
        private double _yVelocity;
        private double _centreActualX;
        private double _centreActualY;
        private IEllipseAdapter _ellipseAdapter;

        /// <summary>
        /// Describes a Ball used as the shape to be animated in the collision simulator
        /// </summary>
        public Ball(IEllipseAdapter ellipseAdapater)
        {
            _xVelocity = 1;
            _yVelocity = 1;
            _centreActualX = 50;
            _centreActualY = 50;
            _radius = 25;
            _ellipseAdapter = ellipseAdapater;
            _ellipseAdapter.Height = 2 *_radius;
            _ellipseAdapter.Width = 2 * _radius;
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
        /// Gets the shape used to describe the ball
        /// </summary>
        public UIElement Shape => _ellipseAdapter.Shape;

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
        /// The balls Y position rounded to a pixel value
        /// </summary>
        public double PosPixelY => Math.Floor(EnclosingRectTop);

        /// <summary>
        /// The ball's X position rounded to a pixel value
        /// </summary>
        public double PosPixelX => Math.Floor(EnclosingRectLeft);

        /// <summary>
        /// The ball's radius
        /// </summary>
        public double Radius => _radius;

        /// <summary>
        /// The position of the top surface of an imaginary bounding box on the ball
        /// </summary>
        public double EnclosingRectTop => _centreActualY - Radius;
        /// <summary>
        /// The position of the bottom surface of an imaginary bounding box on the ball
        /// </summary>
        public double EnclosingRectBottom => _centreActualY + Radius;

        /// <summary>
        /// The position of the left surface of an imaginary bounding box on the ball
        /// </summary>
        public double EnclosingRectLeft => _centreActualX - Radius;

        /// <summary>
        /// The position of the right surface of an imaginary bounding box on the ball
        /// </summary>
        public double EnclosingRectRight => _centreActualX + Radius;
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
    }
}
