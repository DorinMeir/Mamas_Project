using System;
namespace Mamas
{
    public class Intern:Worker
    {
        public Intern(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
