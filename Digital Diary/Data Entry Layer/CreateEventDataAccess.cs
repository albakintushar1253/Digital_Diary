using Digital_Diary.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary.Data_Entry_Layer
{
    class CreateEventDataAccess
    {
        DataAccess dataAccess;

        public CreateEventDataAccess()
        {
            this.dataAccess = new DataAccess();

        }
        //multiple column call
        public List<CreateEvent> GetAllCreateEvent()
        {
            String sql = " SELECT * FROM  CreateEvents";
            SqlDataReader reader = dataAccess.GetData(sql);

            List<CreateEvent> CreateEvents = new List<CreateEvent>();

            while (reader.Read())
            {
                CreateEvent CE = new CreateEvent();
                CE.EventId = (int)reader["EventId"];
                CE.EventName = reader["EventName"].ToString();
                CE.Date = (DateTime)reader["Date"];
                CE.Importance = reader["Importance"].ToString();
                CE.EventDescription = reader["EventDescription"].ToString();

                CreateEvents.Add(CE);
            }

            return CreateEvents;
        }


        // single column call
        public CreateEvent GetCreateEvent(int id)
        {
            String sql = " SELECT * FROM  CreateEvents WHERE EventId="+id;
            SqlDataReader reader = dataAccess.GetData(sql);

            reader.Read();
            
                CreateEvent CE = new CreateEvent();
                CE.EventId = (int)reader["EventId"];
                CE.EventName = reader["EventName"].ToString();
                CE.Date = (DateTime)reader["Date"];
                CE.Importance = reader["Importance"].ToString();
                CE.EventDescription = reader["EventDescription"].ToString();

                 return CE;
        }


        //insert data
        public int SaveCreateEvent(CreateEvent CE)
        {
            String sql = "INSERT INTO CreateEvents(EventName,Date,Importance,EventDescription) VALUES('"+CE.EventName+"','"+CE.Date+"','"+CE.Importance+"','"+CE.EventDescription+"')";

            int  result = dataAccess.ExecuteQuery(sql);
            return result;

        }

        //update data
        public int ModifyCreateEvent(CreateEvent CE)
        {
            String sql = "UPDATE CreateEvents SET EventName='"+CE.EventName+"',Date='"+CE.Date+"',Importance='"+CE.Importance+"',EventDescription='"+CE.EventDescription+"' WHERE EventId="+CE.EventId;

            int result = dataAccess.ExecuteQuery(sql);
            return result;

        }

        //Delete data
        public int DeleteCreateEvent(int id)
        {
            String sql = "DELETE FROM CreateEvents WHERE EventId="+id;
            int result = dataAccess.ExecuteQuery(sql);
            return result;

        }







    }
}
