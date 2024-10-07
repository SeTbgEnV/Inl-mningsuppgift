
namespace School2;

public class Variables
{
    public List<Course>? Courses { get; set; }

    public override string ToString()
    {
        return $"Course:{Courses}";
    }
}