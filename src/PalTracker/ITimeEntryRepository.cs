using System.Collections.Generic;

namespace PalTracker
{
   public interface ITimeEntryRepository
    {
            TimeEntry Create(TimeEntry timeEntry);

            TimeEntry Find(long val);
            bool Contains(long val);

            List<TimeEntry> List();
            TimeEntry Update(long val1,TimeEntry timeEntry);

             void Delete(long val1);


    }
}