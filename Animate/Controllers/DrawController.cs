using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate.Controllers
{
    class DrawController
    {
        private BallView _BallView;
        public BallView BallView => _BallView;
        public ICanvasAdapter _canvasAdapter;
        private BallViewModel _ballViewModel;
        
        public DrawController(ICanvasAdapter canvasAdapter, BallViewModel ballViewModel )
        {
            _BallView = new BallView();
            _ballViewModel = ballViewModel;
            _BallView.DataContext = ballViewModel;
            _canvasAdapter = canvasAdapter;
            _canvasAdapter.AddChild(_BallView);
        }

        public void Draw()
        {
            _canvasAdapter.SetTop(_BallView, _ballViewModel.Top);
            _canvasAdapter.SetLeft(_BallView, _ballViewModel.Left);
        }
    }
}
