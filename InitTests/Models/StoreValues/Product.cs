namespace InitTests.Models.StoreValues
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid StoreId { get; set; }
        public Store Store { get; set; }
    }
}
