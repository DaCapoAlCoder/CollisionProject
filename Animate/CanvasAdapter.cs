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
        #region fields
        private Canvas _canvas;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets the position of the right side of the canvas
        /// </summary>
        public double CanvasRightSide => _canvas.ActualWidth;

        /// <summary>
        /// Gets the position of the bottom side of the canvas
        /// </summary>
        public double CanvasBottomSide =>_canvas.ActualHeight;
        #endregion properties

        #region constructor
        //private double scaleY;
        /// <summary>
        /// Wrapper class to allow Canvas to be testable
        /// </summary>
        public CanvasAdapter(Canvas canvas)
        {
            _canvas = canvas;
        }
        #endregion constructor
        
        #region methods
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
        #endregion methods


    }
}
