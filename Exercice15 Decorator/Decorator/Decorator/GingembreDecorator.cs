using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class GingembreDecorator : SushiDecorator
    {
        public GingembreDecorator(Sushi sushi) : base(sushi)
        {
        }

        public override string getFlavors()
        {
            return base.getFlavors() + ", Gimgembre";
        }
    }
}
