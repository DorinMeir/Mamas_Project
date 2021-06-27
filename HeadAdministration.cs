using System;
namespace Mamas
{
    public class HeadAdministration:Worker
    {
        public HeadAdministration(string name):base(name)
        {
        }
       
        public override double GetSalary()
        {
            return SalaryManagnent.DecsionMaker(51);
        }
    }
}
