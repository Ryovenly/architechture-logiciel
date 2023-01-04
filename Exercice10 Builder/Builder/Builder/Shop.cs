using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Shop
    {
        public void Construct(BurgerBuilder burgerBuilder)
        {
            burgerBuilder.BuildMeat();
            burgerBuilder.BuildCheese();
            burgerBuilder.BuildBread();
            burgerBuilder.BuildVegetables();
            burgerBuilder.BuildSauce();
        }
    }
}
