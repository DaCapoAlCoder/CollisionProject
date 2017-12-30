using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Animate
{
    /// <summary>
    /// The model that describes an objects motion
    /// </summary>
    public class MotionModel : IMotionModel
    {
        private double _xVelocity;
        private double _yVelocity;
        private double _centreActualX;
        private double _centreActualY;

        /// <summary>
        /// The time between each tick of the simluation
        /// </summary>
        public double SimulationTime { get => 1.0; }

        /// <summary>
        /// The actual double precision x position of the object 
        /// </summary>
        public double centreActualX { get => _centreActualX; set => _centreActualX = value; }

        /// <summary>
        /// The actual double precision y position of the object 
        /// </summary>
        public double centreActualY { get => _centreActualY; set => _centreActualY = value; }

        /// <summary>
        /// Model that describes the motion of an object in the simulation
        /// </summary>
        public MotionModel()
        {
            _xVelocity = Double.NaN;
            _yVelocity = Double.NaN;
            _centreActualX = Double.NaN;
            _centreActualY = Double.NaN;
        }

        /// <summary>
        /// Takes the necessary speed and location data from an object and returns the next position
        /// </summary>
        public void ApplyMotionModel(double xVelocity, double yVelocity, double centreActualX, double centreActualY)
        {
            //TODO: Throw exception if any parameters are NaN
            _xVelocity = xVelocity;
            _yVelocity = yVelocity;
            _centreActualX = centreActualX;
            _centreActualY = centreActualY;
            //SetNextPosition();
        }

        /// <summary>
        /// Takes the necessary speed and location data from an object and returns the next position
        /// </summary>
        public void ApplyMotionModel(IBallModel ball)
        {
            _xVelocity = ball.XVelocity;
            _yVelocity = ball.YVelocity;
            _centreActualX = ball.centreActualX;
            _centreActualY = ball.centreActualY;
            SetNextPosition(ball);
        }

        /// <summary>
        /// Deterines the next position of the ball based on the time represented by each
        /// iteration of the simulation and the current velocity of the ball
        /// </summary>
        /// <param name="actualPos"></param>
        /// <param name="velocity"></param>
        /// <returns></returns>
        private double FindNextPosition(double actualPos, double velocity)
        {
            return actualPos + velocity * SimulationTime;
        }

        /// <summary>
        /// Sets the next co-ordinate of the ball in both actual(floating point) and pixel terms
        /// </summary>
        private void SetNextPosition(IBallModel ball)
        {
            ball.centreActualX = FindNextPosition(_centreActualX, _xVelocity);
            ball.centreActualY = FindNextPosition(_centreActualY, _yVelocity);
        }
    }
}
