namespace DemoCuaThay.Models
{
    public class SV
    { 
        public string SvId {  get; set; }
        public string Name { get; set; }
        public float Diem {  get; set; }
        public string Lop { get; set; }
        public string Email {  get; set; }
        public static readonly List<SV> ListSV = new List<SV>
        {
                new SV
                {
                    SvId = "SV001",
                    Name = "Nguyen Van Hieu",
                    Diem = 10.0f,
                    Lop = "CNTT1",
                    Email = "hieu17102009@gmail.com"
                },

                new SV
                {
                    SvId = "SV002",
                    Name = "Tran Thi Binh",
                    Diem = 7.5f,
                    Lop = "CNTT1",
                    Email = "binh@gmail.com"
                },

                new SV
                {
                    SvId = "SV003",
                    Name = "Le Van Cuong",
                    Diem = 9.0f,
                    Lop = "CNTT2",
                    Email = "cuong@gmail.com"
                },

                new SV
                {
                    SvId = "SV004",
                    Name = "Pham Thi Dung",
                    Diem = 6.5f,
                    Lop = "CNTT2",
                    Email = "dung@gmail.com"
                },

                new SV
                {
                    SvId = "SV005",
                    Name = "Hoang Van Em",
                    Diem = 8.0f,
                    Lop = "CNTT3",
                    Email = "em@gmail.com"
                }
        };
       
        
    }
}
