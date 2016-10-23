using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
        public class CollisionDetector 
        {
            public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
            {
            if ((((a.X < (b.X + b.Width)) && (b.X < 0)) || (((a.X + a.Width) > b.X) && 
                (b.X > 0)) && (b.Width == GameConstants.WallDefaultSize)) || 
                ((b.Width != GameConstants.WallDefaultSize) && (b.Height != GameConstants.WallDefaultSize) && 
                (a.X > b.X && (a.X < (b.X + b.Width))) &&
                ((((a.Y + a.Height) > b.Y) && (b.Y > 0)) || ((a.Y < (b.Y + b.Height)) && (b.Y == 0))) ||
                (((a.Y < (b.Y + b.Height)) && (b.Y < 0)) ||
                (((a.Y + a.Height) > b.Y) && (b.Y > 0))) && (b.Height == GameConstants.WallDefaultSize)))
                return true;
            return false;

            }
        }
}
