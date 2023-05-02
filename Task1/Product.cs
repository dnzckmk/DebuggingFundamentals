using System;

namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        /// <summary>
        /// Check if the obj is equals the current instance of Product.
        /// </summary>
        /// <param name="obj">Product object.</param>
        /// <returns> Return true if the parameter equals the current instance of the Product, else return false. </returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Product product = obj as Product;
            return Name == product.Name && Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
