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
        private Ball _ball;
        private BallView _ballView;
        /// <summary>
        /// Main
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            CompositionTarget.Rendering += RenderFrame;

            _ball = new Ball( new EllipseAdapter(new Ellipse()));
            _ballView = new BallView();

            CanvasMediator canvasMediator = new CanvasMediator(_ball, new CanvasAdapter(canvas));
            CollisionMediator collisionMediator = new CollisionMediator(_ball, new CanvasAdapter(canvas));
            MotionMediator motionMediator = new MotionMediator(new MotionModel(), _ball);

            canvas.Children.Add(_ball.Shape);
            canvas.Children.Add(_ballView);
        }

        private void RenderFrame(object sender, EventArgs e )
        {
            _ball.Move();
        }

    }

}
