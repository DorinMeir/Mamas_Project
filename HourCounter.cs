using System;
namespace Mamas
{
    public class HourCounter
    {
        public DateTime startTime;
        public DateTime endTime;
        public Boolean insertedStart = false;
        public Boolean insertedEnd = false;
        public HourCounter(DateTime startTime)
        {
            this.startTime = startTime;
            insertedStart = true;
        }
        public double GetWorkHour()
        {
            // if the user didnt insert exit time, we wont count his hours.
            if(insertedEnd)
            {
                return (endTime - startTime).TotalHours;
            }
            return 0;
        }
        public void SetEndTime(DateTime endTime)
        {
            this.endTime = endTime;
            insertedEnd = true;
        }
    }
}
