using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Entities
{
    class CreateEvent
    {

        public int EventId { get; set; }
        public String EventName { get; set; }
        public DateTime Date { get; set; }

     
        public String Importance { get; set; }
        public String EventDescription { get; set; }


    }
}
