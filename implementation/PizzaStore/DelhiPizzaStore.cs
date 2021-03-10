using System;

namespace FatoryPattern
{
    // We are opening franchising
    public class DelhiPizzaStore : PizzaStore
    {
        public DelhiPizzaStore()
        {
        }

        public override Pizza createPizza(string type)
        {
            if (type == "Cheese")
            {
                return new DelhiCheesePizza();
            }
            else
            {
                return new DelhiPepperoniPizza();
            }
        }
    }
}
