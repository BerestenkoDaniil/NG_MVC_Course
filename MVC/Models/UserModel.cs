namespace MVC.Models
{
    public class UserModel
    {
       public string Login { get; set; }
       public string Password { get; set; }
       public bool IsAdmin { get; set; }
       public bool IsLogged { get; set; } 
    }
}