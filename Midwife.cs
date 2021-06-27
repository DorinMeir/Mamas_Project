using System;
namespace Mamas
{
    public class Midwife:Worker
    {
        public Midwife(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum());
        }
    }
}
