using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Animate.Controllers
{
    class BackendController
    {
        private IMotionModel _MotionModel;
        private WallCollisionModel _CollisionModel;
        private IBallModel _BallModel;
        private ICanvasAdapter _CanvasAdapter;

        public BackendController(IBallModel ballModel, ICanvasAdapter canvasAdapter)
        {
            _CanvasAdapter = canvasAdapter;
            _BallModel = ballModel;
            _MotionModel = new MotionModel();
            _CollisionModel = new WallCollisionModel(_BallModel, _CanvasAdapter);
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(10);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            _MotionModel.ApplyMotionModel(_BallModel);
            _CollisionModel.WallCollision();
        }

        public IBallModel BallModel => _BallModel;

        #region shite       
        //private System.Timers.Timer _timer;
        //private delegate void testdel();

        //public BackendController(BallModel ballModel)
        //{
        //    Thread.Sleep(8000);
        //    _timer = new System.Timers.Timer(1000);
        //    var sync = new syncobject();
        //    testdel TestDel = new testdel(Run);
        //    sync.Invoke(TestDel, null);
        //    _timer.SynchronizingObject = sync;
        //    _motionModel = new MotionModel();
        //    _ballModel = ballModel;
        //    //_timer = new Timer(new TimerCallback(Run), "state", 0, 1000);
        //    System.Diagnostics.Debug.WriteLine("Constructor thread number: " + Thread.CurrentThread.ManagedThreadId);
        //    _timer.AutoReset = true;
        //    _timer.Enabled = true;
        //    _timer.Elapsed += _timer_Elapsed;
        //    _timer.Start();
        //}


        //private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    System.Diagnostics.Debug.WriteLine("elapsed event");
        //}

        //private void Run()
        //{
        //    System.Diagnostics.Debug.WriteLine("tick event");
        //}

        //public class syncobject : ISynchronizeInvoke
        //{
        //    public bool InvokeRequired => true;

        //    public IAsyncResult BeginInvoke(Delegate method, object[] args)
        //    {
        //        System.Diagnostics.Debug.WriteLine("Begin Invoke");
        //    System.Diagnostics.Debug.WriteLine(Thread.CurrentThread.ManagedThreadId);
        //        return null;
        //    }

        //    public object EndInvoke(IAsyncResult result)
        //    {
        //        System.Diagnostics.Debug.WriteLine("End Inoke");
        //        return this;
        //    }

        //    public object Invoke(Delegate method, object[] args)
        //    {
        //        System.Diagnostics.Debug.WriteLine("Invoke");
        //        return this;
        //    }
        //}
        #endregion shite       
    }
}
