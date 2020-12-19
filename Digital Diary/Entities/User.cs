using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Entities
{
    class User
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String ConfirmePassword { get; set; }
        public String Gender { get; set; }

        public String BloodGroup { get; set; }


    }
}
