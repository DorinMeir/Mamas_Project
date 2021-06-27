using System;
namespace Mamas
{
    public class DepartmantManager:Worker
    {
        public DepartmantManager(string name):base(name)
        {
        }

        public override double GetSalary() 
        {
            return SalaryManagnent.Mnager() + SalaryManagnent.DecsionMaker(GetHourSum()) + SalaryManagnent.WorkerAtRisk(2.0,GetHourSum());
        }
    }
}
