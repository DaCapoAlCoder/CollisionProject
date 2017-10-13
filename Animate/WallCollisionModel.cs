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

        public WallCollisionModel(IBall ball, ICanvasAdapter canvasAdapter)
        {
            _ball = ball;
            _canvasAdapater = canvasAdapter;
        }

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
