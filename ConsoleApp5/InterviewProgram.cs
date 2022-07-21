using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    public static class InterviewProgram
    {
        public static void DisplayCity()
        {
          

            string[] cities = { "Tbilisi", "Kyiv", "Shanghai", "Mariupol", "New York" };
            string input = "I live in kyiv, but love";
            string display = FindMatch(cities, input.ToLower());
            Console.WriteLine(display);           
        }
        public static string FindMatch(string[] cities,string input)
        {
            var matchedItems = cities.ToList().Where(
                c => input.Contains(c, StringComparison.OrdinalIgnoreCase)
                && Regex.Matches(input, c.ToLower()).Count() == 1);

            if (!matchedItems.Any() || matchedItems.Count() > 1)
                return "None";
            else
                return matchedItems.FirstOrDefault();
        }
    }
}
//var result = (from p in Products
//              join o in Orders on p.ProductId equals o.ProductId
//              select new
//              {
//                  o.OrderId,
//                  o.OrderNumber,
//                  p.ProductName,
//                  o.Quantity,
//                  o.TotalAmount,
//                  o.OrderDate
//              }).ToList();
//var result = (from p in Products
//              join o in Orders on p.ProductId equals o.ProductId into temp
//              from t in temp.DefaultIfEmpty()
//              select new
//              {
//                  p.ProductId,
//                  OrderId = (int?)t.OrderId,
//                  t.OrderNumber,
//                  p.ProductName,
//                  Quantity = (int?)t.Quantity,
//                  t.TotalAmount,
//                  t.OrderDate
//              }).ToList();

//var query =
//    from person in people
//    join cat in cats on person equals cat.Owner
//    join dog in dogs on new
//    {
//        Owner = person,
//        Letter = cat.Name.Substring(0, 1)
//    } equals new
//    {
//        dog.Owner,
//        Letter = dog.Name.Substring(0, 1)
//    }
//    select new
//    {
//        CatName = cat.Name,
//        DogName = dog.Name
//    };