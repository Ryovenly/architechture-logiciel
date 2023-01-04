using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SauceSaleeDecorator : SushiDecorator
    {
        public SauceSaleeDecorator(Sushi sushi) : base(sushi)
        {
        }

        public override string getFlavors()
        {
            return base.getFlavors() + ", Sauce Salée";
        }
    }
}
