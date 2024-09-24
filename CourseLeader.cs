namespace School2;

public class CourseLeader : Teacher
{
    //Courseleader
    public string DateOfEmployment { get; set; } = "";

    /* CONSTRUCTOR */
    public CourseLeader()
    {
    }
    public CourseLeader(string socialNumber)
    {
        SocialNumber = socialNumber;
        Find();
    }
    //Metoden Find simulerar en databas 
    //Den tillkallar Find under i publiv virtual void
    public override void Find()
    {
        if (SocialNumber == "333-555-666")
        {
            FirstName = "Markus";
            LastName = "Markussonsson";
            SocialNumber = "211-999-791";
            Age = 49;
            PhoneNumber = "49+ 819 4221";
            Address = "Sankt Markus Street";
            PostalCode = "444-21";
            City = "Oakland City";
            Experience = "30+ years in IT";
            DateOfEmployment = "2021-06-21";
        }
        else if (SocialNumber == "231-222-231")
        {
            FirstName = "Oskar";
            LastName = "Oskarsson";
            SocialNumber = "231-222-231";
            Age = 49;
            PhoneNumber = "27+ 222 4388";
            Address = "Sankt eriks Street";
            PostalCode = "412-61";
            City = "Oakland City";
            Experience = "30+ years in IT";
            DateOfEmployment = "2020-01-03";
        }
    }
    //Tostring skriver ut det som är deklarerat innom "databasen" till 
    //det specifika vi har tillkallat
    public override string ToString()
    {
        return $"\nCourseLeaders Name: {FirstName} {LastName} \nCourseLeader PhoneNumber: {PhoneNumber}";
    }
}