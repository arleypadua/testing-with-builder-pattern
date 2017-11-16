using System;

namespace Test.Entity
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double GrossSalary { get; set; }
        
        public double CalculateNetSalary()
        {
            var age = DateTime.Now.Year - BirthDate.Year;

            if (age < 18)
                throw new InvalidOperationException("Age less than 18");
            if (age >= 18 && age < 30)
                return GrossSalary * 0.8;
            else 
                return GrossSalary * 0.85;
        }
    }
}
