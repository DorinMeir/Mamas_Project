using System;
namespace Mamas
{
    public class FoodDistributes:Worker
    {
        public FoodDistributes(string  name):base(name)
        {
        }

        public override double GetSalary()
        {
            return SalaryManagnent.SeniorEmployee(GetHourSum());
        }
    }
}
