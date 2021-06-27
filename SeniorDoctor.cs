using System;
namespace Mamas
{
    public class SeniorDoctor:Worker
    {
        public SeniorDoctor(string name):base(name)
        {
        }

        public override double GetSalary() 
        {
            return 0;
        }
    }
}
