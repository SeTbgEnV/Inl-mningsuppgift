namespace School2;

public interface ICourses
{
        /* COURSE PROPERTIES */
    public string SchoolAddress { get; set; }
    public int CourseId { get; set; }
    public string CourseTitel { get; set; }
    public string CourseLength { get; set; }
    public string CourseStart { get; set; }
    public string CourseAddress { get; set; }
    public string CourseCity { get; set; }
    public string OnSite { get; set; }
    public static List<Course> CourseList{ get; set; } = new List<Course>();
}