namespace School2;

public class Course
{
    /* COURSE PROPERTIES */
    public string SchoolAddress { get; set; } = "";
    public int CourseId { get; set; }
    public string CourseTitel { get; set; } = "";
    public string CourseLength { get; set; } = "";
    public string CourseStart { get; set; } = "";
    public string CourseAddress { get; set; } = "";
    public int RoomSize { get; set; }
    public string CourseCity { get; set; } = "";
    public string OnSite { get; set; } = "";
    public DateTime DueDate { get; set; }
    public static List<Course> CourseList{ get; set; } = new List<Course>();
    /* CONSTRUCTOR */
    public Course(string courseTitel)
    {
        CourseTitel = courseTitel;
        Find();
    }
    public void AddCourses(Course course)
    {
        CourseList.Add(course);
    }
    public void Find()
    {
        if (CourseTitel == "IoT - Internet of Things")
        {
            CourseTitel = "IoT - Internet of Things";
            CourseLength = "2 years";
            CourseId = 133710;
            CourseStart = "06-22-2024";
            CourseAddress = "Angle Blvd 3";
            CourseCity = "Chicago";
            OnSite = "50%";
            SchoolAddress = "123-321";
            RoomSize = 20;
        }
        else if (CourseTitel == "Backend Programmer")
        {
            CourseTitel = "Backend Programmer";
            CourseLength = "3 years";
            CourseId = 133715;
            CourseStart = "06-23-2024";
            CourseAddress = "Angle Blvd 12";
            CourseCity = "Chicago";
            OnSite = "0%";
            SchoolAddress = "123-321";
            RoomSize = 24;
        }
    }
    public override string ToString()
    {
        return $"Course Info\n\nWhere:{CourseCity}\nCourse:{CourseTitel} // CourseId:{CourseId}\nStart Date:{CourseStart}\nCourse Length:{CourseLength} \nOnsite:{OnSite}";
    }
}