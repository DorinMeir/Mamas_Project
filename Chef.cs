using System;
namespace Mamas
{
    public class Chef:Worker
    {
        public Chef(string name):base(name)
        {
        }

        public override double GetSalary()
        {
            double sum = GetHourSum();
            return SalaryManagnent.DecsionMaker(sum) + 
            SalaryManagnent.SeniorEmployee(sum) + 
            SalaryManagnent.ExpertEmployee(sum);
        }
    }
}
