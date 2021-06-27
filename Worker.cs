using System;
namespace Mamas
{
    public class Worker
    {
        public static int BaseHourlyWage = 50;
        public string name;
        public int currentMonth;
        public HourCounter[] hours;
        public Worker(string name)
        {
            this.name = name;
            hours = new HourCounter[32];
            currentMonth = 0;
        }
        public Boolean InsertStartHour()
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            if (currentMonth != month)
            {
                ChangeMonth(currentMonth);
            }
            HourCounter temp = hours[day];
            if(temp == null) 
            {
                hours[day] = new HourCounter(now);
                return true;
            } 
            return false;
        }

        public void ChangeMonth(int month) 
        {
            for(int i=0; i<hours.Length; i++) 
            {
                hours[i] = null;
            }
            currentMonth = month;
        }

        public Boolean InsertEndHour() 
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            HourCounter temp = hours[day];
            if(temp != null) 
            {
                temp.SetEndTime(now);
                return true;
            } 
            return false;
        }

        public double GetHourSum()
        {
            double sum = 0;
            for (int i = 0; i < hours.Length; i++)
            {
                if(hours[i] != null)
                {
                    sum = sum + hours[i].GetWorkHour();
                }
            }
            return sum;
        }

        public virtual double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
