namespace Day9Assignment
{
    public class Product
    {
        protected string? Name;
        protected double Price;
        public string? name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }

        public double price
        {
            get
            {
                return this.Price;
            }
            set
            {
                this.Price = value;
            }
        }
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    public class Order
    {
        double Total;
        List<Product> orders = [];
        public void order(Product product, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                orders.Add(product);
                Total += product.price;
            }
            Console.WriteLine($"{quantity} units of {product.name} are ordered at {product.price:C} each.");
        }
        public void OrderAmount()
        {
            Console.WriteLine($"Total is: {Total:C}");
        }
    }
}