using Microsoft.EntityFrameworkCore;
using Nvh_Th2_Lab04.Models;

namespace Nvh_Th2_Lab04.Data
{
    public class DbInitalizer
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolContext(serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
            {
                context.Database.EnsureCreated();
                if (context.Majors.Any())
                {
                    return;
                }
                var majors = new Major[]
                {
                    new Major{MajorName= "IT"},
                    new Major{MajorName= "Economics"},
                    new Major{MajorName = "Mathematics"},
                };
                foreach (var major in majors)
                {
                    context.Majors.Add(major);
                }
                context.SaveChanges();
                var leaners = new Learner[]
                {
                    new Learner{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"),MajorID=1},
                                     
                    new Learner{FirstMidName="Meredith",LastName= "Alanso",EnrollmentDate=DateTime.Parse("2002-09-01"),MajorID =2},
                };
                foreach (var lean in leaners)
                {
                    context.Learners.Add(lean);
                }
                context.SaveChanges();
                var courses = new Course[] {
                    new Course{CourseId = 1050, Title="Chemistry",Credits=3},
                    new Course{CourseId=4022, Title = "Microeconomics",Credits=3},
                    new Course{CourseId = 4041,Title ="Macroeconomics",Credits=3},
                };
                foreach (var course in courses)
                {
                    context.Courses.Add(course);
                }
                context.SaveChanges();
                var enrollments = new Enrollment[] {
                    new Enrollment {CouresID= 1050, LearnerID = 1, Grade = 5.5f},
                    new Enrollment
                    {
                        CouresID = 4022, LearnerID = 1, Grade= 7.5f
                    },
                    new Enrollment{LearnerID = 2, CouresID = 1050, Grade = 3.5f},
                    new Enrollment{LearnerID = 2, CouresID = 4041, Grade = 7f},
                };
                foreach(var enrollment in enrollments)
                {
                    context.Enrollments.Add(enrollment);
                }
                context.SaveChanges();
            }
        }
    }
}
