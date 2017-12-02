using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class CanvasMediator
    {
        IBall _ball;
        ICanvasAdapter _canvasAdapter;
        public CanvasMediator(IBall ball, ICanvasAdapter canvasAdapter)
        {
            _ball = ball;
            _canvasAdapter = canvasAdapter;
            ball.RedrawRequest += OnRedrawRequest;
        }

        private void OnRedrawRequest(object sender, EventArgs e)
        {
            _canvasAdapter.SetTop(_ball.Shape, _ball.PosPixelY);
            _canvasAdapter.SetLeft(_ball.Shape, _ball.PosPixelX);
        }
    }
}
