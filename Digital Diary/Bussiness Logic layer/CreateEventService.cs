using Digital_Diary.Data_Entry_Layer;
using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Bussiness_Logic_layer
{
    class CreateEventService
    {
        CreateEventDataAccess CEDA;

       public CreateEventService()
        {
            CEDA = new CreateEventDataAccess();
        }

        public List<CreateEvent> GetCreateEventsList()
        {
            return CEDA.GetAllCreateEvent();
        }

        public  int AddNewCreateEvent(String EventName,DateTime Date,String Importance,String EventDescription)
        {
            CreateEvent CE = new CreateEvent() { EventName = EventName,Date=Date,Importance=Importance,EventDescription=EventDescription };
            return this.CEDA.SaveCreateEvent(CE);

        }

        




    }
}
