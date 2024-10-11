namespace School2;

public class Pupils : Person
{
    public static List<Pupils> PupilsList { get; private set; } = new List<Pupils>();
    public Pupils(string socialNumber)
    {
        SocialNumber = socialNumber;
        Find();
    }
    public void AddPupils(Pupils pupils)
    {
        PupilsList.Add(pupils);
    }
    public virtual void Find()
    {
        if (SocialNumber == "333-555-666")
        {
            FirstName = "Erik";
            LastName = "Eriksson";
            SocialNumber = "333-555-666";
            Age = 20;
            PhoneNumber = "46+ 555 4321";
            Address = "Sankt Eriks Street";
            PostalCode = "444-21";
            City = "New York";
        }
        else if (SocialNumber == "671-888-317")
        {
            FirstName = "David";
            LastName = "Davidsson";
            SocialNumber = "671-888-317";
            Age = 20;
            PhoneNumber = "46+ 512 1126";
            Address = "King Davids Street";
            PostalCode = "495-29";
            City = "Austin";
        }
    }
    public override string ToString()
    {
        return $"\nPupilInfo\nPupil Name: {FirstName} {LastName}\nAge:{Age}-SSN:{SocialNumber}";
    }
}