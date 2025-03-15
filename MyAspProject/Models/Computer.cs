namespace MyAspProject.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }

        // ✅ Static method to get a list of predefined computers
        public static List<Computer> GetComputers()
        {
            return new List<Computer>
            {
                new Computer { Id = 1, Brand = "Dell", Description = "High-performance laptop" },
                new Computer { Id = 2, Brand = "HP", Description = "Business-class laptop" },
                new Computer { Id = 3, Brand = "Apple", Description = "MacBook Pro" },
                new Computer { Id = 4, Brand = "Lenovo", Description = "ThinkPad Series" },
                new Computer { Id = 5, Brand = "Asus", Description = "Gaming Laptop" },
                new Computer { Id = 6, Brand = "Acer", Description = "Budget-friendly laptop" },
                new Computer { Id = 7, Brand = "MSI", Description = "High-end gaming PC" },
                new Computer { Id = 8, Brand = "Razer", Description = "Premium gaming laptop" },
                new Computer { Id = 9, Brand = "Samsung", Description = "Ultrabook" },
                new Computer { Id = 10, Brand = "Sony", Description = "Vaio Series" }
            };
        }
    }
}
