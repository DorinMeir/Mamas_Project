using System;
namespace Mamas
{
    public class ExpertDoctor:Worker
    {
        public ExpertDoctor(string name):base(name)
        {
        }

        public override double GetSalary() 
        {
            return SalaryManagnent.ExpertEmployee(GetHourSum());
        }
    }
}
