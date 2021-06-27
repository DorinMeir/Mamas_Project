using System;
namespace Mamas
{
    public class Medic:Worker
    {
        public Medic(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
