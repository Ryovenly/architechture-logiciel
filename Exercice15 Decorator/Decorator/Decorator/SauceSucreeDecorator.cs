using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SauceSucreeDecorator : SushiDecorator
    {
        public SauceSucreeDecorator(Sushi sushi) : base(sushi)
        {
        }

        public override string getFlavors()
        {
            return base.getFlavors() + ", Sauce Sucrée";
        }
    }
}
