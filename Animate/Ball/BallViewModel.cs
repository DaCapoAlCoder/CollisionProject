using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    /// <summary>
    /// Mediator between ball model and view
    /// </summary>
    public class BallViewModel
    {
        private IBallModel _ballModel;

        /// <summary>
        /// View model of Ball model
        /// </summary>
        /// <param name="ballModel"></param>
        public BallViewModel(IBallModel ballModel)
        {
             _ballModel = ballModel;
        }
        /// <summary>
        /// Describes the height of a ball
        /// </summary>
        public double height => _ballModel.Radius * 2;


        /// <summary>
        /// Describes the width of a ball
        /// </summary>
        public double width => _ballModel.Radius * 2;

        /// <summary>
        /// Top of the ball
        /// </summary>
        public int Top => (int)Math.Round(_ballModel.centreActualY - _ballModel.Radius);

        /// <summary>
        /// Left side of the ball
        /// </summary>
        public int Left => (int)Math.Round(_ballModel.centreActualX - _ballModel.Radius);
    }
}
