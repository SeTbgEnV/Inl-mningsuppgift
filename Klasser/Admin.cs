namespace School2;

public class Admin : CourseLeader
{
    //Administrator
     /* CONSTRUCTOR */
    public Admin()
    {
        Find();
    }
    public override void Find()
    {
        FirstName = "Adam";
        LastName = "Adminsson";
        SocialNumber = "213-321-222";
        Age = 61;
        PhoneNumber = "29+ 666 4441";
        Address = "Granlunda Street";
        PostalCode = "444-21";
        City = "Los Angeles";
        DateOfEmployment = "2018-02-11";
    }
    public override string ToString()
    {
        return $"\nAdmin Name: {FirstName} {LastName}\nAdmin PhoneNumber:{PhoneNumber} ";
    }
}