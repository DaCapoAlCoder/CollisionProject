using System;

namespace Animate
{
    /// <summary>
    /// Model contains main logic (action requests) and data
    /// that describes a ball
    /// </summary>
    public interface IBallModel
    {
        /// <summary>
        /// The actual floating point position of the ball in the simulation
        /// </summary>
        double centreActualX { get; set; }

        /// <summary>
        /// The actual floating point position of the ball in the simulation
        /// </summary>
        double centreActualY { get; set; }

        /// <summary>
        /// The size of the ball described as a radius
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// The velocity of the ball in the X direction
        /// </summary>
        double XVelocity { get; set; }
        
        /// <summary>
        /// The velocity of the ball in the Y direction
        /// </summary>
        double YVelocity { get; set; }

        /// <summary>
        /// Makes a request for the collision detector to 
        /// determine of the ball has collided with something
        /// </summary>
        event EventHandler CollisionDectectionRequest;

        /// <summary>
        /// Makes a  request for he motion model to move the ball
        /// </summary>
        event EventHandler MoveRequest;

        /// <summary>
        /// Makes a  request for the ball to be redrawn on the canvas
        /// </summary>
        event EventHandler RedrawRequest;

        /// <summary>
        /// Method that invokes the motion, collision and redraw requests
        /// </summary>
        void Move();
    }
}