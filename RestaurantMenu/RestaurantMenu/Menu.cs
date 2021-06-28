using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {
        public void NewItem(MenuItem item)
        {
            if (item.IsNew == true)
            Console.WriteLine("***New***");
        }
        public void ShowMenu()
        {
            MenuItem FriedRice = new MenuItem();
            FriedRice.Price = 8.99;
            FriedRice.Description = ("White jasmine rice with shrimp, egg, and green onions.");
            FriedRice.Category = ("Main Course");
            FriedRice.IsNew = true;

            MenuItem WonTon = new MenuItem();
            WonTon.Price = 3.95;
            WonTon.Description = ("Small piece of meat encased in dough, with spicy sauce. Order of 6.");
            WonTon.Category = ("Appetizer");
            WonTon.IsNew = true;

            MenuItem FriedIceCream = new MenuItem();
            FriedIceCream.Price = 2.50;
            FriedIceCream.Description = ("One scoop of vanilla icecream deep fried.");
            FriedIceCream.Category = ("Dessert");
            FriedIceCream.IsNew = false;

            Console.WriteLine("\n=====APPETIZER=====");
            NewItem(WonTon);
            Console.WriteLine($"Menu Item: WonTon \tPrice: ${WonTon.Price}\n\tDescription: {WonTon.Description}");

            Console.WriteLine("\n=====MAIN COURSE=====");
            NewItem(FriedRice);
            Console.WriteLine($"Menu Item: Fried Rice \tPrice: ${FriedRice.Price}\n\tDescription: {FriedRice.Description}");

            Console.WriteLine("\n=====DESSERT=====");
            NewItem(FriedIceCream);
            Console.WriteLine($"Menu Item: Fried Ice Cream \tPrice: ${FriedIceCream.Price}0\n\tDescription: {FriedIceCream.Description}");

            DateTime lastUpdated = new DateTime (2021, 06, 28);
            Console.WriteLine($"\n Last updated: {lastUpdated}");

            Console.ReadKey();
        }

       
    }
}
