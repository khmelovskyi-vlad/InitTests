namespace InitTests.Models.StoreValues
{
    public class Store
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public Product GetProduct(Guid id)
        {
            return new Product() { Id = id, Name = "For test" };
        }
    }
}
