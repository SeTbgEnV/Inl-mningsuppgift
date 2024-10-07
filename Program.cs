using System.Text.Encodings.Web;
using System.Text.Json;

namespace School2;

class Program
{
    static void Main()
    {
        Console.Clear();
        //Create an object from the class Course
        // School info
        Course course = new Course("IoT - Internet of Things");
        course.AddCourses(course);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(course.ToString());


        //Pupil Info
        Pupils pupils = new Pupils("333-555-666");
        pupils.AddPupils(pupils);
        Console.WriteLine(pupils.ToString());

        //Course Info
        Teacher teacher = new Teacher("512-125-881");
        teacher.AddTeachers(teacher);
        Console.WriteLine(teacher.ToString());

        //CourseLeader Info
        CourseLeader courseLeader = new CourseLeader("333-555-666");
        Console.WriteLine(courseLeader.ToString());

        //Course 2
        course = new Course("Backend Programmer");
        course.AddCourses(course);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(course.ToString());
        pupils = new Pupils("671-888-317");
        pupils.AddPupils(pupils);
        Console.WriteLine(pupils.ToString());
        teacher = new Teacher("513-135-882");
        teacher.AddTeachers(teacher);
        Console.WriteLine(teacher.ToString());
        courseLeader = new CourseLeader("231-222-231");
        Console.WriteLine(courseLeader.ToString());
        
        //Admin Info
        Admin admin = new Admin();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(admin.ToString());

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nList of Courses");
        foreach (var x in Course.CourseList)
        {
            Console.WriteLine("{0}",x);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nList of Pupils");
        foreach (var y in Pupils.PupilsList)
        {
            Console.WriteLine("{0}",y);
        }
        Console.WriteLine("\nList of Teachers");
        foreach (var z in Teacher.TeachersList)
        {
            Console.WriteLine("{0}",z);
        }
        Console.ResetColor();
        var options = new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            PropertyNameCaseInsensitive = true
        };
        var allVariables = new Variables
        {
            Courses = Course.CourseList
        };
        var path = string.Concat(Environment.CurrentDirectory, "/Data/Jason.json");
        var json = JsonSerializer.Serialize(allVariables, options);
        

        File.WriteAllText(path, json);
        //Skriver ner allt 
        //Console.WriteLine(json);

        var savedJson = File.ReadAllText(path);
        //Skriver upp allt
        Console.WriteLine(savedJson);

        //omvandla till objekt
        options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true
        };
        var variables = JsonSerializer.Deserialize<Variables>(savedJson, options);
        Console.WriteLine(variables);
    }
}