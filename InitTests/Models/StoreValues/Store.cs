namespace InitTests.Models.StoreValues
{
    public class Store
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public Product GetProduct(Guid id)
        {
            if (Products != null)
            {
                Products.Add(new Product());
                Products.Add(new Product());
                Products.Add(new Product());
                Products.Add(new Product());
                Products.Add(new Product());
                Products.Add(new Product());
            }
            string test = "";
            Console.WriteLine(test);
            Products = new();
            return new Product() { Id = id, Name = "For test" };
            //for init dev
        }
    }
}
