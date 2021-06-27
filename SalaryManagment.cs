using System;
namespace Mamas
{
    public class SalaryManagnent
    {
        public SalaryManagnent()
        {
            
        }
        public static double Junior(double Hour)
        {   
            return  Hour * Worker.BaseHourlyWage;
        }
        public static double SeniorEmployee(double Hour)
        {
            return (1.05 * Worker.BaseHourlyWage) * Hour;
        }
        public static double ExpertEmployee(double Hour)
        {
            return (1.30 * Worker.BaseHourlyWage) * Hour;

        }
        public static double DecsionMaker(double Hour)
        {
            if (Hour > 50) 
            {
                return (1.50 * Worker.BaseHourlyWage) * 200;
            }
            return (1.50 * Worker.BaseHourlyWage) * Hour;
        }
        public static double Mnager()
            {
                return 10000;
            }
        public static double WorkerAtRisk(double Present, double Hour)
            {
                return (Present * Worker.BaseHourlyWage) * Hour;
            }
    }
}


