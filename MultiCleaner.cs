using System;
namespace Mamas
{
    public class MultiCleaner:Worker
    {
        public MultiCleaner(string name):base(name)
        {
        }
        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum());
        }
    }
}
