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
        public double height => 25;
        /// <summary>
        /// Describes the width of a ball
        /// </summary>
        public double width => 25;
    }
}
