using System;
using System.Linq;
using System.Collections.Generic;

namespace OOPA1
{
    class Program
    {


        static void Main(string[] args)
        {
            Menu m = new Menu("Breakfast", 14.50);
            Menu.Announce("Breakfast", 14.50);

            Menu m1 = new Menu("Lunch", 14.25);
            Menu.Announce("Lunch", 14.25);

            Menu m2 = new Menu("Dinner", 18.00);
            Menu.Announce("Dinner", 18.00);

            Menu m3 = new Menu("Dessert", 13.00);
            Menu.Announce("Dessert", 13.00);

            Menu m4 = new Menu("Soft Drinks", 5.50);
            Menu.Announce("Soft Drinks", 5.50);

            Menu m5 = new Menu("Alchoholic Drinks", 15.00);
            Menu.Announce("Alchoholic Drinks", 15.00);

        

        public Dictionary<string, double> FoodItems = new Dictionary<string, double>() //dictionary to store all food menu items and prices
        {

            {"Breakfast Wrap", 3.50} ,  {"Toast" , 2.00} , {"Full English", 5.00} , {"Cereal", 2.00} , {"Pastries", 2.00}, //Breakfast total 14.5
            {"Salad", 5.00 } , {"Pizza", 3.75}, {"Burgers", 5.50}, //Lunch 14.25
            {"Steak", 10.00 } , {"Fish&Chips", 8.00} ,   //Dinner 18
            {"Ice Cream" , 3.50 } , {"Cheesecake", 6.75} , {"Cookies", 2.75} //Dessert 13

            foreach(KeyValuePair<string, double> kvp in FoodItems)
            Console.WriteLine("Key: {0}, Value: {1}", KeyValuePair.Key, KeyValuePair.Value) };
    }



        };
 

        

        



      

