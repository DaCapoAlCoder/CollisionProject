using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animate
{
    class BallViewModel
    {
        public BallViewModel(IBallModel ballmodel)
        {

        }
        public double height => 25; 
        public double width => 25;
    }
}
