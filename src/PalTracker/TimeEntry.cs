using System;

namespace PalTracker
{
   public class TimeEntry
    {
        public TimeEntry(){  
        }
        public long? Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        
        public TimeEntry(long id, long projectId, long userId, DateTime date, int hours)
        {
            Id = id;
            ProjectId = projectId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }

        public TimeEntry(long projectId, long userId, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectId;
            UserId = userId;
            Date = date;
            Hours = hours;
        }

        
        
        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            var timeentry = (TimeEntry)obj;
            return this.Id==timeentry.Id && this.ProjectId == timeentry.ProjectId && this.UserId == timeentry.UserId
                && this.Date == timeentry.Date && this.Hours == timeentry.Hours;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            
            return base.GetHashCode();
        }
    }
}