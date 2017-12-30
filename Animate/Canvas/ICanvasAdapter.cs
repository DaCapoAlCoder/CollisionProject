using System.Windows;

namespace Animate
{
    /// <summary>
    /// Interface to the wrapper class to allow Canvas to be testable
    /// </summary>
    public interface ICanvasAdapter
    {
        /// <summary>
        /// Gets the position of the right side of the canvas
        /// </summary>
        double CanvasRightSide { get; }

        /// <summary>
        /// Gets the position of the bottom side of the canvas
        /// </summary>
        double CanvasBottomSide { get; }
        /// <summary>
        /// Set the position of the left side of the shape being drawn on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <param name="length"></param>
        void SetLeft(UIElement element, double length);

        /// <summary>
        /// Set the position of the top side of the shape being drawn on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <param name="length"></param>
        void SetTop(UIElement element, double length);

        /// <summary>
        /// gets the top most point of a UI element on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        double GetTop(UIElement element);

        /// <summary>
        /// Gets the left most point of a UI element on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        double GetLeft(UIElement element);

        /// <summary>
        /// Add a UIElement to the Canvas
        /// </summary>
        /// <param name="element"></param>
        void AddChild(UIElement element);
    }
}