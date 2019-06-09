using System.Collections.Generic;

namespace _07._06._19
{
    public class Product
    {
        private static List<Product> _product = new List<Product>();
        private static List<Category> _category;
     
        private static int id { get; set; } = 1;
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public decimal Price { get; private set; }
        public decimal Qunatity { get; set; }
        public bool Discount { get; set; }
        public decimal DiscountPercent { get; set; }
         
        static Product()
        {
            _category = new List<Category>()
            {
                new Category{Name="Ickiler"},
                new Category{Name="Sud mehsullari"},
                new Category{Name="Shirniyyat"},
                new Category{Name="Qeyri-qida"},
                new Category{Name="Meyve ve terevez"},
                new Category{Name="Qostronom"}
            };
        }

        public Product(string name, string categoryName, decimal p, decimal qunatity, bool discount,  decimal discountPercent)
        {
            Id = new string('0', 4 - id.ToString().Length) + id;
            id++;

            Name = name;
            CategoryName = categoryName;
            Qunatity = qunatity;

            if (discount == true)
            {
                Price = p - (p * discountPercent) / 100;
            }
            else
            {
                Price = p;
            }
            Discount = discount;
            DiscountPercent = discountPercent;
        }

        public static List<Product> GetProducts()
        {
            return _product;
        }

        public static void AddProduct(Product pro)
        {
            _product.Add(pro);
        }

        public static List<Category> GetCategories()
        {
            return _category;
        }

        public static void DeleteProduct(string id)
        {
            for (int i = 0; i < _product.Count; i++)
            {
                if (_product[i].Id == id)
                {
                    _product.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
