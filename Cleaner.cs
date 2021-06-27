using System;
namespace Mamas
{
    public class Cleaner:Worker
    {
        public Cleaner(string name):base(name)
        {
        }
        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
        
    }
}
