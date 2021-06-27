using System;
namespace Mamas
{
    public class Cook:Worker
    {
        public Cook(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum());
        }
    }
}
