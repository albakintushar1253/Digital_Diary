using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Data_Entry_Layer
{
    class UserDataAccess
    {
        DataAccess dataAccess;

        public UserDataAccess()
        {
            this.dataAccess = new DataAccess(); 
        }

        public bool LoginValidation(String username,String password)
        {
            String sql="SELECT * FORM Users WHERE UserName='"+username+ "' AND Password='"+password+ "' ";
            SqlDataReader reader = dataAccess.GetData(sql);
            if(reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
