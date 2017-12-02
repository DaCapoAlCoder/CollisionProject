using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class WallCollisionModel 
    {
        private IBall _ball;
        private ICanvasAdapter _canvasAdapater;

        /// <summary>
        /// Models what happens when an object collides with a wall
        /// </summary>
        /// <param name="ball"></param>
        /// <param name="canvasAdapter"></param>
        public WallCollisionModel(IBall ball, ICanvasAdapter canvasAdapter)
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
            if (_ball.EnclosingRectLeft <= 0.0 || _ball.EnclosingRectRight >= _canvasAdapater.CanvasRightSide)
            {
                _ball.XVelocity *= -1;
            }

            if (_ball.EnclosingRectTop <= 0.0 || _ball.EnclosingRectBottom >= _canvasAdapater.CanvasBottomSide )
            {
                _ball.YVelocity *= -1;
            }
        }

    }
}
