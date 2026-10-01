namespace NVH_NETCORE_MVC_BTLab05.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static readonly List<Category> Instance = new List<Category>
        {
            new Category { Id = 1, Name = "Điện thoại" },
            new Category { Id = 2, Name = "Laptop" },
            new Category { Id = 3, Name = "Máy tính bảng" },
            new Category { Id = 4, Name = "Tai nghe" },
            new Category { Id = 5, Name = "Phụ kiện" }
        };
    }
}
