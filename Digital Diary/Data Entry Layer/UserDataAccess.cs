using Digital_Diary.Entities;
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

        public bool LoginValidation(String UserName,String Password)
        {
            String sql=" SELECT * FORM Users WHERE UserName='"+UserName+"'AND Password='"+Password+"' ";
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

       
        //multiple column call
        public List<User> GetAllCreateEvent()
        {
            String sql = " SELECT * FROM  Users";
            SqlDataReader reader = dataAccess.GetData(sql);

            List<User> Users = new List<User>();

            while (reader.Read())
            {
                User CE = new User();
                CE.Id = (int)reader["Id"];
                CE.Name = reader["Name"].ToString();
                CE.UserName = reader["Name"].ToString();
                CE.Email = reader["Email"].ToString();
                CE.Password = reader["Password"].ToString();
                CE.ConfirmePassword = reader["ConfirmePassword"].ToString();
                CE.Gender = reader["Gender"].ToString();
                CE.BloodGroup = reader["BloodGroup"].ToString();


                Users.Add(CE);
            }

            return Users;
        }

        public int Register(User CE)
        {
            String sql = "INSERT INTO Users(Name,UserName,Email,Password,ConfirmePassword,Gender,BloodGroup) VALUES('" + CE.Name + "','" + CE.UserName + "','" + CE.Email + "','" + CE.Password + "','" + CE.ConfirmePassword + "','" + CE.Gender + "','" + CE.BloodGroup + "')";

            int result = dataAccess.ExecuteQuery(sql);
            return result;

        }


    }
}
