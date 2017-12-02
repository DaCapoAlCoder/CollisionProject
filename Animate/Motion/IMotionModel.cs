namespace Animate
{
    /// <summary>
    /// Describes the motion of objects that move in the simulation
    /// </summary>
    public interface IMotionModel
    {
        /// <summary>
        /// The actual double precision x position of the object
        /// </summary>
        double centreActualX { get; }

        /// <summary>
        /// The actual double precision y position of the object
        /// </summary>
        double centreActualY { get; }

        /// <summary>
        /// The time between each tick of the simluation
        /// </summary>
        double SimulationTime { get; }

        /// <summary>
        /// Applies the described model to the simluation object
        /// </summary>
        /// <param name="xVelocity"></param>
        /// <param name="yVelocity"></param>
        /// <param name="centreActualX"></param>
        /// <param name="centreActualY"></param>
        void ApplyMotionModel(double xVelocity, double yVelocity, double centreActualX, double centreActualY);
    }
}