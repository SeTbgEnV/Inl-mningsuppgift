namespace School2;

class Program
{
    static void Main()
    {
        Console.Clear();
        //Create an object from the class Course
        // School info
        Course course = new Course("IoT - Internet of Things");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(course.ToString());

        //Pupil Info
        Pupils pupils = new Pupils("333-555-666");
        Console.WriteLine(pupils.ToString());

        //Course Info
        Teacher teacher = new Teacher("512-125-881");
        Console.WriteLine(teacher.ToString());

        //CourseLeader Info
        CourseLeader courseLeader = new CourseLeader("333-555-666");
        Console.WriteLine(courseLeader.ToString());
       
        //Course 2
        course = new Course("Backend Programmer");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(course.ToString());
        pupils = new Pupils("671-888-317");
        Console.WriteLine(pupils.ToString());
        teacher = new Teacher("513-135-882");
        Console.WriteLine(teacher.ToString());
        courseLeader = new CourseLeader("231-222-231");
        Console.WriteLine(courseLeader.ToString());

        //Admin Info
        Admin admin = new Admin();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(admin.ToString());
    }
}