using System;

namespace FatoryPattern
{
    // We are opening franchising
    public abstract class PizzaStore
    {
        public PizzaStore()
        {
            
        }
        public Pizza orderPizza(String type)
        {
            Pizza pizza = createPizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();    
            pizza.Box();
            return pizza;
        }
        public abstract Pizza createPizza(string type);
    }
}
