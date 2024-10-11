namespace School2;

public class Teacher : Person
{
    // Teacher
    public static List<Teacher> TeachersList { get; protected set; } = new List<Teacher>();
    public string Experience { get; protected set; } = "";
    public string CourseHolder { get; protected set; } = "";

    /* CONSTRUCTOR */
    public Teacher()
    {
    }
    public void AddTeachers(Teacher teachers)
    {
        TeachersList.Add(teachers);
    }
    public Teacher(string socialNumber)
    {
        SocialNumber = socialNumber;
        Find();
    }
    //Metoden Find simulerar en databas 
    //Den tillkallar Find under i publiv virtual void
    public virtual void Find()
    {
        if (SocialNumber == "512-125-881")
        {
            FirstName = "Mario";
            LastName = "Mario";
            SocialNumber = "512-125-881";
            Age = 54;
            PhoneNumber = "49+ 555 5581";
            Address = "Bulevard Road 41";
            PostalCode = "472-28";
            City = "Alabama";
            CourseHolder = "IoT - Internet of Things";
            Experience = "30+ years in IT";

        }
        else if (SocialNumber == "513-135-882")
        {
            FirstName = "Luigi";
            LastName = "Mario";
            SocialNumber = "513-135-882";
            Age = 49;
            PhoneNumber = "49+ 555 6789";
            Address = "Bulevard Road 14";
            PostalCode = "472-28";
            City = "Alabama";
            CourseHolder = "Programming C++";
            Experience = "25+ years in IT";
        }
    }
    //Tostring skriver ut det som är deklarerat innom "databasen" till 
    //det specifika vi har tillkallat
    public override string ToString()
    {
        return $"\nTeacher Name: {FirstName} {LastName}\nAge:{Age}\nPhoneNumber:{PhoneNumber}\n{CourseHolder}\nExperience:{Experience}";
    }

    internal void AddTeachers(object teachers)
    {
        throw new NotImplementedException();
    }
}