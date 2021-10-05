using System;
using System.Linq;
using System.Collections.Generic;

namespace linq_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>() {
                new Customer { Id = 1, Name = "Amazon" },
                new Customer { Id = 2, Name = "Target" },
                new Customer { Id = 3, Name = "Microsoft" }
            };
            var orders = new List<Order>() {
                new Order { Id = 1, Description = "1st Order", Sales = 1000, CustomerId = 1 },
                new Order { Id = 2, Description = "2nd Order", Sales = 2000, CustomerId = 3 },
                new Order { Id = 3, Description = "3rd Order", Sales = 3000, CustomerId = 2 }
            };

            var CustOrders = from o in orders
                             join c in customers
                                on o.CustomerId equals c.Id
                             select new { o, c };
            foreach(var co in CustOrders)
            {
                Console.WriteLine($"{co.c.Name} | {co.o.Description} | {co.o.Sales} ");
            }

            //int[] ints = new[]
            //{
            //    411, 119, 940, 680, 800, 267, 435, 893, 968, 760,
            //    636, 933, 390, 359, 774, 823, 582, 592, 544, 984,
            //    254, 376, 403, 153, 263, 516, 669, 664, 650, 154,
            //    396, 186, 139, 524, 512, 821, 943, 530, 742, 748,
            //    773, 632, 642, 648, 644, 561, 805, 379, 241, 893,
            //    231, 909, 597, 447, 626, 434, 630, 970, 424, 602,
            //    836, 351, 161, 786, 197, 730, 171, 442, 231, 791,
            //    491, 281, 463, 110, 317, 388, 339, 839, 807, 598,
            //    601, 206, 106, 324, 584, 749, 490, 193, 328, 126,
            //    853, 428, 141, 914, 659, 362, 396, 344, 390, 447
            //};
            //Console.WriteLine($"Average is {ints.Average()}");
            //var min = ints.Min();
            //var max = ints.Max();
            //Console.WriteLine($"Highest integer is {ints.Max()}");
            //Console.WriteLine($"Lowest integer is {ints.Min()}");
            //var sum = ints.Sum() - ints.Min() - ints.Max();
            //var avg = sum / (ints.Count() - 2.0);
            //Console.WriteLine($"Average without highest/lowest is {avg}");
            //var cnts = ints;
            //var belowavg = cnts.Where(i => i < cnts.Average()).OrderByDescending(i => i);
            //foreach(var i in belowavg)
            //{
            //    Console.Write($"{i} ");
            //}

        }
    }
}
