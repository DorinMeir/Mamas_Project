using System;
namespace Mamas
{
    public class Nurse:Worker
    {
        public Nurse(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
