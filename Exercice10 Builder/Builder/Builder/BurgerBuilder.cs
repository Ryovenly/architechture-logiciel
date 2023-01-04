using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class BurgerBuilder
    {
        protected Burger burger;
        public Burger Burger
        {
            get { return burger; }
        }

        // Abstract build methods
        public abstract void BuildBread();
        public abstract void BuildMeat();
        public abstract void BuildVegetables();
        public abstract void BuildSauce();
        public abstract void BuildCheese();

    }
}
