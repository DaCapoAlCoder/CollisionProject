using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Animate
{
   /// <summary>
    /// Adapater pattern to allow the ellipse to be injected
    /// </summary>
    public class EllipseAdapter : IEllipseAdapter
    {
        private Ellipse _ellipse;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ellipse"></param>
        public EllipseAdapter( Ellipse ellipse)
        {
            ellipse.Fill = new SolidColorBrush(Colors.Blue);
            _ellipse = ellipse;
        }

        /// <summary>
        /// Height of the ellipse
        /// </summary>
        public double Height {
            get { return _ellipse.Height; }
            set { _ellipse.Height = value; }
        }
        /// <summary>
        /// Width of the ellipse
        /// </summary>
        public double Width {
            get { return _ellipse.Width; }
            set { _ellipse.Width = value; }
        }
        /// <summary>
        /// The colour used to fill the ellipse
        /// </summary>
        public Brush Fill { get => _ellipse.Fill ; set => _ellipse.Fill = value; } 
        /// <summary>
        /// The underlying shape of the adater
        /// </summary>
        public Ellipse Shape => _ellipse;
    }


}
