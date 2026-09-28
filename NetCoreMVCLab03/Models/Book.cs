using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId {  get; set; }
        public int GenreId {  get; set; }
        public string Image {  get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public Book(int id, string title, int authorId, int genreId, string image, float price, int totalPage, string sumary)
        {
            Id = id;
            Title = title;
            AuthorId = authorId;
            GenreId = genreId;
            Image = image;
            Price = price;
            TotalPage = totalPage;
            Sumary = sumary;
        }
        public Book() { }
        public static List<Book> ListBook { get; } = new List<Book>()
            {
                new Book()
                {
                    Id= 1,
                    Title= "Chí phèo",
                    AuthorId= 1,
                    GenreId= 1,
                    Image= "/images/products/b1.jpg",
                    Price= 50000,
                    TotalPage= 250,
                    Sumary= "",
                },
                new Book()
                {
                    Id= 2,
                    Title= "Lão hạc",
                    AuthorId= 1,
                    GenreId= 1,
                    Image= "/images/products/b2.jpg",
                    Price= 50000,
                    TotalPage= 250,
                    Sumary= "",
                },
                new Book()
                {
                    Id= 3,
                    Title= "Conan phiêu lưu ký",
                    AuthorId= 2,
                    GenreId= 2,
                    Image= "/images/products/b3.jpg",
                    Price= 50000,
                    TotalPage= 250,
                    Sumary= "",
                },
                new Book()
                {
                    Id= 4,
                    Title= "Đường xưa mây trắng",
                    AuthorId= 4,
                    GenreId= 3,
                    Image= "/images/products/b4.jpg",
                    Price= 50000,
                    TotalPage= 250,
                    Sumary= "",
                },


            };

        public Book getBookById(int id)
        {
            return ListBook.FirstOrDefault(book => book.Id == id);
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
                new SelectListItem(){Value = "1",Text ="Nam Cao"},
                new SelectListItem(){Value = "3", Text ="Ngô Tất Tố"},
                new SelectListItem(){Value = "2", Text ="Adamkhoom"},
                new SelectListItem(){Value = "4",Text = "Thiền sư Thích Nhất Hạnh"},

        };

        public List<SelectListItem> Genres
        {
            get;
        } = new List<SelectListItem>()
        {
            new SelectListItem() {Value = "1",Text ="Văn học đương đại" },
            new SelectListItem() {Value = "2", Text = "Truyện Tranh"},
            new SelectListItem() {Value ="3", Text = "Phật học phổ thông"}
        };

    }
}
