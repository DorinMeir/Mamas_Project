using System;
namespace Mamas
{
    public class SousChef:Worker
    {
        public SousChef(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum()) + SalaryManagnent.ExpertEmployee(GetHourSum());
        }
    }
}
