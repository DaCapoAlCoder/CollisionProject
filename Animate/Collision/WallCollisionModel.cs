using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class WallCollisionModel 
    {
        private IBallModel _ball;
        private ICanvasAdapter _canvasAdapater;
        private double EnclosingRectLeft;
        private double EnclosingRectRight;
        private double EnclosingRectTop;
        private double EnclosingRectBottom;
        /// <summary>
        /// Models what happens when an object collides with a wall
        /// </summary>
        /// <param name="ball"></param>
        /// <param name="canvasAdapter"></param>
        public WallCollisionModel(IBallModel ball, ICanvasAdapter canvasAdapter)
        {
            _ball = ball;
            _canvasAdapater = canvasAdapter;
        }

        /// <summary>
        /// Reverse direction of the X motion component if the ball hits the left or right walls
        /// Reverse direction of the Y motion component if the balls hits the top or bottom walls
        /// </summary>
        public void WallCollision()
        {
            DetermineEnclosingRectangle();
            if (EnclosingRectLeft <= 0.0 || EnclosingRectRight >= _canvasAdapater.CanvasRightSide)
            {
                _ball.XVelocity *= -1;
            }

            if (EnclosingRectTop <= 0.0 || EnclosingRectBottom >= _canvasAdapater.CanvasBottomSide )
            {
                _ball.YVelocity *= -1;
            }
        }

        private void DetermineEnclosingRectangle()
        {
            EnclosingRectLeft = _ball.centreActualX - _ball.Radius;
            EnclosingRectRight = _ball.centreActualX + _ball.Radius;
            EnclosingRectTop = _ball.centreActualY - _ball.Radius;
            EnclosingRectBottom = _ball.centreActualY + _ball.Radius;
        }


    }
}
