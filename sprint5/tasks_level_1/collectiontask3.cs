class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        
        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            decimal total = 0;
            foreach (IGrouping<string, Product> list in lookup)
            {
                foreach (Product prod in lookup[list.Key])
                {
                    Console.WriteLine(prod.Name + " " + prod.Price);
                    total += prod.Price;
                }
                Console.WriteLine(list.Key + " " + total);
                total = 0;
            }
        }
    }
