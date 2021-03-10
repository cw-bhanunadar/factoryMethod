using System;

namespace FatoryPattern
{
    public abstract class Pizza
    {
        public abstract void Prepare();
        public void Bake(){Console.WriteLine("Baking the pizza");}
        public void Cut(){Console.WriteLine("Cutting the pizza");}
        public void Box(){Console.WriteLine("Parcel the pizza");}
    }
}