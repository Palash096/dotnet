namespace Membership;

public static class AuthManager
{

    // Validation Method
    public static bool Validate(string email, string password)
    {
        bool status = false;
        if (email == "palashkardhekar5@gmail.com" && password == "palash")
        {
            status = true;
        }
        return status;
    }

    public static bool Register(string firstName, string lastName, string email, string contactNumber, string location)
    {
        bool status = false;
        try
        {
            User theUser = new User();
            theUser.FirstName = firstName;
            theUser.LastName = lastName;
            theUser.Email = email;
            theUser.ContactNumber = contactNumber;
            theUser.Location = location;
            status = true;
        }
        catch (Exception e)
        {
            // Exception Handling
        }
        finally
        {

        }
        return status;
    }
}