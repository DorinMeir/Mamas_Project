using System;
namespace Mamas
{
    public class ToxicCleaner:Worker
    {
        public ToxicCleaner(string name):base(name)
        {
        }
        public override double GetSalary()
        {
            double sum = GetHourSum();
            return SalaryManagnent.Junior(sum) + SalaryManagnent.DecsionMaker(sum) + SalaryManagnent.ExpertEmployee(sum) + SalaryManagnent.WorkerAtRisk(1.2, sum);

        }
    }
}
