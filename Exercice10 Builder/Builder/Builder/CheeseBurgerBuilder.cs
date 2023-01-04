using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class CheeseBurgerBuilder : BurgerBuilder
    {
        public CheeseBurgerBuilder()
        {
            burger = new Burger("ChesseBurger");
        }

        public override void BuildBread()
        {
            burger["bread"] = "Pain Burger";
        }

        public override void BuildCheese()
        {
            burger["cheese"] = "Gouda";
        }

        public override void BuildMeat()
        {
            burger["meat"] = "Viande Hachée boeuf";
        }

        public override void BuildSauce()
        {
            burger["sauce"] = "Mayonnaise";
        }

        public override void BuildVegetables()
        {
            burger["vegetables"] = "Salade, cornichons, oignons";
        }
    }
}
