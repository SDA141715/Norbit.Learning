using System.Text;

namespace OOPStoreApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(int id, string fullName, string email, string phoneNumber)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }


    public class Cart
    {
        public Customer Customer { get; set; }
        private List<Product> Products = new List<Product>();

        public Cart(Customer customer)
        {
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> GetItems() => Products;

        public decimal CalculateTotal()
        {
            return Products.Sum(x => x.Price);
        }

        public void Clear()
        {
            Products.Clear();
        }
    }


    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Status { get; set; }

        public Order(Cart cart, int id, string status)
        {
            OrderId = id;
            Customer = cart.Customer;
            Products = new List<Product>(cart.GetItems());
            TotalAmount = cart.CalculateTotal();
            CreatedTime = DateTime.Now;
            Status = status;
        }
    }

    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(Order order, int id, StringBuilder status)
        {
            Id = id;
            Amount = order.TotalAmount;
            PaymentDate = DateTime.Now;
        }
    }

}
