using System;

namespace Animate
{
    interface IBallModel
    {
        double centreActualX { get; set; }
        double centreActualY { get; set; }
        double Radius { get; }
        double XVelocity { get; set; }
        double YVelocity { get; set; }

        event EventHandler CollisionDectectionRequest;
        event EventHandler MoveRequest;
        event EventHandler RedrawRequest;

        void Move();
    }
}