// Creating the public class Users
public class Users
{
    // Creating the class properties.
    public string name { get; set; }
    public string lastname { get; set; }
    public int age { get; set; }
    public string password { get; set; }

    // Creating the ShowInfo method, which displays the info to the user.
    public string ShowInfo()
    {
        return $"Name: {name} {lastname} - Age: {age} years old - Password: {password}";
    }
}