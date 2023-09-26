using API.Entities;

namespace API.Data
{
    public static class DataInitializer
    {
        public static void Initialize(CourseContext context)
        {
            if (context.Courses.Any()) return;

            var courses = new List<Course>
            {
                new Course
                {
                    Name = "JavaScript 101",
                    Description =
                        "Free Online course",
                    Prerequisites = "Internet Access",
                    Enrollments = 1000000
                },
                new Course
                {
                    Name = ".Net Development Crash Course",
                    Description =
                        "Paid Online course",
                    Prerequisites = "Degree BSC",
                    Enrollments = 1000
                },
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();
        }
    }
}