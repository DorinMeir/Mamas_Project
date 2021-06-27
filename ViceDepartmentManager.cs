using System;
namespace Mamas
{
    public class ViceDepartmentManager:Worker
    {
        public ViceDepartmentManager(string name):base(name)
        {
        }

        public override double GetSalary() 
        {
            return SalaryManagnent.Mnager() + SalaryManagnent.DecsionMaker(GetHourSum());
        }
    }
}
