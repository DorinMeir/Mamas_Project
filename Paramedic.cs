using System;
namespace Mamas
{
    public class Paramedic:Worker
    {
        public Paramedic(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
