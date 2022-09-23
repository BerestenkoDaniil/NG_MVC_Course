using MVC.Models;
using System.Collections.Generic;

namespace MVC
{
    public static class UserData
    {
        public static List<UserModel> getData()
        {
            return new List<UserModel>()
            {
                new UserModel() { Login="Danya",Password="qwerty1624",IsAdmin=true },
                new UserModel() { Login="YAN",Password="228aboba",IsAdmin=true },
                new UserModel() { Login="ANYA",Password="1834",IsAdmin=false },
                new UserModel() { Login="Andrei",Password="hlop",IsAdmin=false }
            };
        }
    }
}
