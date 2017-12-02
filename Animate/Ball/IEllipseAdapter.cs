using System.Windows.Media;
using System.Windows.Shapes;

namespace Animate
{
    /// <summary>
    /// Interface for adapter pattern to allow the ellipse to be injected
    /// </summary>
    public interface IEllipseAdapter
    {
        /// <summary>
        /// Height of the ellipse
        /// </summary>
        double Height { get; set; }

        /// <summary>
        /// Width of the ellipse
        /// </summary>
        double Width { get; set; }

        /// <summary>
        /// The colour used to fill the ellipse
        /// </summary>
        Brush Fill { get; set; }

        /// <summary>
        /// The underlying shape from the adapter
        /// </summary>
        Ellipse Shape { get; }
    }
}