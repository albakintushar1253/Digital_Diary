using Digital_Diary.Data_Entry_Layer;
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
        public bool LoginValidation(String username, String password)
        {
            return userDataAccess.LoginValidation(username, password);
        }
    }
}
