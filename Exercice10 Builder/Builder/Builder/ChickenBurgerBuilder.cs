using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class ChickenBurgerBuilder : BurgerBuilder
    {
        public ChickenBurgerBuilder()
        {
            burger = new Burger("ChickenBurger");
        }

        public override void BuildBread()
        {
            burger["bread"] = "Pain Burger";
        }

        public override void BuildCheese()
        {
            burger["cheese"] = "Cheddar";
        }

        public override void BuildMeat()
        {
            burger["meat"] = "Blanc de poulet tenders";
        }

        public override void BuildSauce()
        {
            burger["sauce"] = "Mayonnaise, Ketchup";
        }

        public override void BuildVegetables()
        {
            burger["vegetables"] = "Salade, cornichons, oignons";
        }
    }
}
