using System;
namespace Mamas
{
    public class BreechBirthMidwife:Worker
    {
        public BreechBirthMidwife(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.ExpertEmployee(GetHourSum());
        }
    }
}
