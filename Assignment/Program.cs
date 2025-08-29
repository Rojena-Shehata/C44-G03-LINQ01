using Demo01;
using Demo01.Data;
using LinqDemo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System.Threading;
using static Demo01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region LINQ – Transformation Operators 


            #region Question 01
            //1.Return a sequence of just the names of a list of products.

            //query syntax
            //var productNames = from product in ProductList
            //                        select  product.ProductName ;

            //foreach (var Pname in productNames)
            //{
            //    Console.WriteLine(Pname);
            //}

            //fluent syntax
            //List<string> pnames=ProductList.Select(product=>product.ProductName).ToList();
            //pnames.ForEach(pname => Console.WriteLine(pname));

            #endregion


            #region Question 02
            //2.Produce a sequence of the uppercase and lowercase versions of each
            //word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //Console.WriteLine("==========By Fluent syntax===========");

            //var sequenceOfUpperAndLower = from word in words
            //                              select new
            //                              {
            //                                  upperCase = word.ToUpper(),
            //                                  lowerCase = word.ToLower()
            //                              };
            //foreach(var word in sequenceOfUpperAndLower)
            //{
            //    Console.WriteLine(word);
            //}
            //Console.WriteLine();
            //Console.WriteLine("==========By Query syntax===========");    
            //var sequenceOfUpperAndLowerCases = words.Select
            //    (word =>new
            //    {
            //        upperCase = word.ToUpper(),
            //        lowerCase = word.ToLower()
            //    });

            //foreach (var word in sequenceOfUpperAndLower)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion


            #region Question 03
            //3.Returns all pairs of numbers from both arrays such that the number from
            //numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 }
            //            ;
            //            int[] numbersB = { 1, 3, 5, 7, 8 };
            //            Result

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //        from b in numbersB
            //        where a < b
            //        select $"{a} is less than {b}";


            //if (pairs.Any())
            //    Console.WriteLine("Pairs where a<b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine(pair);
            //}


            #endregion

            //check
            #region Question 04
            //4.Select all orders where the order total is less than 500.00.

            /////////query way
            //var orders=from customer in CustomerList
            //           from order in customer.Orders
            //           where order.Total<500.00m
            //           select order;

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order);
            //}

            ////////fluent way
            //var cheapOrders=CustomerList.SelectMany(customer=>customer.Orders).Where(order=>order.Total<500m);
            //foreach (var order in cheapOrders)
            //{
            //    Console.WriteLine(order);
            //}
            #endregion


            #region Question 05
            //5.Determine if the value of int in an array match their position
            //in the array. 
            ////5: False 
            ////4: False 
            ////1: False 
            ////3: True    . . . . . . . . . . . . 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var isMatch = Arr.Select((value, index) => $"{value}:{value.Equals(index)}");


            //foreach (var item in isMatch)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #endregion


            #region LINQ - Restriction Operators>< 



            #region Question 01
            //1.Sort a list of products by name

            //var orderedProductList = ProductList.OrderBy(product => product.ProductName);

            //foreach (var item in orderedProductList)
            //    Console.WriteLine(item);

            #endregion



            #region Question 02
            //2.Sort a list of products by units in stock from highest to lowest.

            //var orderedProducts=ProductList.OrderByDescending(product=>product.UnitsInStock);

            //foreach (var product in orderedProducts)
            //{
            //    Console.WriteLine(product);
            //}


            ////////////////////Query way

            //var orderedProducts2=from product in ProductList
            //                     orderby product.UnitsInStock descending
            //                     select product;
            //foreach (var product in orderedProducts2)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion



            #region Question 03
            //2. Sort a list of digits, first by length of their name, and
            //then alphabetically by the name itself. 
            //string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var sortedArray = Arr.OrderBy(name => name.Length).ThenBy(name => name);


            //foreach (var item in sortedArray)
            //    Console.WriteLine(item);

            #endregion



            #region Question 04
            //4.Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var sortedProducts =ProductList.OrderByDescending(product=>product.Category).ThenByDescending(product=>product.UnitPrice);

            //var t = sortedProducts.Select(product => new
            //{
            //    category = product.Category,
            //    UnitPrice = product.UnitPrice
            //});

            //foreach (var item in t)
            //    Console.WriteLine(item);
            #endregion



            #region Question 05
            //5.Sort first by-word length and then by a case -insensitive
            //descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "ClOvEz", "ClOvER", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // var orderedArray = Arr.OrderBy(word => word.Length).ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase).ToArray();

            // foreach (var word in orderedArray)
            //     Console.WriteLine(word);





            #endregion



            #region Question 06
            //6 . Create a list of all digits in the array whose second letter is 'i'
            //that is reversed from the order in the original array.
            //string[] Arr = {“zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine”};

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var reversed = Arr.Where(word => word.Length > 1 && word[1] == 'i').Reverse();
            //foreach (string word in reversed)
            //    Console.WriteLine(word);

            #endregion



            #endregion

        }
    }
}
