using System;
namespace Mamas
{
    public class BreechBirthIntern:Worker
    {
        public BreechBirthIntern(string name):base(name)
        {
            
        }

        public override double GetSalary()
        {
            return SalaryManagnent.ExpertEmployee(GetHourSum());
        }
    }
}
