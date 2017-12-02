using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for BallView.xaml
    /// </summary>
    public partial class BallView : UserControl
    {
        /// <summary>
        /// Control to represent a ball in the simulation
        /// </summary>
        public BallView()
        {
            InitializeComponent();
            DataContext = new BallViewModel(new BallModel());
        }
    }
}
