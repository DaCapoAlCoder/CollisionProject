using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Animate
{
    /// <summary>
    /// Wrapper class to allow Canvas to be testable
    /// </summary>
    public class CanvasAdapter : ICanvasAdapter
    {
        private Canvas _canvas;
        //private double scaleX;
        //private double scaleY;
        /// <summary>
        /// Wrapper class to allow Canvas to be testable
        /// </summary>
        public CanvasAdapter(Canvas canvas)
        {
            _canvas = canvas;
        }
        /// <summary>
        /// Set the position of the top side of the shape being drawn on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <param name="length"></param>
        public void SetTop(UIElement element, double length)
        {
            Canvas.SetTop(element, length);
        }

        /// <summary>
        /// Set the position of the left side of the shape being drawn on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <param name="length"></param>
        public void SetLeft(UIElement element, double length)
        {
            Canvas.SetLeft(element, length);
        }
        private void setscaling()
        {
            var test = SystemParameters.FullPrimaryScreenHeight;

            //if (source != null)
            //{
            //    scaleX = source.CompositionTarget.TransformToDevice.M11;
            //    scaleY = source.CompositionTarget.TransformToDevice.M22;
            //}
        }

        /// <summary>
        /// gets the top most point of a UI element on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public double GetTop(UIElement element)
        {
            return Canvas.GetTop(element);
        }

        /// <summary>
        /// Gets the left most point of a UI element on the canvas
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public double GetLeft(UIElement element)
        {
            return Canvas.GetLeft(element);
        }

        /// <summary>
        /// Gets the position of the right side of the canvas
        /// </summary>
        public double CanvasRightSide { get => _canvas.ActualWidth; }

        /// <summary>
        /// Gets the position of the bottom side of the canvas
        /// </summary>
        public double CanvasBottomSide {
            get
            {
                //setscaling();
                return _canvas.ActualHeight; }
                //return 331.0; }
        }

    }
}
