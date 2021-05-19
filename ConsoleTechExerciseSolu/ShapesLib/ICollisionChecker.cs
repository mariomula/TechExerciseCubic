using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public interface ICollisionChecker
    {
        bool IsCollision(IShape shape1, IShape shape2);
    }
}
