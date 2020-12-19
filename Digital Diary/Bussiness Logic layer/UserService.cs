using Digital_Diary.Data_Entry_Layer;
using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Bussiness_Logic_layer
{
    class UserService
    {

        UserDataAccess userDataAccess;
        public UserService()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public bool LoginValidation(String UserName, String Password)
        {
            return userDataAccess.LoginValidation(UserName, Password);
        }

// Registration part
        public int AddNewuser(String Name, String UserName,String Email, String Password, String ConfirmePassword, String Gender, String BloodGroup)
        {
            User ua = new User() { Name = Name, UserName = UserName,Email=Email, Password = Password, ConfirmePassword = ConfirmePassword, Gender = Gender, BloodGroup = BloodGroup };
            return this.userDataAccess.Register(ua);

        }
    }
}
