using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class SushiDecorator : Sushi
    {
        private Sushi sushi;
        public SushiDecorator(Sushi sushi)
        {
            this.sushi = sushi;
        }
        public virtual string getFlavors()
        {
            return sushi.getFlavors();
        }
    }
}
