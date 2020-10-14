using System;
using System.Collections.Generic;

namespace Prov
{
    class Book
    {
        public int price = 0;
        private Random generator = new Random();
        private string name;
        private int rarity;
        private string category;
        private int actualValue = 0;
        private bool cursed;

        List<string> categories= new List<string>() {"Fantasy", "Witchcraft", "Carpentry", "Fairyale", "Recipies"};
         List<string> names1= new List<string>() {"The Wonders Of", "The Great", "The Amazing", "Tales Of"};
        List<string> names2= new List<string>() {"Trees", "Being 36 Years Old", "Wonderfrog", "Golden Birdeggs", "Witchy Stuff", "Book Curses", "Book Evaluation"};



        public Book() {

            actualValue = generator.Next(0,99);
            rarity = generator.Next(0, 99);
            

            int cursedRandom; 
            cursedRandom = generator.Next(0,1);

            if( cursedRandom == 1) {
                cursed = true;
            }

            else {
                cursed = false;
            }

            string namePart1 = names1[generator.Next(0,3)];
            string namePart2 = names2[generator.Next(0,6)];

            name = namePart1 + namePart2;

            category = categories[generator.Next(0,4)]

        }

        public void PrintInfo() {

            System.Console.WriteLine("A book is valued between 1-100 gold coins.");
            System.Console.WriteLine("A books rarity is displayed with points from 1-100.");
            System.Console.WriteLine();

            System.Console.WriteLine("This book has the following properties:");

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine("This book is called '" + name + "' and is frmo the category " + category + ".");
            System.Console.WriteLine("It's rarity score is " + rarity + " out of 100.");
            System.Console.WriteLine("The book costs " + price + " gold coins.");

        }

        public int Evaluate() {

           actualValue * rarity = price;

           int multiplier;

           multiplier = generator.Next(49,149);
           multiplier = multiplier / 10;
           


           price = multiplier * price; 

           return price; 

        }

        public string GetCategory() {

        }

        public string GetName(){

        }

        public bool IsCursed() {

        }






    }
}