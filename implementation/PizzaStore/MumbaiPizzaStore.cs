using System;

namespace FatoryPattern
{
    // We are opening franchising
    public class MumbaiPizzaStore : PizzaStore
    {
        public MumbaiPizzaStore()
        {
        }

        public override Pizza createPizza(string type)
        {
            if (type == "Cheese")
            {
                return new MumbaiCheesePizza();
            }
            else
            {
                return new MumbaiPepperoniPizza();
            }
        }
    }
}
