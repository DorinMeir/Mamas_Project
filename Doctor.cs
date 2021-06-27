using System;
namespace Mamas
{
    public class Doctor:Worker
    {
        public Doctor(string name):base(name)
        {
            
        }

        public override double GetSalary() 
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum());
        }
    }
}
