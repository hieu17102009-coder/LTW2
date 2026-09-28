namespace BTT2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int  discount { get; set; }
        public string Info { get; set; }
        public bool Availbe {  get; set; }
        public string Img { get; set; }
        public DateTime Datepost { get; set; }
        public int Type { get; set; }
    }
}
