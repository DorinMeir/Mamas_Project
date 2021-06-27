using System;
namespace Mamas
{
    public class ShiftManager:Worker
    {
        public ShiftManager(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.Junior(GetHourSum());
        }
    }
}
