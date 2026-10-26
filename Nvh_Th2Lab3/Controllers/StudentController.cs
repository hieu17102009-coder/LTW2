using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nvh_Th2Lab3.Models;

namespace Nvh_Th2Lab3.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>();
        public StudentController()
        {
            students = new List<Student>
            {
                new Student
                {
                    Id = 101,
                    Name = "Nguyen Van An",
                    Email = "an@gmail.com",
                    Branch = Branch.IT,
                    Gender = Gender.Male,
                    IsRegular = true,
                    Address = "Ha Noi",
                    Diem = 7,
                },
                new Student
                {
                    Id = 102,
                    Name = "Tran Thi Binh",
                    Email = "binh@gmail.com",
                    Branch = Branch.BE,
                    Gender = Gender.Female,
                    IsRegular = true,
                    Address = "Hai Phong",
                    Diem = (float)7.3,
                },
                new Student
                {
                    Id = 103,
                    Name = "Le Van Cuong",
                    Email = "cuong@gmail.com",
                    Branch = Branch.CE,
                    Gender = Gender.Male,
                    IsRegular = false,
                    Address = "Thai Binh",
                    Diem = (float)9.2,
                },
                new Student
                {
                    Id = 104,
                    Name = "Pham Thi Dung",
                    Email = "dung@gmail.com",
                    Branch = Branch.EE,
                    Gender = Gender.Female,
                    IsRegular = true,
                    Address = "Nam Dinh",
                    Diem = (float)8.1,
                }
            };
        }
        public IActionResult Index()
        {
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranchs = new List<SelectListItem> {
                new SelectListItem
                {
                    Text = "IT",Value ="1"
                },
                new SelectListItem
                {
                    Text = "BE",Value ="2"
                },
                new SelectListItem
                {
                    Text = "CE",Value ="3"
                },
                new SelectListItem
                {
                    Text = "EE",Value ="4"
                },
            };
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student model, IFormFile? image)
        {
            if (ModelState.IsValid)
            { 
                model.Id = students.Last<Student>().Id + 1;
                if (image != null)
                {
                    var folder = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images",
                        "Avatars"
                    );
                    Directory.CreateDirectory(folder);
                    var filename = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName).ToLowerInvariant();
                    var filePath = Path.Combine(folder, filename);
                    using var stream = new FileStream(filePath, FileMode.Create);
                    await image.CopyToAsync(stream);
                    model.Image = $"/images/Avatars/{filename}";
                }
                Console.WriteLine(model.Image);
                students.Add(model);
                return View("Index", students);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranchs = new List<SelectListItem> {
                new SelectListItem
                {
                    Text = "IT",Value ="1"
                },
                new SelectListItem
                {
                    Text = "BE",Value ="2"
                },
                new SelectListItem
                {
                    Text = "CE",Value ="3"
                },
                new SelectListItem
                {
                    Text = "EE",Value ="4"
                },
            };
            return View();
        }
    }
}
