using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SimulationController _simulationController;

        #region legacy
        //private Ball _ball;
        //private BallView _ballView;
        //private BallModel _ballModel;
        //private BallViewModel _ballViewModel;
        //private MotionMediator _motionMediator;
        #endregion legacy

        /// <summary>
        /// Main
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += RenderFrame;
            
            _simulationController = new SimulationController(new CanvasAdapter(canvas));

            #region legacy
            //_ball = new Ball(new EllipseAdapter(new Ellipse()));
            //_ballView = new BallView();
            //_ballModel = new BallModel();
            //_ballViewModel = new BallViewModel(_ballModel);

            //_motionMediator = new MotionMediator(new MotionModel(), _ballModel);
            //anvasMediator canvasMediator = new CanvasMediator(_ball, new CanvasAdapter(canvas));
            //CollisionMediator collisionMediator = new CollisionMediator(_ball, new CanvasAdapter(canvas));
            //MotionMediator motionMediator = new MotionMediator(new MotionModel(), _ball);

            //canvas.Children.Add(_ball.Shape);
            //canvas.Children.Add(_ballView);
            #endregion legacy
        }

        private void RenderFrame(object sender, EventArgs e)
        {
            _simulationController.DrawRequestHandler();

            #region legacy
            //_ball.Move();
            //_ballModel.Move();
            #endregion legacy
        }

    }

}
