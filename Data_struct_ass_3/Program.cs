using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Data_struct_ass_3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Write a program for actions with Dictionary and Hashtable. Please take a look at the
        documentations of the Dictionnary and HashTable classes:
        https://www.geeksforgeeks.org/difference-between-hashtable-and-dictionary-in-c-sharp/
        ● Create a Dictionary for the product price page where all products will be as the key and the
        price as the value.
        ● Save at least 8 products in the HashMap.
        ● Find out how many products are under 1 eur.
        ● Find out which product price is the lowest.
        ● Find out which product price is the largest.
        ● Create a new Dictionarywith other products. Merge both Dictionaries and print out how
        many products are in the merged HashMap.
        ● *Sort all values in ascending order. 
        As a side-note, if you do want a Dictionary sorted based on the key, then there's a SortedDictionary class for that.
        Works the same way as the base Dictionary, but you just swap the class name out with SortedDictionary.  
        SortedDictionary<string, decimal> dict = new SortedDictionary<string, decimal>();
        Doesn't help too much with the assignment as you have to sort by values, not keys.
        My hint for that is LINQ. If you add `using System.Linq;` at the top, then you can use LINQ features.
        We will talk about LINQ more so as part of the databases module coming up after data structures.
        What matters for you here is that you can just write a:
        foreach (KeyValuePair<string, decimal> row in dictionary.OrderBy(row => row.Value))

        ● Repeat the same tasks with HashTable.
        How do You think which class is the most suitable for this assignment?  */ 

        Dictionary <string, double> product = new Dictionary<string, double>();
        product.Add("orange", 1.20);
        product.Add("banana", 1.99);
        product.Add("apple", 0.60);
        product.Add("spinath", 1.00);
        product.Add("peach", 2.20);
        product.Add("strawberries", 4.20);
        product.Add("mandarines", 0.70);
        product.Add("cherries", 6.29);

        int productsUnder1Eur = 0;
        foreach(KeyValuePair<string, double> row in product )
        {
            double price = row.Value;
            if (price < 1.00)
            { productsUnder1Eur++; }  
        }
        Console.WriteLine ("Products under 1 EUR: " + productsUnder1Eur);

        double lowestPrice = Double.MaxValue;
        double highestPrice = Double.MinValue;
        foreach (double price in product.Values)
        {
            if (price < lowestPrice)
            { lowestPrice = price; }
            if (price > highestPrice)
            { highestPrice = price; }
        }
        foreach(KeyValuePair<string, double> row in product )
        {
            double price = row.Value;
            string item = row.Key;
            if (price == lowestPrice)
            { 
                Console.WriteLine($"Product: {item} has the lowest price  ({lowestPrice})");
            }
            if (price == highestPrice)
            { 
                Console.WriteLine($"Product: {item} has the lowest price  ({highestPrice})");
            }
        }

        Dictionary<string, double> otherProducts = new Dictionary<string, double>();
        otherProducts.Add("onions", 0.22);
        otherProducts.Add("carrot", 0.39);
        otherProducts.Add("tomatoe", 1.99);
        otherProducts.Add("cucumber", 2.12);

        foreach(KeyValuePair<string, double> row in otherProducts )
        {
            product.Add(row.Key, row.Value);
        }
        Console.WriteLine("There are " + product.Count + " products with price.");
        Console.WriteLine("********************************************************");
        foreach(KeyValuePair<string, double> row in product.OrderBy(row => row.Value) )
        {
          Console.WriteLine(row.Key + " : " + row.Value);  
        }
        Console.WriteLine("********************************************************");
        foreach(KeyValuePair<string, double> row in product.OrderBy(row => row.Key) )
        {
          Console.WriteLine(row.Key + " : " + row.Value);  
        }
        Console.WriteLine("********************************************************");


        //Hashtable
        Hashtable products = new Hashtable();  //no specified type or variables
        products.Add("orange", 1.20);
        products.Add("banana", 1.99);

        int productUnder1Eur = 0;
        foreach(DictionaryEntry row in products )
        {
            double price = (double)row.Value;  //needs a cast for variable
            if (price < 1.00)
            { productUnder1Eur++; }  
        }
        Console.WriteLine ("Products under 1 EUR: " + productUnder1Eur);

        //all works like with dicitonary, only for Hashtable there is no ordering. 
        //You need to write a code for sorting or to use other data structures.

        }

    }
}
