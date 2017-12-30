using Animate.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class SimulationController
    {
        private BallModel _BallModel = new BallModel();
        private BackendController _BackendController;
        private DrawController _DrawController;
        private ICanvasAdapter _CanvasAdapter;

        public SimulationController(ICanvasAdapter canvasAdapter)
        {
             _BallModel = new BallModel();
            _CanvasAdapter = canvasAdapter;
            _BackendController = new BackendController(_BallModel, _CanvasAdapter);
            _DrawController = new DrawController(_CanvasAdapter, new BallViewModel(_BallModel));
        }

        public void DrawRequestHandler()
        {
            _DrawController.Draw();
        }


    }
}
