using System;
namespace Mamas
{
    public class HearedNurse:Worker
    {
        public HearedNurse(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum()) + SalaryManagnent.DecsionMaker(GetHourSum());
        }
    }
}
