using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OOPA1
{
    class Menu
    {
        public string Name
        { get; set; }

        public string Food
        { get; set; }

        public Dictionary<string, double> FoodItems = new Dictionary<string, double>() //dictionary to store all food menu items and prices
        {

            {"Breakfast Wrap", 3.50} ,  {"Toast" , 2.00} , {"Full English", 5.00} , {"Cereal", 2.00} , {"Pastries", 2.00}, //Breakfast total 14.5
            {"Salad", 5.00 } , {"Pizza", 3.75}, {"Burgers", 5.50}, //Lunch 14.25
            {"Steak", 10.00 } , {"Fish&Chips", 8.00} ,   //Dinner 18
            {"Ice Cream" , 3.50 } , {"Cheesecake", 6.75} , {"Cookies", 2.75} //Dessert 13

        };

        public double Price
        { get; set; }


        public string MenuType
        { get; set; }

        public int Time
        { get; set; }

        public string Drinks
        { get; set; }
        public Dictionary<string, double> DrinksItems = new Dictionary<string, double>() //dictionary to store all drinks items and prices
        {
            {"Water", 0.50 } , {"Coke", 1.75} , {"Apple Juice", 0.75} , {"Orange Juice", 0.75} , {"Lemonade", 1.75} ,  //Soft drinks 5.5
            {"Beer", 4.00 } , {"Wine" , 4.00} , {"Gin" , 3.50} , {"Vodka", 3.50}, //Alcholic Drinks 15
           
        };

        public Menu(string Name, double Price)
        {
            Name = Name;
            Price = Price;

        }

        public static void Announce(string Name, double Price) //method displays total value of different menu items
        {
            string Option;
            Console.WriteLine("Which menu would you like to view");
            Option = Console.ReadLine();

            if (Option == "Breakfast")
            {
                Console.WriteLine($"{Name} items costs a total of £{Price}");
            }

            if (Option == "Lunch")
            {
                Console.WriteLine($"{Name} items costs a total of £{Price}");
            }

            if (Option == "Dinner")
            {
                Console.WriteLine($"{Name} items cost a total of £{Price}");
            }
            if (Option == "Dessert")
            {
                Console.WriteLine($"{Name} items cost a total of £{Price}");
            }
            if (Option == "Soft Drinks")
            {
                Console.WriteLine($"{Name} items cost a total of £{Price}");
            }
            if (Option == "Alchoholic Drinks")
            {
                Console.WriteLine($"{Name} items cost a total of £{Price}");

            }



            foreach (KeyValuePair<string, double> kvp in Menu.FoodItems)
                Console.WriteLine("Key: {0}, Value: {1}", KeyValuePair.Key, KeyValuePair.Value);
        }
    }
}

