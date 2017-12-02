using System;
using System.Windows;
using System.Windows.Shapes;

namespace Animate
{
    /// <summary>
    /// Describes the ball used in the simulation
    /// </summary>
    public interface IBall
    {
        /// <summary>
        /// The actual (floating point) X position of the ball on the canvas
        /// </summary>
        double centreActualX { get; set; }

        /// <summary>
        /// The actual (floating point) Y position of the ball on the canvas
        /// </summary>
        double centreActualY { get; set; }

        /// <summary>
        /// The ball's X positin rounded to a pixel value
        /// </summary>
        double PosPixelX { get; }

        /// <summary>
        /// The balls Y position rounded to a pixel value
        /// </summary>
        double PosPixelY { get; }

        /// <summary>
        /// The ball's radius
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// Gets the shape used to describe the ball
        /// </summary>
        UIElement Shape { get; }

        /// <summary>
        /// X Component of the ball's veleocity
        /// </summary>
        double XVelocity { get; set; }

        /// <summary>
        /// Y Component of the ball's veleocity
        /// </summary>
        double YVelocity { get; set; }

        /// <summary>
        /// The position of the top surface of an imaginary bounding box on the ball
        /// </summary>
        double EnclosingRectTop { get; }

        /// <summary>
        /// The position of the left surface of an imaginary bounding box on the ball
        /// </summary>
        double EnclosingRectLeft { get; }

        /// <summary>
        /// The position of the right surface of an imaginary bounding box on the ball
        /// </summary>
        double EnclosingRectRight { get; }

        /// <summary>
        /// The position of the bottom surface of an imaginary bounding box on the ball
        /// </summary>
        double EnclosingRectBottom { get; }

        /// <summary>
        /// Final method in updating the ball's position
        /// </summary>
        void Move();

        /// <summary>
        /// Event fires when ball requests to be moved
        /// </summary>
        event EventHandler MoveRequest;

        /// <summary>
        /// Event fires after the ball has moved and wants to see if it has collided with anything
        /// </summary>
        event EventHandler CollisionDectectionRequest;

        /// <summary>
        /// Event should trigger after each move to tell the canvas to redraw it on screen
        /// </summary>
        event EventHandler RedrawRequest;

    }
}