using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using FatoryPattern;

namespace Dummy
{
    // Defn: Factory Method Pattern defines an interface (not in literal sense) for creatng an object, but lets subclass decide which class to instantidate.
    // Factory Method lets a class defer instantiation

    /*
                Product                                 Creator
                   |                                        |
                   |                                        |
            Concrete Product <------------------------Concrete Creator
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Change in requirement franchising pizza outlet000000000
            PizzaStore mumbaiStore = new MumbaiPizzaStore();
            PizzaStore delhiStore = new DelhiPizzaStore();

            Pizza pizza = mumbaiStore.orderPizza("Cheese");
            pizza = delhiStore.orderPizza("Cheese");

        } 
    }
}

