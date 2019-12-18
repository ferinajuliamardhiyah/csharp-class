using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace csharp_class {

    class Csv {
        public static void CSVObject () {

            string test = @"NAME, CATEGORY, PRICE
Xiaomi Redmi 5A, Smartphone, 1199000
Macbook Air, Laptop, 13775000
Samsung Galaxy J7, Smartphone, 3549000
DELL XPS 13, Laptop, 26799000
Xiaomi Mi 6, Smartphone, 5399000
LG V30 Plus, Smartphone, 10499000";

            var stuffs = test.Split ("\n").Skip (1).ToList ();

            List<Test> result = new List<Test> ();

            for (int i = 0; i < stuffs.Count; i++) {
                string[] content = stuffs[i].Split (',');

                Test map = new Test ();
                map.name = content[0];
                map.category = content[1];
                map.price = decimal.Parse (content[2]);

                result.Add (map);
            }

            var resultSort = result.OrderBy (x => x.price);

            foreach (var item in resultSort) {
                Console.WriteLine ($"{item.name}, {item.price.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))}, {item.category}");
            }

        }
    }

    class Test {
        public string name { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
    }

}