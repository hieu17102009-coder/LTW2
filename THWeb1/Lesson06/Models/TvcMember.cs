using System.Globalization;

namespace Lesson06.Models
{
    public class TvcMember
    {
        public string Name { get; set; }
        public string MaSV {  get; set; }
        public TvcMember(string name, string maSV)
        {
            Name = name;
            MaSV = maSV;
        }
    }
}
