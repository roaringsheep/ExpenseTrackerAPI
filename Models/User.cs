namespace Models;
public class User
{
    public User() {}
    
    public int Id { get; set; } = 0;

    public string auth0Id { get; set; } = "";
    
    public string UserName { get; set; } = "";

}